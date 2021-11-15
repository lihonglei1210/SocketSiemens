using MQTTnet;
using MQTTnet.Protocol;
using MQTTnet.Server;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using thinger.cn.DataConvertHelper;

namespace SocketSiemens
{
    public partial class SocketForm : Form
    {
        public SocketForm()
        {
            InitializeComponent();

            var ips = Dns.GetHostAddressesAsync(Dns.GetHostName());

            List<string> listip = new List<string>();

            foreach (var ip in ips.Result)
            {
                switch (ip.AddressFamily)
                {

                    case AddressFamily.InterNetwork:
                        if (!listip.Contains(ip.ToString()))
                        {
                            listip.Add(ip.ToString());
                        }
                        break;

                    default:
                        break;
                }

            }
            if (listip.Count>0)
            {
                this.com_ServerIP.DataSource = listip;
                this.com_ServerIP.SelectedIndex = 0;
            }

        }

        #region Server


        //创建Socket
        private Socket tcpClient;

        //创建取消Client数据源
        private CancellationTokenSource ctsClient;

        private void btnConnect_Click(object sender, EventArgs e)
        {

            if (this.btnConnect.Text == "连接")
            {

                //实例化Socket
                tcpClient = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

                ctsClient = new CancellationTokenSource();

                EndPoint EP = new IPEndPoint(IPAddress.Parse(this.IPtextbox.Text), int.Parse(this.Porttextbox.Text));

                try
                {
                    tcpClient.Connect(EP);
                    MessageBox.Show("连接成功");
                    this.btnConnect.Text = "断开";

                }
                catch (Exception ex)
                {
                    MessageBox.Show("连接失败" + ex.Message);

                }



                Task.Run(new Action(() =>
                {
                    GetPLCVaiue();

                }
                ));
            }
            else
            {
                tcpClient.Close();
                ctsClient.Cancel();

                this.btnConnect.Text = "连接";

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Task.Run(new Action(() =>
            {

                SetPLCvaiue();
            }
            ));


        }

        private void SetPLCvaiue()
        {
            byte[] Summary_buffer = new byte[20];
            byte[] buffer = { 0, 0, 0, 0 };
            StrToByte data = new StrToByte();
            foreach (Control item in this.tabPage1.Controls)
            {
                if (item is TextWrite Is)
                {
                    if (Is.VarValue != "")
                    {
                        buffer = data.StringTobyte(Is.Datatype, Is.VarValue);
                        for (int i = 0; i < buffer.Length; i++)
                        {
                            Summary_buffer[Is.Start + i] = buffer[i];

                        }
                    }

                }

            }
            tcpClient.Send(Summary_buffer, SocketFlags.None);


        }

        private void GetPLCVaiue()
        {
            while (!ctsClient.IsCancellationRequested)
            {
                int length = -1;

                byte[] buffer = new byte[1024 * 10];
                try
                {
                    length = tcpClient.Receive(buffer, SocketFlags.None);
                }
                catch (Exception)
                {
                    break;
                }

                if (length == 100)
                {
                    //截取
                    byte[] result = ByteArrayLib.GetByteArray(buffer, 0, length);

                    Invoke(new Action(() =>
                    {

                        foreach (Control item in this.tabPage1.Controls)
                        {
                            if (item is TextShow Is)
                            {
                                switch (Is.Datatype)
                                {
                                    case DataType.Bool:
                                        Is.VarValue = BitLib.GetBitFromByteArray(result, Is.Start, Is.Offset).ToString();
                                        break;
                                    case DataType.Short:
                                        Is.VarValue = ShortLib.GetShortFromByteArray(result, Is.Start).ToString();
                                        break;
                                    case DataType.UShort:
                                        Is.VarValue = UShortLib.GetUShortFromByteArray(result, Is.Start).ToString();
                                        break;
                                    case DataType.Int:
                                        Is.VarValue = IntLib.GetIntFromByteArray(result, Is.Start).ToString();
                                        break;
                                    case DataType.UInt:
                                        Is.VarValue = UIntLib.GetUIntFromByteArray(result, Is.Start).ToString();
                                        break;
                                    case DataType.Float:
                                        Is.VarValue = FloatLib.GetFloatFromByteArray(result, Is.Start).ToString();
                                        break;
                                    case DataType.Double:
                                        Is.VarValue = DoubleLib.GetDoubleFromByteArray(result, Is.Start).ToString();
                                        break;
                                    default:
                                        break;
                                }
                            }
                        }
                    }
                    ));
                }
            }




        }


        #endregion

        #region Client

        private Socket TCPserver;

        //创建取消Server数据源
        private CancellationTokenSource ctsServer;

        private void SlientBtn_Click(object sender, EventArgs e)
        {
            if (this.SlientBtn.Text == "启动服务")
            {
                ctsServer = new CancellationTokenSource();

                TCPserver = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

                EndPoint endSclient = new IPEndPoint(IPAddress.Parse(this.SclintIPTextbox.Text), int.Parse(this.SCPortTextBox.Text));

                try
                {
                    TCPserver.Bind(endSclient);
                    MessageBox.Show("服务开启成功");
                    SlientBtn.Text = "关闭服务";
                    TCPserver.Listen(5);
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("服务开启失败：" + ex.Message);
                }

                Task.Run(new Action(() =>
                {
                    ListenConnection();


                }));

            }
            else
            {
                TCPserver.Close();
                ctsServer.Cancel();
                SlientBtn.Text = "启动服务";

            }


        }
        private Socket TcpserverAccept;
        private void ListenConnection()
        {
            while (!ctsServer.IsCancellationRequested)
            {
                try
                {
                    TcpserverAccept = TCPserver.Accept();
                    Task.Run(new Action(() =>
                    {
                        ReceiveFromPLC(tcpClient);

                    }));

                }
                catch (Exception)
                {
                    break;

                }
            }

        }

        private void ReceiveFromPLC(Socket tcpClient)
        {
            while (!ctsServer.IsCancellationRequested)
            {
                int length = -1;

                byte[] buffer = new byte[1024 * 10];
                try
                {
                    length = TcpserverAccept.Receive(buffer, SocketFlags.None);
                }
                catch (Exception)
                {
                    break;
                }

                if (length > 1)
                {
                    //截取
                    byte[] result = ByteArrayLib.GetByteArray(buffer, 0, length);

                    Invoke(new Action(() =>
                    {

                        foreach (Control item in this.tabPage2.Controls)
                        {
                            if (item is TextShow Is)
                            {
                                switch (Is.Datatype)
                                {
                                    case DataType.Bool:
                                        Is.VarValue = BitLib.GetBitFromByteArray(result, Is.Start, Is.Offset).ToString();
                                        break;
                                    case DataType.Short:
                                        Is.VarValue = ShortLib.GetShortFromByteArray(result, Is.Start).ToString();
                                        break;
                                    case DataType.UShort:
                                        Is.VarValue = UShortLib.GetUShortFromByteArray(result, Is.Start).ToString();
                                        break;
                                    case DataType.Int:
                                        Is.VarValue = IntLib.GetIntFromByteArray(result, Is.Start).ToString();
                                        break;
                                    case DataType.UInt:
                                        Is.VarValue = UIntLib.GetUIntFromByteArray(result, Is.Start).ToString();
                                        break;
                                    case DataType.Float:
                                        Is.VarValue = FloatLib.GetFloatFromByteArray(result, Is.Start).ToString();
                                        break;
                                    case DataType.Double:
                                        Is.VarValue = DoubleLib.GetDoubleFromByteArray(result, Is.Start).ToString();
                                        break;
                                    default:
                                        break;
                                }
                            }
                        }
                    }
                    ));
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Task.Run(new Action(()=>
            {
                ServerWrite();
            }));
        }

        private void ServerWrite()
        {
            byte[] Summary_buffer = new byte[20];
            byte[] buffer = { 0, 0, 0, 0 };
            StrToByte data = new StrToByte();
            foreach (Control item in this.tabPage2.Controls)
            {
                if (item is TextWrite Is)
                {
                    if (Is.VarValue != "")
                    {
                        buffer = data.StringTobyte(Is.Datatype, Is.VarValue);
                        for (int i = 0; i < buffer.Length; i++)
                        {
                            Summary_buffer[Is.Start + i] = buffer[i];

                        }
                    }

                }

            }
            TcpserverAccept.Send(Summary_buffer, SocketFlags.Partial);

        }




        #endregion

        private void SocketForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (SlientBtn.Text == "关闭服务")
                {
                    TCPserver.Close();
                    ctsServer.Cancel();
                }
                if (btnConnect.Text == "断开")
                {
                    tcpClient.Close();
                    ctsClient.Cancel();
                }

            }
            catch (Exception ex)
            {


            }

        }

        private IMqttServer mqttserever;

        private void btn_mqttServer_Click(object sender, EventArgs e)
        {

            mqttserever = new MqttFactory().CreateMqttServer();

            //OptionBuilder
            var optionBuilder = new MqttServerOptionsBuilder();

            optionBuilder.WithConnectionBacklog(10);

            optionBuilder.WithDefaultEndpointPort(Convert.ToInt32(this.tex_mqttPort.Text));

            optionBuilder.WithEncryptedEndpointBoundIPAddress(IPAddress.Parse(this.com_ServerIP.Text));

            MqttServerOptions option = optionBuilder.Build() as MqttServerOptions;

            option.ConnectionValidator += context =>
           {
               if (context.Username != "admin")
               {
                   context.ReturnCode = MqttConnectReturnCode.ConnectionRefusedBadUsernameOrPassword;

                   return;

               }

               if (context.Password != "123456")
               {
                   context.ReturnCode = MqttConnectReturnCode.ConnectionRefusedBadUsernameOrPassword;

                   return;

               }
               context.ReturnCode = MqttConnectReturnCode.ConnectionAccepted;

           };   

            mqttserever.ClientConnected += Mqttserever_ClientConnected;
            mqttserever.ClientDisconnected += Mqttserever_ClientDisconnected;
            mqttserever.ClientSubscribedTopic += Mqttserever_ClientSubscribedTopic;
            mqttserever.ClientUnsubscribedTopic += Mqttserever_ClientUnsubscribedTopic;
            mqttserever.ApplicationMessageReceived += Mqttserever_ApplicationMessageReceived;
            mqttserever.Started += Mqttserever_Started;
            mqttserever.Stopped += Mqttserever_Stopped;
            mqttserever.StartAsync(option);

        }

        private void Mqttserever_Stopped(object sender, EventArgs e)
        {
           MessageBox.Show("服务器停止","提示",MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
        }

        private void Mqttserever_Started(object sender, EventArgs e)
        {
            MessageBox.Show("服务器开启","提示",MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
        }

        private void Mqttserever_ApplicationMessageReceived(object sender, MqttApplicationMessageReceivedEventArgs e)
        {
           
        }

        private void Mqttserever_ClientUnsubscribedTopic(object sender, MqttClientUnsubscribedTopicEventArgs e)
        {
            MessageBox.Show("客户端取消订阅","提示",MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
        }

        private void Mqttserever_ClientSubscribedTopic(object sender, MqttClientSubscribedTopicEventArgs e)
        {
             MessageBox.Show("客户端启动订阅","提示",MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
        }

        private void Mqttserever_ClientDisconnected(object sender, MqttClientDisconnectedEventArgs e)
        {
            MessageBox.Show("客户端断开连接","提示",MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
        }

        private void Mqttserever_ClientConnected(object sender, MqttClientConnectedEventArgs e)
        {
            MessageBox.Show("客户端已连接","提示",MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
        }

        private void btn_mqttstop_Click(object sender, EventArgs e)
        {
            mqttserever.StopAsync();
        }
    }
}
