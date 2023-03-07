namespace IP2ROUTER
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ip = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.script = new System.Windows.Forms.TextBox();
            this.maskname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ifname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gwname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ip);
            this.groupBox1.Location = new System.Drawing.Point(12, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(406, 576);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "IP段";
            // 
            // ip
            // 
            this.ip.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.ip.Location = new System.Drawing.Point(12, 21);
            this.ip.Multiline = true;
            this.ip.Name = "ip";
            this.ip.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ip.Size = new System.Drawing.Size(383, 545);
            this.ip.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(451, 287);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 47);
            this.button1.TabIndex = 1;
            this.button1.Text = ">> 转换";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.script);
            this.groupBox2.Location = new System.Drawing.Point(565, 16);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(700, 576);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "脚本";
            // 
            // script
            // 
            this.script.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.script.Location = new System.Drawing.Point(17, 20);
            this.script.Multiline = true;
            this.script.Name = "script";
            this.script.ReadOnly = true;
            this.script.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.script.Size = new System.Drawing.Size(665, 545);
            this.script.TabIndex = 1;
            // 
            // maskname
            // 
            this.maskname.Location = new System.Drawing.Point(424, 132);
            this.maskname.Name = "maskname";
            this.maskname.Size = new System.Drawing.Size(134, 21);
            this.maskname.TabIndex = 2;
            this.maskname.Text = "255.255.255.255";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(424, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "Netmask";
            // 
            // ifname
            // 
            this.ifname.Location = new System.Drawing.Point(424, 81);
            this.ifname.Name = "ifname";
            this.ifname.Size = new System.Drawing.Size(134, 21);
            this.ifname.TabIndex = 4;
            this.ifname.Text = "wan2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(424, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "Interface";
            // 
            // gwname
            // 
            this.gwname.Location = new System.Drawing.Point(424, 181);
            this.gwname.Name = "gwname";
            this.gwname.Size = new System.Drawing.Size(134, 21);
            this.gwname.TabIndex = 6;
            this.gwname.Text = "192.168.72.39";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(424, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "Gateway";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(451, 368);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 47);
            this.button2.TabIndex = 8;
            this.button2.Text = ">> 命令";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1277, 612);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gwname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ifname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.maskname);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "IP段转脚本";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox ip;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox script;
        private System.Windows.Forms.TextBox maskname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ifname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox gwname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
    }
}

