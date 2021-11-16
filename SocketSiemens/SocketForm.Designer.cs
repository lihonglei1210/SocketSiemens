
namespace SocketSiemens
{
    partial class SocketForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.textWrite5 = new SocketSiemens.TextWrite();
            this.textWrite4 = new SocketSiemens.TextWrite();
            this.textWrite3 = new SocketSiemens.TextWrite();
            this.textWrite2 = new SocketSiemens.TextWrite();
            this.textWrite1 = new SocketSiemens.TextWrite();
            this.ClientwriteBtn = new System.Windows.Forms.Button();
            this.textShow4 = new SocketSiemens.TextShow();
            this.textShow3 = new SocketSiemens.TextShow();
            this.textShow2 = new SocketSiemens.TextShow();
            this.textShow1 = new SocketSiemens.TextShow();
            this.label2 = new System.Windows.Forms.Label();
            this.Porttextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.IPtextbox = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textWrite10 = new SocketSiemens.TextWrite();
            this.textWrite9 = new SocketSiemens.TextWrite();
            this.textWrite8 = new SocketSiemens.TextWrite();
            this.textWrite7 = new SocketSiemens.TextWrite();
            this.textWrite6 = new SocketSiemens.TextWrite();
            this.SerWriteBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SCPortTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SclintIPTextbox = new System.Windows.Forms.TextBox();
            this.SlientBtn = new System.Windows.Forms.Button();
            this.textShow5 = new SocketSiemens.TextShow();
            this.textShow6 = new SocketSiemens.TextShow();
            this.textShow7 = new SocketSiemens.TextShow();
            this.textShow8 = new SocketSiemens.TextShow();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btn_mqttstop = new System.Windows.Forms.Button();
            this.tex_mqttPort = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.com_ServerIP = new System.Windows.Forms.ComboBox();
            this.btn_mqttServer = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btn_Unsubscribe = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_PublishContent = new System.Windows.Forms.TextBox();
            this.txt_SubscribeContent = new System.Windows.Forms.TextBox();
            this.btn_Publish = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_Publish = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_SubscriptionTopic = new System.Windows.Forms.TextBox();
            this.btn_Subscribe = new System.Windows.Forms.Button();
            this.txt_ClientUnm = new System.Windows.Forms.TextBox();
            this.txt_ClientPWD = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_MQTTServerIP = new System.Windows.Forms.TextBox();
            this.btn_ClientDisconnect = new System.Windows.Forms.Button();
            this.txt_ServerPort = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_ClientConnect = new System.Windows.Forms.Button();
            this.cmb_Subscribe = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(-1, -2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(585, 322);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.textWrite5);
            this.tabPage1.Controls.Add(this.textWrite4);
            this.tabPage1.Controls.Add(this.textWrite3);
            this.tabPage1.Controls.Add(this.textWrite2);
            this.tabPage1.Controls.Add(this.textWrite1);
            this.tabPage1.Controls.Add(this.ClientwriteBtn);
            this.tabPage1.Controls.Add(this.textShow4);
            this.tabPage1.Controls.Add(this.textShow3);
            this.tabPage1.Controls.Add(this.textShow2);
            this.tabPage1.Controls.Add(this.textShow1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.Porttextbox);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.IPtextbox);
            this.tabPage1.Controls.Add(this.btnConnect);
            this.tabPage1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(577, 296);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "SocketClient";
            // 
            // textWrite5
            // 
            this.textWrite5.Datatype = SocketSiemens.TextWrite.Parse.Float;
            this.textWrite5.Location = new System.Drawing.Point(333, 214);
            this.textWrite5.Name = "textWrite5";
            this.textWrite5.Offset = 0;
            this.textWrite5.Size = new System.Drawing.Size(116, 27);
            this.textWrite5.Start = 12;
            this.textWrite5.TabIndex = 14;
            this.textWrite5.VarValue = "";
            // 
            // textWrite4
            // 
            this.textWrite4.Datatype = SocketSiemens.TextWrite.Parse.Float;
            this.textWrite4.Location = new System.Drawing.Point(333, 181);
            this.textWrite4.Name = "textWrite4";
            this.textWrite4.Offset = 0;
            this.textWrite4.Size = new System.Drawing.Size(116, 27);
            this.textWrite4.Start = 8;
            this.textWrite4.TabIndex = 13;
            this.textWrite4.VarValue = "";
            // 
            // textWrite3
            // 
            this.textWrite3.Datatype = SocketSiemens.TextWrite.Parse.Short;
            this.textWrite3.Location = new System.Drawing.Point(333, 148);
            this.textWrite3.Name = "textWrite3";
            this.textWrite3.Offset = 0;
            this.textWrite3.Size = new System.Drawing.Size(116, 27);
            this.textWrite3.Start = 6;
            this.textWrite3.TabIndex = 12;
            this.textWrite3.VarValue = "";
            // 
            // textWrite2
            // 
            this.textWrite2.Datatype = SocketSiemens.TextWrite.Parse.Bool;
            this.textWrite2.Location = new System.Drawing.Point(333, 115);
            this.textWrite2.Name = "textWrite2";
            this.textWrite2.Offset = 0;
            this.textWrite2.Size = new System.Drawing.Size(116, 27);
            this.textWrite2.Start = 4;
            this.textWrite2.TabIndex = 11;
            this.textWrite2.VarValue = "";
            // 
            // textWrite1
            // 
            this.textWrite1.Datatype = SocketSiemens.TextWrite.Parse.Float;
            this.textWrite1.Location = new System.Drawing.Point(333, 82);
            this.textWrite1.Name = "textWrite1";
            this.textWrite1.Offset = 0;
            this.textWrite1.Size = new System.Drawing.Size(116, 27);
            this.textWrite1.Start = 0;
            this.textWrite1.TabIndex = 10;
            this.textWrite1.VarValue = "";
            // 
            // ClientwriteBtn
            // 
            this.ClientwriteBtn.Location = new System.Drawing.Point(455, 139);
            this.ClientwriteBtn.Name = "ClientwriteBtn";
            this.ClientwriteBtn.Size = new System.Drawing.Size(75, 23);
            this.ClientwriteBtn.TabIndex = 9;
            this.ClientwriteBtn.Text = "发送";
            this.ClientwriteBtn.UseVisualStyleBackColor = true;
            this.ClientwriteBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // textShow4
            // 
            this.textShow4.Datatype = thinger.cn.DataConvertHelper.DataType.Float;
            this.textShow4.Location = new System.Drawing.Point(93, 174);
            this.textShow4.Name = "textShow4";
            this.textShow4.Offset = 0;
            this.textShow4.Size = new System.Drawing.Size(149, 28);
            this.textShow4.Start = 12;
            this.textShow4.TabIndex = 8;
            this.textShow4.VarValue = "";
            // 
            // textShow3
            // 
            this.textShow3.Datatype = thinger.cn.DataConvertHelper.DataType.Float;
            this.textShow3.Location = new System.Drawing.Point(93, 140);
            this.textShow3.Name = "textShow3";
            this.textShow3.Offset = 0;
            this.textShow3.Size = new System.Drawing.Size(149, 28);
            this.textShow3.Start = 8;
            this.textShow3.TabIndex = 7;
            this.textShow3.VarValue = "";
            // 
            // textShow2
            // 
            this.textShow2.Datatype = thinger.cn.DataConvertHelper.DataType.Float;
            this.textShow2.Location = new System.Drawing.Point(93, 106);
            this.textShow2.Name = "textShow2";
            this.textShow2.Offset = 0;
            this.textShow2.Size = new System.Drawing.Size(149, 28);
            this.textShow2.Start = 4;
            this.textShow2.TabIndex = 6;
            this.textShow2.VarValue = "";
            // 
            // textShow1
            // 
            this.textShow1.Datatype = thinger.cn.DataConvertHelper.DataType.Float;
            this.textShow1.Location = new System.Drawing.Point(93, 72);
            this.textShow1.Name = "textShow1";
            this.textShow1.Offset = 0;
            this.textShow1.Size = new System.Drawing.Size(115, 28);
            this.textShow1.Start = 0;
            this.textShow1.TabIndex = 5;
            this.textShow1.VarValue = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(244, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "PLC-端口号";
            // 
            // Porttextbox
            // 
            this.Porttextbox.Location = new System.Drawing.Point(315, 33);
            this.Porttextbox.Name = "Porttextbox";
            this.Porttextbox.Size = new System.Drawing.Size(134, 21);
            this.Porttextbox.TabIndex = 3;
            this.Porttextbox.Text = "2000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "PLC-IP地址";
            // 
            // IPtextbox
            // 
            this.IPtextbox.Location = new System.Drawing.Point(93, 31);
            this.IPtextbox.Name = "IPtextbox";
            this.IPtextbox.Size = new System.Drawing.Size(134, 21);
            this.IPtextbox.TabIndex = 1;
            this.IPtextbox.Text = "192.168.1.20";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(455, 31);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 0;
            this.btnConnect.Text = "连接";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.textWrite10);
            this.tabPage2.Controls.Add(this.textWrite9);
            this.tabPage2.Controls.Add(this.textWrite8);
            this.tabPage2.Controls.Add(this.textWrite7);
            this.tabPage2.Controls.Add(this.textWrite6);
            this.tabPage2.Controls.Add(this.SerWriteBtn);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.SCPortTextBox);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.SclintIPTextbox);
            this.tabPage2.Controls.Add(this.SlientBtn);
            this.tabPage2.Controls.Add(this.textShow5);
            this.tabPage2.Controls.Add(this.textShow6);
            this.tabPage2.Controls.Add(this.textShow7);
            this.tabPage2.Controls.Add(this.textShow8);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(577, 296);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "SocketServer";
            // 
            // textWrite10
            // 
            this.textWrite10.Datatype = SocketSiemens.TextWrite.Parse.Float;
            this.textWrite10.Location = new System.Drawing.Point(325, 175);
            this.textWrite10.Name = "textWrite10";
            this.textWrite10.Offset = 0;
            this.textWrite10.Size = new System.Drawing.Size(116, 27);
            this.textWrite10.Start = 12;
            this.textWrite10.TabIndex = 19;
            this.textWrite10.VarValue = "";
            // 
            // textWrite9
            // 
            this.textWrite9.Datatype = SocketSiemens.TextWrite.Parse.Float;
            this.textWrite9.Location = new System.Drawing.Point(325, 208);
            this.textWrite9.Name = "textWrite9";
            this.textWrite9.Offset = 0;
            this.textWrite9.Size = new System.Drawing.Size(116, 27);
            this.textWrite9.Start = 16;
            this.textWrite9.TabIndex = 18;
            this.textWrite9.VarValue = "";
            // 
            // textWrite8
            // 
            this.textWrite8.Datatype = SocketSiemens.TextWrite.Parse.Float;
            this.textWrite8.Location = new System.Drawing.Point(325, 142);
            this.textWrite8.Name = "textWrite8";
            this.textWrite8.Offset = 0;
            this.textWrite8.Size = new System.Drawing.Size(116, 27);
            this.textWrite8.Start = 8;
            this.textWrite8.TabIndex = 17;
            this.textWrite8.VarValue = "";
            // 
            // textWrite7
            // 
            this.textWrite7.Datatype = SocketSiemens.TextWrite.Parse.Float;
            this.textWrite7.Location = new System.Drawing.Point(325, 76);
            this.textWrite7.Name = "textWrite7";
            this.textWrite7.Offset = 0;
            this.textWrite7.Size = new System.Drawing.Size(116, 27);
            this.textWrite7.Start = 0;
            this.textWrite7.TabIndex = 16;
            this.textWrite7.VarValue = "";
            // 
            // textWrite6
            // 
            this.textWrite6.Datatype = SocketSiemens.TextWrite.Parse.Float;
            this.textWrite6.Location = new System.Drawing.Point(325, 109);
            this.textWrite6.Name = "textWrite6";
            this.textWrite6.Offset = 0;
            this.textWrite6.Size = new System.Drawing.Size(116, 27);
            this.textWrite6.Start = 4;
            this.textWrite6.TabIndex = 15;
            this.textWrite6.VarValue = "";
            // 
            // SerWriteBtn
            // 
            this.SerWriteBtn.Location = new System.Drawing.Point(465, 98);
            this.SerWriteBtn.Name = "SerWriteBtn";
            this.SerWriteBtn.Size = new System.Drawing.Size(75, 23);
            this.SerWriteBtn.TabIndex = 14;
            this.SerWriteBtn.Text = "发送";
            this.SerWriteBtn.UseVisualStyleBackColor = true;
            this.SerWriteBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(254, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "PLC-端口号";
            // 
            // SCPortTextBox
            // 
            this.SCPortTextBox.Location = new System.Drawing.Point(325, 25);
            this.SCPortTextBox.Name = "SCPortTextBox";
            this.SCPortTextBox.Size = new System.Drawing.Size(134, 21);
            this.SCPortTextBox.TabIndex = 8;
            this.SCPortTextBox.Text = "2000";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "PLC-IP地址";
            // 
            // SclintIPTextbox
            // 
            this.SclintIPTextbox.Location = new System.Drawing.Point(103, 23);
            this.SclintIPTextbox.Name = "SclintIPTextbox";
            this.SclintIPTextbox.Size = new System.Drawing.Size(134, 21);
            this.SclintIPTextbox.TabIndex = 6;
            this.SclintIPTextbox.Text = "192.168.0.100";
            // 
            // SlientBtn
            // 
            this.SlientBtn.Location = new System.Drawing.Point(465, 23);
            this.SlientBtn.Name = "SlientBtn";
            this.SlientBtn.Size = new System.Drawing.Size(75, 23);
            this.SlientBtn.TabIndex = 5;
            this.SlientBtn.Text = "启动服务";
            this.SlientBtn.UseVisualStyleBackColor = true;
            this.SlientBtn.Click += new System.EventHandler(this.SlientBtn_Click);
            // 
            // textShow5
            // 
            this.textShow5.Datatype = thinger.cn.DataConvertHelper.DataType.Int;
            this.textShow5.Location = new System.Drawing.Point(103, 200);
            this.textShow5.Name = "textShow5";
            this.textShow5.Offset = 0;
            this.textShow5.Size = new System.Drawing.Size(149, 28);
            this.textShow5.Start = 10;
            this.textShow5.TabIndex = 13;
            this.textShow5.VarValue = "";
            // 
            // textShow6
            // 
            this.textShow6.Datatype = thinger.cn.DataConvertHelper.DataType.Float;
            this.textShow6.Location = new System.Drawing.Point(103, 166);
            this.textShow6.Name = "textShow6";
            this.textShow6.Offset = 0;
            this.textShow6.Size = new System.Drawing.Size(149, 28);
            this.textShow6.Start = 6;
            this.textShow6.TabIndex = 12;
            this.textShow6.VarValue = "";
            // 
            // textShow7
            // 
            this.textShow7.Datatype = thinger.cn.DataConvertHelper.DataType.Bool;
            this.textShow7.Location = new System.Drawing.Point(103, 132);
            this.textShow7.Name = "textShow7";
            this.textShow7.Offset = 0;
            this.textShow7.Size = new System.Drawing.Size(149, 28);
            this.textShow7.Start = 4;
            this.textShow7.TabIndex = 11;
            this.textShow7.VarValue = "";
            // 
            // textShow8
            // 
            this.textShow8.Datatype = thinger.cn.DataConvertHelper.DataType.Float;
            this.textShow8.Location = new System.Drawing.Point(103, 98);
            this.textShow8.Name = "textShow8";
            this.textShow8.Offset = 0;
            this.textShow8.Size = new System.Drawing.Size(149, 28);
            this.textShow8.Start = 0;
            this.textShow8.TabIndex = 10;
            this.textShow8.VarValue = "";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage3.Controls.Add(this.btn_mqttstop);
            this.tabPage3.Controls.Add(this.tex_mqttPort);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.com_ServerIP);
            this.tabPage3.Controls.Add(this.btn_mqttServer);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(577, 296);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "MQTTServer";
            // 
            // btn_mqttstop
            // 
            this.btn_mqttstop.Location = new System.Drawing.Point(466, 67);
            this.btn_mqttstop.Name = "btn_mqttstop";
            this.btn_mqttstop.Size = new System.Drawing.Size(75, 23);
            this.btn_mqttstop.TabIndex = 6;
            this.btn_mqttstop.Text = "关闭服务";
            this.btn_mqttstop.UseVisualStyleBackColor = true;
            this.btn_mqttstop.Click += new System.EventHandler(this.btn_mqttstop_Click);
            // 
            // tex_mqttPort
            // 
            this.tex_mqttPort.Location = new System.Drawing.Point(321, 26);
            this.tex_mqttPort.Name = "tex_mqttPort";
            this.tex_mqttPort.Size = new System.Drawing.Size(123, 21);
            this.tex_mqttPort.TabIndex = 5;
            this.tex_mqttPort.Text = "1883";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(232, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 12);
            this.label6.TabIndex = 4;
            this.label6.Text = "Server Port：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 12);
            this.label5.TabIndex = 2;
            this.label5.Text = "Server IP：";
            // 
            // com_ServerIP
            // 
            this.com_ServerIP.FormattingEnabled = true;
            this.com_ServerIP.Location = new System.Drawing.Point(93, 26);
            this.com_ServerIP.Name = "com_ServerIP";
            this.com_ServerIP.Size = new System.Drawing.Size(121, 20);
            this.com_ServerIP.TabIndex = 1;
            // 
            // btn_mqttServer
            // 
            this.btn_mqttServer.Location = new System.Drawing.Point(466, 24);
            this.btn_mqttServer.Name = "btn_mqttServer";
            this.btn_mqttServer.Size = new System.Drawing.Size(75, 23);
            this.btn_mqttServer.TabIndex = 0;
            this.btn_mqttServer.Text = "启动服务";
            this.btn_mqttServer.UseVisualStyleBackColor = true;
            this.btn_mqttServer.Click += new System.EventHandler(this.btn_mqttServer_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage4.Controls.Add(this.cmb_Subscribe);
            this.tabPage4.Controls.Add(this.btn_Unsubscribe);
            this.tabPage4.Controls.Add(this.label13);
            this.tabPage4.Controls.Add(this.txt_PublishContent);
            this.tabPage4.Controls.Add(this.txt_SubscribeContent);
            this.tabPage4.Controls.Add(this.btn_Publish);
            this.tabPage4.Controls.Add(this.label12);
            this.tabPage4.Controls.Add(this.txt_Publish);
            this.tabPage4.Controls.Add(this.label11);
            this.tabPage4.Controls.Add(this.txt_SubscriptionTopic);
            this.tabPage4.Controls.Add(this.btn_Subscribe);
            this.tabPage4.Controls.Add(this.txt_ClientUnm);
            this.tabPage4.Controls.Add(this.txt_ClientPWD);
            this.tabPage4.Controls.Add(this.label9);
            this.tabPage4.Controls.Add(this.label10);
            this.tabPage4.Controls.Add(this.txt_MQTTServerIP);
            this.tabPage4.Controls.Add(this.btn_ClientDisconnect);
            this.tabPage4.Controls.Add(this.txt_ServerPort);
            this.tabPage4.Controls.Add(this.label7);
            this.tabPage4.Controls.Add(this.label8);
            this.tabPage4.Controls.Add(this.btn_ClientConnect);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(577, 296);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "MQTTClient";
            // 
            // btn_Unsubscribe
            // 
            this.btn_Unsubscribe.Location = new System.Drawing.Point(108, 262);
            this.btn_Unsubscribe.Name = "btn_Unsubscribe";
            this.btn_Unsubscribe.Size = new System.Drawing.Size(75, 23);
            this.btn_Unsubscribe.TabIndex = 28;
            this.btn_Unsubscribe.Text = "退订";
            this.btn_Unsubscribe.UseVisualStyleBackColor = true;
            this.btn_Unsubscribe.Click += new System.EventHandler(this.btn_Unsubscribe_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(186, 267);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(77, 12);
            this.label13.TabIndex = 27;
            this.label13.Text = "已订阅主题：";
            // 
            // txt_PublishContent
            // 
            this.txt_PublishContent.Location = new System.Drawing.Point(352, 133);
            this.txt_PublishContent.Multiline = true;
            this.txt_PublishContent.Name = "txt_PublishContent";
            this.txt_PublishContent.Size = new System.Drawing.Size(198, 123);
            this.txt_PublishContent.TabIndex = 25;
            // 
            // txt_SubscribeContent
            // 
            this.txt_SubscribeContent.Location = new System.Drawing.Point(27, 133);
            this.txt_SubscribeContent.Multiline = true;
            this.txt_SubscribeContent.Name = "txt_SubscribeContent";
            this.txt_SubscribeContent.Size = new System.Drawing.Size(305, 123);
            this.txt_SubscribeContent.TabIndex = 24;
            // 
            // btn_Publish
            // 
            this.btn_Publish.Location = new System.Drawing.Point(475, 262);
            this.btn_Publish.Name = "btn_Publish";
            this.btn_Publish.Size = new System.Drawing.Size(75, 23);
            this.btn_Publish.TabIndex = 23;
            this.btn_Publish.Text = "发布";
            this.btn_Publish.UseVisualStyleBackColor = true;
            this.btn_Publish.Click += new System.EventHandler(this.btn_Publish_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(350, 109);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 12);
            this.label12.TabIndex = 22;
            this.label12.Text = "发布主题：";
            // 
            // txt_Publish
            // 
            this.txt_Publish.Location = new System.Drawing.Point(427, 106);
            this.txt_Publish.Name = "txt_Publish";
            this.txt_Publish.Size = new System.Drawing.Size(123, 21);
            this.txt_Publish.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(25, 111);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 12);
            this.label11.TabIndex = 20;
            this.label11.Text = "订阅主题：";
            // 
            // txt_SubscriptionTopic
            // 
            this.txt_SubscriptionTopic.Location = new System.Drawing.Point(102, 106);
            this.txt_SubscriptionTopic.Name = "txt_SubscriptionTopic";
            this.txt_SubscriptionTopic.Size = new System.Drawing.Size(123, 21);
            this.txt_SubscriptionTopic.TabIndex = 19;
            // 
            // btn_Subscribe
            // 
            this.btn_Subscribe.Location = new System.Drawing.Point(27, 262);
            this.btn_Subscribe.Name = "btn_Subscribe";
            this.btn_Subscribe.Size = new System.Drawing.Size(75, 23);
            this.btn_Subscribe.TabIndex = 18;
            this.btn_Subscribe.Text = "订阅";
            this.btn_Subscribe.UseVisualStyleBackColor = true;
            this.btn_Subscribe.Click += new System.EventHandler(this.btn_Subscribe_Click);
            // 
            // txt_ClientUnm
            // 
            this.txt_ClientUnm.Location = new System.Drawing.Point(102, 66);
            this.txt_ClientUnm.Name = "txt_ClientUnm";
            this.txt_ClientUnm.Size = new System.Drawing.Size(123, 21);
            this.txt_ClientUnm.TabIndex = 17;
            this.txt_ClientUnm.Text = "admin";
            // 
            // txt_ClientPWD
            // 
            this.txt_ClientPWD.Location = new System.Drawing.Point(427, 66);
            this.txt_ClientPWD.Name = "txt_ClientPWD";
            this.txt_ClientPWD.Size = new System.Drawing.Size(123, 21);
            this.txt_ClientPWD.TabIndex = 16;
            this.txt_ClientPWD.Text = "123456";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(350, 69);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 12);
            this.label9.TabIndex = 15;
            this.label9.Text = "Password：";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(25, 69);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 12);
            this.label10.TabIndex = 14;
            this.label10.Text = "UseName：";
            // 
            // txt_MQTTServerIP
            // 
            this.txt_MQTTServerIP.Location = new System.Drawing.Point(102, 23);
            this.txt_MQTTServerIP.Name = "txt_MQTTServerIP";
            this.txt_MQTTServerIP.Size = new System.Drawing.Size(123, 21);
            this.txt_MQTTServerIP.TabIndex = 13;
            this.txt_MQTTServerIP.Text = "192.168.1.100";
            // 
            // btn_ClientDisconnect
            // 
            this.btn_ClientDisconnect.Location = new System.Drawing.Point(257, 64);
            this.btn_ClientDisconnect.Name = "btn_ClientDisconnect";
            this.btn_ClientDisconnect.Size = new System.Drawing.Size(75, 23);
            this.btn_ClientDisconnect.TabIndex = 12;
            this.btn_ClientDisconnect.Text = "断开";
            this.btn_ClientDisconnect.UseVisualStyleBackColor = true;
            this.btn_ClientDisconnect.Click += new System.EventHandler(this.btn_ClientDisconnect_Click);
            // 
            // txt_ServerPort
            // 
            this.txt_ServerPort.Location = new System.Drawing.Point(427, 23);
            this.txt_ServerPort.Name = "txt_ServerPort";
            this.txt_ServerPort.Size = new System.Drawing.Size(123, 21);
            this.txt_ServerPort.TabIndex = 11;
            this.txt_ServerPort.Text = "1883";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(350, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 12);
            this.label7.TabIndex = 10;
            this.label7.Text = "Server Port：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 12);
            this.label8.TabIndex = 9;
            this.label8.Text = "Server IP：";
            // 
            // btn_ClientConnect
            // 
            this.btn_ClientConnect.Location = new System.Drawing.Point(257, 21);
            this.btn_ClientConnect.Name = "btn_ClientConnect";
            this.btn_ClientConnect.Size = new System.Drawing.Size(75, 23);
            this.btn_ClientConnect.TabIndex = 7;
            this.btn_ClientConnect.Text = "连接";
            this.btn_ClientConnect.UseVisualStyleBackColor = true;
            this.btn_ClientConnect.Click += new System.EventHandler(this.btn_ClientConnect_Click);
            // 
            // cmb_Subscribe
            // 
            this.cmb_Subscribe.FormattingEnabled = true;
            this.cmb_Subscribe.Location = new System.Drawing.Point(269, 264);
            this.cmb_Subscribe.Name = "cmb_Subscribe";
            this.cmb_Subscribe.Size = new System.Drawing.Size(121, 20);
            this.cmb_Subscribe.TabIndex = 29;
            // 
            // SocketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 320);
            this.Controls.Add(this.tabControl1);
            this.Name = "SocketForm";
            this.Text = "Socket";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SocketForm_FormClosing);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Porttextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox IPtextbox;
        private System.Windows.Forms.Button btnConnect;
        private TextShow textShow1;
        private TextShow textShow4;
        private TextShow textShow3;
        private TextShow textShow2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SCPortTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox SclintIPTextbox;
        private System.Windows.Forms.Button SlientBtn;
        private TextShow textShow5;
        private TextShow textShow6;
        private TextShow textShow7;
        private TextShow textShow8;
        private System.Windows.Forms.Button ClientwriteBtn;
        private TextWrite textWrite1;
        private TextWrite textWrite5;
        private TextWrite textWrite4;
        private TextWrite textWrite3;
        private TextWrite textWrite2;
        private System.Windows.Forms.Button SerWriteBtn;
        private TextWrite textWrite6;
        private TextWrite textWrite10;
        private TextWrite textWrite9;
        private TextWrite textWrite8;
        private TextWrite textWrite7;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox tex_mqttPort;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox com_ServerIP;
        private System.Windows.Forms.Button btn_mqttServer;
        private System.Windows.Forms.Button btn_mqttstop;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TextBox txt_ClientUnm;
        private System.Windows.Forms.TextBox txt_ClientPWD;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_MQTTServerIP;
        private System.Windows.Forms.Button btn_ClientDisconnect;
        private System.Windows.Forms.TextBox txt_ServerPort;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_ClientConnect;
        private System.Windows.Forms.TextBox txt_SubscriptionTopic;
        private System.Windows.Forms.Button btn_Subscribe;
        private System.Windows.Forms.TextBox txt_PublishContent;
        private System.Windows.Forms.TextBox txt_SubscribeContent;
        private System.Windows.Forms.Button btn_Publish;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_Publish;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btn_Unsubscribe;
        private System.Windows.Forms.ComboBox cmb_Subscribe;
    }
}

