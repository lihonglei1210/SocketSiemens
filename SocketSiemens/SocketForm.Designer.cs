
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
            this.label2 = new System.Windows.Forms.Label();
            this.Porttextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.IPtextbox = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textShow1 = new SocketSiemens.TextShow();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
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
            this.tabPage1.Text = "SocketServer";
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
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(577, 294);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "SocketClint";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // textShow1
            // 
            this.textShow1.Datatype = thinger.cn.DataConvertHelper.DataType.Float;
            this.textShow1.Location = new System.Drawing.Point(93, 126);
            this.textShow1.Name = "textShow1";
            this.textShow1.Offset = 0;
            this.textShow1.Size = new System.Drawing.Size(149, 28);
            this.textShow1.Start = 0;
            this.textShow1.TabIndex = 5;
            this.textShow1.VarValue = null;
            // 
            // SocketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 317);
            this.Controls.Add(this.tabControl1);
            this.Name = "SocketForm";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
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
    }
}

