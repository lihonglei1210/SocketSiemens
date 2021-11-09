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

        }

        #region Server

       
        //创建Socket
        private Socket tcpClient;

        //创建取消Client数据源
        private CancellationTokenSource ctsClient;
       
        private void btnConnect_Click(object sender, EventArgs e)
        {
            
            if(this.btnConnect.Text=="连接")
            {

                //实例化Socket
                tcpClient = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

                ctsClient = new CancellationTokenSource();

                EndPoint EP = new IPEndPoint(IPAddress.Parse(this.IPtextbox.Text), int.Parse(this.Porttextbox.Text));

                try
                {
                    tcpClient.Connect(EP);
                    MessageBox.Show("连接成功");
                     this.btnConnect.Text ="断开";
                    
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
            byte[] buffer = new byte[4];
            buffer= System.Text.Encoding.Default.GetBytes (textBox1.Text );
            tcpClient.Send(buffer, SocketFlags.None);
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
             if(this.SlientBtn.Text=="启动服务")
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

       private void ListenConnection()
        {
            while (!ctsServer.IsCancellationRequested)
            {
                try
                {
                    Socket tcpClient = TCPserver.Accept();
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
                    length = tcpClient.Receive(buffer, SocketFlags.None);
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



        #endregion

    
    }
}
