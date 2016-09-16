namespace Route_Manager
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.HostIP = new System.Windows.Forms.TextBox();
            this.localip = new System.Windows.Forms.TextBox();
            this.DebugText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ComboBoxPermanent = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxCableOrWiFi = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Source IP";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(204, 71);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Run";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // HostIP
            // 
            this.HostIP.Location = new System.Drawing.Point(103, 19);
            this.HostIP.Name = "HostIP";
            this.HostIP.Size = new System.Drawing.Size(176, 20);
            this.HostIP.TabIndex = 2;
            // 
            // localip
            // 
            this.localip.Location = new System.Drawing.Point(315, 47);
            this.localip.Name = "localip";
            this.localip.Size = new System.Drawing.Size(176, 20);
            this.localip.TabIndex = 3;
            // 
            // DebugText
            // 
            this.DebugText.Location = new System.Drawing.Point(15, 160);
            this.DebugText.Multiline = true;
            this.DebugText.Name = "DebugText";
            this.DebugText.Size = new System.Drawing.Size(502, 70);
            this.DebugText.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Debug text:";
            // 
            // ComboBoxPermanent
            // 
            this.ComboBoxPermanent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxPermanent.FormattingEnabled = true;
            this.ComboBoxPermanent.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.ComboBoxPermanent.Location = new System.Drawing.Point(103, 71);
            this.ComboBoxPermanent.Name = "ComboBoxPermanent";
            this.ComboBoxPermanent.Size = new System.Drawing.Size(66, 21);
            this.ComboBoxPermanent.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Permanent route";
            // 
            // comboBoxCableOrWiFi
            // 
            this.comboBoxCableOrWiFi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCableOrWiFi.FormattingEnabled = true;
            this.comboBoxCableOrWiFi.Items.AddRange(new object[] {
            "WiFi",
            "Ethernet Cable"});
            this.comboBoxCableOrWiFi.Location = new System.Drawing.Point(103, 44);
            this.comboBoxCableOrWiFi.Name = "comboBoxCableOrWiFi";
            this.comboBoxCableOrWiFi.Size = new System.Drawing.Size(176, 21);
            this.comboBoxCableOrWiFi.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Connection";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 119);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBoxCableOrWiFi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ComboBoxPermanent);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DebugText);
            this.Controls.Add(this.localip);
            this.Controls.Add(this.HostIP);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Route Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox HostIP;
        private System.Windows.Forms.TextBox localip;
        private System.Windows.Forms.TextBox DebugText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox ComboBoxPermanent;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxCableOrWiFi;
        private System.Windows.Forms.Label label6;
    }
}

