
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
            this.ClientwriteBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Porttextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.IPtextbox = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.SCPortTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SclintIPTextbox = new System.Windows.Forms.TextBox();
            this.SlientBtn = new System.Windows.Forms.Button();
            this.SerWriteBtn = new System.Windows.Forms.Button();
            this.textWrite5 = new SocketSiemens.TextWrite();
            this.textWrite4 = new SocketSiemens.TextWrite();
            this.textWrite3 = new SocketSiemens.TextWrite();
            this.textWrite2 = new SocketSiemens.TextWrite();
            this.textWrite1 = new SocketSiemens.TextWrite();
            this.textShow4 = new SocketSiemens.TextShow();
            this.textShow3 = new SocketSiemens.TextShow();
            this.textShow2 = new SocketSiemens.TextShow();
            this.textShow1 = new SocketSiemens.TextShow();
            this.textWrite6 = new SocketSiemens.TextWrite();
            this.textShow5 = new SocketSiemens.TextShow();
            this.textShow6 = new SocketSiemens.TextShow();
            this.textShow7 = new SocketSiemens.TextShow();
            this.textShow8 = new SocketSiemens.TextShow();
            this.textWrite7 = new SocketSiemens.TextWrite();
            this.textWrite8 = new SocketSiemens.TextWrite();
            this.textWrite9 = new SocketSiemens.TextWrite();
            this.textWrite10 = new SocketSiemens.TextWrite();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(-1, -2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(585, 320);
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
            this.tabPage1.Size = new System.Drawing.Size(577, 294);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "SocketClient";
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
            this.tabPage2.Size = new System.Drawing.Size(577, 294);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "SocketServer";
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
            // SocketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 317);
            this.Controls.Add(this.tabControl1);
            this.Name = "SocketForm";
            this.Text = "Socket";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SocketForm_FormClosing);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
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
    }
}

