namespace dy信息
{
    partial class Form1
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.tb_room = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_time = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.tb_msg = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_room = new System.Windows.Forms.Label();
            this.lbl_last = new System.Windows.Forms.Label();
            this.btn_quxiaoSend = new System.Windows.Forms.Button();
            this.lbl_isok = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.显示ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_timeok = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label10 = new System.Windows.Forms.Label();
            this.tb_sendEmail = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tb_sendpwd = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "房间号：";
            // 
            // tb_room
            // 
            this.tb_room.Location = new System.Drawing.Point(144, 18);
            this.tb_room.Margin = new System.Windows.Forms.Padding(4);
            this.tb_room.Name = "tb_room";
            this.tb_room.Size = new System.Drawing.Size(140, 25);
            this.tb_room.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(339, 15);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 29);
            this.button1.TabIndex = 2;
            this.button1.Text = "查询";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 84);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "主播：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 119);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "房间标题：";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(364, 218);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 29);
            this.button2.TabIndex = 5;
            this.button2.Text = "设置";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 225);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "轮询时间：";
            // 
            // tb_time
            // 
            this.tb_time.Location = new System.Drawing.Point(131, 218);
            this.tb_time.Margin = new System.Windows.Forms.Padding(4);
            this.tb_time.Name = "tb_time";
            this.tb_time.Size = new System.Drawing.Size(153, 25);
            this.tb_time.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(289, 224);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "分钟";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 288);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "接收邮箱：";
            // 
            // tb_email
            // 
            this.tb_email.Location = new System.Drawing.Point(131, 278);
            this.tb_email.Margin = new System.Windows.Forms.Padding(4);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(153, 25);
            this.tb_email.TabIndex = 10;
            // 
            // tb_msg
            // 
            this.tb_msg.Enabled = false;
            this.tb_msg.Location = new System.Drawing.Point(501, 15);
            this.tb_msg.Margin = new System.Windows.Forms.Padding(4);
            this.tb_msg.Multiline = true;
            this.tb_msg.Name = "tb_msg";
            this.tb_msg.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.tb_msg.Size = new System.Drawing.Size(299, 295);
            this.tb_msg.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 64);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(439, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "------------------------------------------------------";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(31, 191);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(439, 15);
            this.label8.TabIndex = 13;
            this.label8.Text = "------------------------------------------------------";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(39, 156);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 15);
            this.label9.TabIndex = 14;
            this.label9.Text = "上次直播：";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(128, 84);
            this.lbl_name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(0, 15);
            this.lbl_name.TabIndex = 15;
            // 
            // lbl_room
            // 
            this.lbl_room.AutoSize = true;
            this.lbl_room.Location = new System.Drawing.Point(128, 119);
            this.lbl_room.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_room.Name = "lbl_room";
            this.lbl_room.Size = new System.Drawing.Size(0, 15);
            this.lbl_room.TabIndex = 16;
            // 
            // lbl_last
            // 
            this.lbl_last.AutoSize = true;
            this.lbl_last.Location = new System.Drawing.Point(128, 156);
            this.lbl_last.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_last.Name = "lbl_last";
            this.lbl_last.Size = new System.Drawing.Size(0, 15);
            this.lbl_last.TabIndex = 17;
            // 
            // btn_quxiaoSend
            // 
            this.btn_quxiaoSend.Location = new System.Drawing.Point(653, 320);
            this.btn_quxiaoSend.Margin = new System.Windows.Forms.Padding(4);
            this.btn_quxiaoSend.Name = "btn_quxiaoSend";
            this.btn_quxiaoSend.Size = new System.Drawing.Size(114, 29);
            this.btn_quxiaoSend.TabIndex = 18;
            this.btn_quxiaoSend.Text = "取消发送邮件";
            this.btn_quxiaoSend.UseVisualStyleBackColor = true;
            this.btn_quxiaoSend.Click += new System.EventHandler(this.btn_quxiaoSend_Click);
            // 
            // lbl_isok
            // 
            this.lbl_isok.AutoSize = true;
            this.lbl_isok.Location = new System.Drawing.Point(77, 318);
            this.lbl_isok.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_isok.Name = "lbl_isok";
            this.lbl_isok.Size = new System.Drawing.Size(0, 15);
            this.lbl_isok.TabIndex = 19;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.显示ToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(109, 52);
            // 
            // 显示ToolStripMenuItem
            // 
            this.显示ToolStripMenuItem.Name = "显示ToolStripMenuItem";
            this.显示ToolStripMenuItem.Size = new System.Drawing.Size(108, 24);
            this.显示ToolStripMenuItem.Text = "显示";
            this.显示ToolStripMenuItem.Click += new System.EventHandler(this.显示ToolStripMenuItem_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(108, 24);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // lbl_timeok
            // 
            this.lbl_timeok.AutoSize = true;
            this.lbl_timeok.Location = new System.Drawing.Point(128, 250);
            this.lbl_timeok.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_timeok.Name = "lbl_timeok";
            this.lbl_timeok.Size = new System.Drawing.Size(0, 15);
            this.lbl_timeok.TabIndex = 20;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(350, 274);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(114, 29);
            this.button3.TabIndex = 21;
            this.button3.Text = "取消轮询";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(41, 333);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 15);
            this.label10.TabIndex = 22;
            this.label10.Text = "发送邮箱：";
            // 
            // tb_sendEmail
            // 
            this.tb_sendEmail.Location = new System.Drawing.Point(131, 323);
            this.tb_sendEmail.Margin = new System.Windows.Forms.Padding(4);
            this.tb_sendEmail.Name = "tb_sendEmail";
            this.tb_sendEmail.Size = new System.Drawing.Size(153, 25);
            this.tb_sendEmail.TabIndex = 23;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(307, 326);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(157, 15);
            this.label11.TabIndex = 24;
            this.label11.Text = "发送邮箱服务器密码：";
            // 
            // tb_sendpwd
            // 
            this.tb_sendpwd.Location = new System.Drawing.Point(472, 320);
            this.tb_sendpwd.Margin = new System.Windows.Forms.Padding(4);
            this.tb_sendpwd.Name = "tb_sendpwd";
            this.tb_sendpwd.Size = new System.Drawing.Size(153, 25);
            this.tb_sendpwd.TabIndex = 25;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 358);
            this.Controls.Add(this.tb_sendpwd);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tb_sendEmail);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.lbl_timeok);
            this.Controls.Add(this.lbl_isok);
            this.Controls.Add(this.btn_quxiaoSend);
            this.Controls.Add(this.lbl_last);
            this.Controls.Add(this.lbl_room);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tb_msg);
            this.Controls.Add(this.tb_email);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_time);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tb_room);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "斗鱼房间标题查询";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_room;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_time;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.TextBox tb_msg;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_room;
        private System.Windows.Forms.Label lbl_last;
        private System.Windows.Forms.Button btn_quxiaoSend;
        private System.Windows.Forms.Label lbl_isok;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 显示ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.Label lbl_timeok;
        private System.Windows.Forms.Button button3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tb_sendEmail;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tb_sendpwd;
    }
}

