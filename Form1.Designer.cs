namespace SendEmail
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
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textMessage = new System.Windows.Forms.TextBox();
            this.textSubject = new System.Windows.Forms.TextBox();
            this.textCC = new System.Windows.Forms.TextBox();
            this.textTo = new System.Windows.Forms.TextBox();
            this.Setting = new System.Windows.Forms.GroupBox();
            this.textUserName = new System.Windows.Forms.TextBox();
            this.textSMTP = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.textPort = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.checkSSL = new System.Windows.Forms.CheckBox();
            this.Send = new System.Windows.Forms.Button();
            this.Setting.SuspendLayout();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(23, 105);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "Message:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(23, 79);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "Subject:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(23, 53);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(24, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "CC:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(23, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "To:";
            // 
            // textMessage
            // 
            this.textMessage.Location = new System.Drawing.Point(92, 98);
            this.textMessage.Multiline = true;
            this.textMessage.Name = "textMessage";
            this.textMessage.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textMessage.Size = new System.Drawing.Size(562, 211);
            this.textMessage.TabIndex = 3;
            // 
            // textSubject
            // 
            this.textSubject.Location = new System.Drawing.Point(92, 72);
            this.textSubject.Name = "textSubject";
            this.textSubject.Size = new System.Drawing.Size(562, 20);
            this.textSubject.TabIndex = 2;
            // 
            // textCC
            // 
            this.textCC.Location = new System.Drawing.Point(92, 46);
            this.textCC.Name = "textCC";
            this.textCC.Size = new System.Drawing.Size(562, 20);
            this.textCC.TabIndex = 1;
            // 
            // textTo
            // 
            this.textTo.Location = new System.Drawing.Point(92, 20);
            this.textTo.Name = "textTo";
            this.textTo.Size = new System.Drawing.Size(562, 20);
            this.textTo.TabIndex = 0;
            // 
            // Setting
            // 
            this.Setting.Controls.Add(this.Send);
            this.Setting.Controls.Add(this.textUserName);
            this.Setting.Controls.Add(this.textSMTP);
            this.Setting.Controls.Add(this.label16);
            this.Setting.Controls.Add(this.textPort);
            this.Setting.Controls.Add(this.label15);
            this.Setting.Controls.Add(this.textPassword);
            this.Setting.Controls.Add(this.label14);
            this.Setting.Controls.Add(this.label13);
            this.Setting.Controls.Add(this.checkSSL);
            this.Setting.Location = new System.Drawing.Point(92, 315);
            this.Setting.Name = "Setting";
            this.Setting.Size = new System.Drawing.Size(562, 182);
            this.Setting.TabIndex = 3;
            this.Setting.TabStop = false;
            this.Setting.Text = "Setting";
            // 
            // textUserName
            // 
            this.textUserName.Location = new System.Drawing.Point(78, 19);
            this.textUserName.Name = "textUserName";
            this.textUserName.Size = new System.Drawing.Size(277, 20);
            this.textUserName.TabIndex = 0;
            // 
            // textSMTP
            // 
            this.textSMTP.Location = new System.Drawing.Point(199, 87);
            this.textSMTP.Name = "textSMTP";
            this.textSMTP.Size = new System.Drawing.Size(103, 20);
            this.textSMTP.TabIndex = 4;
            this.textSMTP.Text = "smtp.gmail.com";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(164, 94);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(40, 13);
            this.label16.TabIndex = 1;
            this.label16.Text = "SMTP:";
            // 
            // textPort
            // 
            this.textPort.Location = new System.Drawing.Point(44, 87);
            this.textPort.Name = "textPort";
            this.textPort.Size = new System.Drawing.Size(103, 20);
            this.textPort.TabIndex = 3;
            this.textPort.Text = "587";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(9, 94);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(29, 13);
            this.label15.TabIndex = 1;
            this.label15.Text = "Port:";
            // 
            // textPassword
            // 
            this.textPassword.Location = new System.Drawing.Point(78, 45);
            this.textPassword.Name = "textPassword";
            this.textPassword.PasswordChar = '*';
            this.textPassword.Size = new System.Drawing.Size(277, 20);
            this.textPassword.TabIndex = 2;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(9, 52);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(56, 13);
            this.label14.TabIndex = 1;
            this.label14.Text = "Password:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(9, 26);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 13);
            this.label13.TabIndex = 1;
            this.label13.Text = "UserName:";
            // 
            // checkSSL
            // 
            this.checkSSL.AutoSize = true;
            this.checkSSL.Location = new System.Drawing.Point(357, 87);
            this.checkSSL.Name = "checkSSL";
            this.checkSSL.Size = new System.Drawing.Size(46, 17);
            this.checkSSL.TabIndex = 1;
            this.checkSSL.Text = "SSL";
            this.checkSSL.UseVisualStyleBackColor = true;
            // 
            // Send
            // 
            this.Send.Location = new System.Drawing.Point(44, 144);
            this.Send.Name = "Send";
            this.Send.Size = new System.Drawing.Size(75, 23);
            this.Send.TabIndex = 5;
            this.Send.Text = "Send";
            this.Send.UseVisualStyleBackColor = true;
            this.Send.Click += new System.EventHandler(this.Send_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 532);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textMessage);
            this.Controls.Add(this.textSubject);
            this.Controls.Add(this.textCC);
            this.Controls.Add(this.textTo);
            this.Controls.Add(this.Setting);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Send Mail";
            this.Setting.ResumeLayout(false);
            this.Setting.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textMessage;
        private System.Windows.Forms.TextBox textSubject;
        private System.Windows.Forms.TextBox textCC;
        private System.Windows.Forms.TextBox textTo;
        private System.Windows.Forms.GroupBox Setting;
        private System.Windows.Forms.TextBox textUserName;
        private System.Windows.Forms.TextBox textSMTP;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textPort;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textPassword;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.CheckBox checkSSL;
        private System.Windows.Forms.Button Send;
    }
}

