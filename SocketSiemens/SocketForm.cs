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

        //创建Socket
        private Socket tcpClient;

        //创建取消数据源
        private CancellationTokenSource cts = new CancellationTokenSource();

        private void btnConnect_Click(object sender, EventArgs e)
        {
            
            if(this.btnConnect.Text=="连接")
            {

                //实例化Socket
                tcpClient = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

                EndPoint EP = new IPEndPoint(IPAddress.Parse(this.IPtextbox.Text), int.Parse(this.Porttextbox.Text));

                try
                {
                    tcpClient.Connect(EP);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("连接失败" + ex.Message);

                }

                MessageBox.Show("连接成功");
                this.btnConnect.Text ="断开";
                Task.Run(new Action(() =>
                {

                    GetPLCVaiue();
                }


                ));
            }
            else
            {
                tcpClient.Close();
                cts.Cancel(); 
                this.btnConnect.Text = "连接";

            }
           
        }

        private void GetPLCVaiue()
        {
            while (!cts.IsCancellationRequested)
            {
                int length=-1;

                byte[] buffer = new byte[1024 * 10];
                try
                {
                    length = tcpClient.Receive(buffer, SocketFlags.None);
                }
                catch (Exception)
                {
                    break;
                }

                if (length==100)
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
    }
}
