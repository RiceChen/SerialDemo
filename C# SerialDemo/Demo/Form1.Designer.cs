namespace Demo
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.receive_box = new System.Windows.Forms.TextBox();
            this.send_box = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.baud = new System.Windows.Forms.ComboBox();
            this.data_bit = new System.Windows.Forms.ComboBox();
            this.stop_bit = new System.Windows.Forms.ComboBox();
            this.parity = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.scan = new System.Windows.Forms.Button();
            this.open = new System.Windows.Forms.Button();
            this.send = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.port = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.receive_box);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(295, 210);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Receive";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.send_box);
            this.groupBox2.Location = new System.Drawing.Point(13, 229);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(295, 103);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Send";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.port);
            this.groupBox3.Controls.Add(this.open);
            this.groupBox3.Controls.Add(this.scan);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.parity);
            this.groupBox3.Controls.Add(this.stop_bit);
            this.groupBox3.Controls.Add(this.data_bit);
            this.groupBox3.Controls.Add(this.baud);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(315, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(166, 210);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // receive_box
            // 
            this.receive_box.Location = new System.Drawing.Point(6, 20);
            this.receive_box.Multiline = true;
            this.receive_box.Name = "receive_box";
            this.receive_box.Size = new System.Drawing.Size(283, 184);
            this.receive_box.TabIndex = 0;
            // 
            // send_box
            // 
            this.send_box.Location = new System.Drawing.Point(6, 20);
            this.send_box.Multiline = true;
            this.send_box.Name = "send_box";
            this.send_box.Size = new System.Drawing.Size(283, 77);
            this.send_box.TabIndex = 1;
            this.send_box.Text = "Rice DIY";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Port：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "Baud：";
            // 
            // baud
            // 
            this.baud.FormattingEnabled = true;
            this.baud.Items.AddRange(new object[] {
            "4800",
            "9600",
            "115200"});
            this.baud.Location = new System.Drawing.Point(73, 46);
            this.baud.Name = "baud";
            this.baud.Size = new System.Drawing.Size(87, 20);
            this.baud.TabIndex = 3;
            this.baud.Text = "115200";
            // 
            // data_bit
            // 
            this.data_bit.FormattingEnabled = true;
            this.data_bit.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8"});
            this.data_bit.Location = new System.Drawing.Point(73, 72);
            this.data_bit.Name = "data_bit";
            this.data_bit.Size = new System.Drawing.Size(87, 20);
            this.data_bit.TabIndex = 4;
            this.data_bit.Text = "8";
            // 
            // stop_bit
            // 
            this.stop_bit.FormattingEnabled = true;
            this.stop_bit.Items.AddRange(new object[] {
            "1",
            "1.5",
            "2"});
            this.stop_bit.Location = new System.Drawing.Point(73, 98);
            this.stop_bit.Name = "stop_bit";
            this.stop_bit.Size = new System.Drawing.Size(87, 20);
            this.stop_bit.TabIndex = 5;
            this.stop_bit.Text = "1";
            // 
            // parity
            // 
            this.parity.FormattingEnabled = true;
            this.parity.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even"});
            this.parity.Location = new System.Drawing.Point(73, 124);
            this.parity.Name = "parity";
            this.parity.Size = new System.Drawing.Size(87, 20);
            this.parity.TabIndex = 6;
            this.parity.Text = "None";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "Data bit：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "Stop bit：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "Parity：";
            // 
            // scan
            // 
            this.scan.Location = new System.Drawing.Point(9, 150);
            this.scan.Name = "scan";
            this.scan.Size = new System.Drawing.Size(151, 23);
            this.scan.TabIndex = 10;
            this.scan.Text = "scan";
            this.scan.UseVisualStyleBackColor = true;
            this.scan.Click += new System.EventHandler(this.scan_Click);
            // 
            // open
            // 
            this.open.Location = new System.Drawing.Point(9, 179);
            this.open.Name = "open";
            this.open.Size = new System.Drawing.Size(151, 23);
            this.open.TabIndex = 11;
            this.open.Text = "open";
            this.open.UseVisualStyleBackColor = true;
            this.open.Click += new System.EventHandler(this.open_Click);
            // 
            // send
            // 
            this.send.Location = new System.Drawing.Point(324, 293);
            this.send.Name = "send";
            this.send.Size = new System.Drawing.Size(151, 39);
            this.send.TabIndex = 12;
            this.send.Text = "send";
            this.send.UseVisualStyleBackColor = true;
            this.send.Click += new System.EventHandler(this.send_Click);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(324, 239);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(151, 39);
            this.clear.TabIndex = 13;
            this.clear.Text = "clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // port
            // 
            this.port.Location = new System.Drawing.Point(73, 20);
            this.port.Name = "port";
            this.port.Size = new System.Drawing.Size(87, 21);
            this.port.TabIndex = 12;
            this.port.Text = "COM";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 344);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.send);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Serial-<Rice DIY> Wechat：wueroo1314";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox receive_box;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox send_box;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox port;
        private System.Windows.Forms.Button open;
        private System.Windows.Forms.Button scan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox parity;
        private System.Windows.Forms.ComboBox stop_bit;
        private System.Windows.Forms.ComboBox data_bit;
        private System.Windows.Forms.ComboBox baud;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button send;
        private System.Windows.Forms.Button clear;
    }
}

