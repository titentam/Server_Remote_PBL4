namespace Server
{
    partial class FormServer
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
            Sunny.UI.UISmoothLabel uiSmoothLabel1;
            this.uiPanel1 = new Sunny.UI.UIPanel();
            this.btnStop = new Sunny.UI.UISymbolButton();
            this.btnListen = new Sunny.UI.UISymbolButton();
            this.btnResetPass = new Sunny.UI.UISymbolButton();
            this.uiSymbolLabel3 = new Sunny.UI.UISymbolLabel();
            this.uiSymbolLabel2 = new Sunny.UI.UISymbolLabel();
            this.uiSymbolLabel1 = new Sunny.UI.UISymbolLabel();
            this.txtPassword = new Sunny.UI.UITextBox();
            this.uiTextBox1 = new Sunny.UI.UITextBox();
            this.txtIP = new Sunny.UI.UIIPTextBox();
            this.txtaLog = new Sunny.UI.UIRichTextBox();
            this.uiSymbolLabel4 = new Sunny.UI.UISymbolLabel();
            this.uiPanel2 = new Sunny.UI.UIPanel();
            this.btnChat = new Sunny.UI.UISymbolButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.swVoice = new Sunny.UI.UISwitch();
            this.swSpeaker = new Sunny.UI.UISwitch();
            uiSmoothLabel1 = new Sunny.UI.UISmoothLabel();
            this.uiPanel1.SuspendLayout();
            this.uiPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // uiSmoothLabel1
            // 
            uiSmoothLabel1.Font = new System.Drawing.Font("Snap ITC", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            uiSmoothLabel1.ForeColor = System.Drawing.Color.DarkGray;
            uiSmoothLabel1.Location = new System.Drawing.Point(173, 18);
            uiSmoothLabel1.Name = "uiSmoothLabel1";
            uiSmoothLabel1.RectColor = System.Drawing.Color.Black;
            uiSmoothLabel1.Size = new System.Drawing.Size(401, 75);
            uiSmoothLabel1.Style = Sunny.UI.UIStyle.Custom;
            uiSmoothLabel1.TabIndex = 11;
            uiSmoothLabel1.Text = "BK Server";
            uiSmoothLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPanel1
            // 
            this.uiPanel1.BackColor = System.Drawing.SystemColors.Control;
            this.uiPanel1.Controls.Add(this.btnStop);
            this.uiPanel1.Controls.Add(this.btnListen);
            this.uiPanel1.Controls.Add(this.btnResetPass);
            this.uiPanel1.Controls.Add(this.uiSymbolLabel3);
            this.uiPanel1.Controls.Add(this.uiSymbolLabel2);
            this.uiPanel1.Controls.Add(this.uiSymbolLabel1);
            this.uiPanel1.Controls.Add(this.txtPassword);
            this.uiPanel1.Controls.Add(this.uiTextBox1);
            this.uiPanel1.Controls.Add(this.txtIP);
            this.uiPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiPanel1.Location = new System.Drawing.Point(37, 117);
            this.uiPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uiPanel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel1.Name = "uiPanel1";
            this.uiPanel1.Size = new System.Drawing.Size(266, 366);
            this.uiPanel1.TabIndex = 0;
            this.uiPanel1.Text = null;
            this.uiPanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnStop
            // 
            this.btnStop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnStop.Location = new System.Drawing.Point(137, 301);
            this.btnStop.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(117, 35);
            this.btnStop.Symbol = 262093;
            this.btnStop.TabIndex = 7;
            this.btnStop.Text = "Stop";
            this.btnStop.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnListen
            // 
            this.btnListen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnListen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnListen.Location = new System.Drawing.Point(14, 301);
            this.btnListen.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnListen.Name = "btnListen";
            this.btnListen.Size = new System.Drawing.Size(117, 35);
            this.btnListen.Symbol = 557379;
            this.btnListen.TabIndex = 6;
            this.btnListen.Text = "Listen";
            this.btnListen.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnListen.Click += new System.EventHandler(this.btnListen_Click);
            // 
            // btnResetPass
            // 
            this.btnResetPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnResetPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnResetPass.Location = new System.Drawing.Point(172, 254);
            this.btnResetPass.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnResetPass.Name = "btnResetPass";
            this.btnResetPass.Size = new System.Drawing.Size(83, 29);
            this.btnResetPass.Symbol = 61473;
            this.btnResetPass.TabIndex = 5;
            this.btnResetPass.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            // 
            // uiSymbolLabel3
            // 
            this.uiSymbolLabel3.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.uiSymbolLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiSymbolLabel3.Location = new System.Drawing.Point(14, 220);
            this.uiSymbolLabel3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel3.Name = "uiSymbolLabel3";
            this.uiSymbolLabel3.Size = new System.Drawing.Size(129, 26);
            this.uiSymbolLabel3.Symbol = 561506;
            this.uiSymbolLabel3.TabIndex = 4;
            this.uiSymbolLabel3.Text = "Password";
            // 
            // uiSymbolLabel2
            // 
            this.uiSymbolLabel2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.uiSymbolLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiSymbolLabel2.Location = new System.Drawing.Point(3, 118);
            this.uiSymbolLabel2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel2.Name = "uiSymbolLabel2";
            this.uiSymbolLabel2.Size = new System.Drawing.Size(88, 26);
            this.uiSymbolLabel2.Symbol = 557791;
            this.uiSymbolLabel2.TabIndex = 1;
            this.uiSymbolLabel2.Text = "Port";
            // 
            // uiSymbolLabel1
            // 
            this.uiSymbolLabel1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.uiSymbolLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiSymbolLabel1.Location = new System.Drawing.Point(14, 23);
            this.uiSymbolLabel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel1.Name = "uiSymbolLabel1";
            this.uiSymbolLabel1.Size = new System.Drawing.Size(55, 26);
            this.uiSymbolLabel1.Symbol = 357699;
            this.uiSymbolLabel1.TabIndex = 1;
            this.uiSymbolLabel1.Text = "IP";
            // 
            // txtPassword
            // 
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.DoubleValue = 1234D;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtPassword.IntValue = 1234;
            this.txtPassword.Location = new System.Drawing.Point(14, 254);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPassword.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Padding = new System.Windows.Forms.Padding(5);
            this.txtPassword.ShowText = false;
            this.txtPassword.Size = new System.Drawing.Size(158, 29);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.Text = "1234";
            this.txtPassword.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtPassword.Watermark = "";
            // 
            // uiTextBox1
            // 
            this.uiTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uiTextBox1.DoubleValue = 5910D;
            this.uiTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiTextBox1.IntValue = 5910;
            this.uiTextBox1.Location = new System.Drawing.Point(14, 152);
            this.uiTextBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTextBox1.MinimumSize = new System.Drawing.Size(1, 16);
            this.uiTextBox1.Name = "uiTextBox1";
            this.uiTextBox1.Padding = new System.Windows.Forms.Padding(5);
            this.uiTextBox1.ShowText = false;
            this.uiTextBox1.Size = new System.Drawing.Size(241, 29);
            this.uiTextBox1.TabIndex = 1;
            this.uiTextBox1.Text = "5910";
            this.uiTextBox1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiTextBox1.Watermark = "";
            // 
            // txtIP
            // 
            this.txtIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtIP.Location = new System.Drawing.Point(14, 57);
            this.txtIP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtIP.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtIP.Name = "txtIP";
            this.txtIP.Padding = new System.Windows.Forms.Padding(1);
            this.txtIP.ShowText = false;
            this.txtIP.Size = new System.Drawing.Size(241, 29);
            this.txtIP.TabIndex = 0;
            this.txtIP.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtaLog
            // 
            this.txtaLog.FillColor = System.Drawing.Color.White;
            this.txtaLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtaLog.Location = new System.Drawing.Point(16, 57);
            this.txtaLog.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtaLog.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtaLog.Name = "txtaLog";
            this.txtaLog.Padding = new System.Windows.Forms.Padding(2);
            this.txtaLog.ReadOnly = true;
            this.txtaLog.ShowText = false;
            this.txtaLog.Size = new System.Drawing.Size(269, 279);
            this.txtaLog.TabIndex = 6;
            this.txtaLog.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiSymbolLabel4
            // 
            this.uiSymbolLabel4.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.uiSymbolLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiSymbolLabel4.Location = new System.Drawing.Point(3, 23);
            this.uiSymbolLabel4.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel4.Name = "uiSymbolLabel4";
            this.uiSymbolLabel4.Size = new System.Drawing.Size(75, 26);
            this.uiSymbolLabel4.Symbol = 61686;
            this.uiSymbolLabel4.TabIndex = 8;
            this.uiSymbolLabel4.Text = "Log";
            // 
            // uiPanel2
            // 
            this.uiPanel2.Controls.Add(this.uiSymbolLabel4);
            this.uiPanel2.Controls.Add(this.txtaLog);
            this.uiPanel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiPanel2.Location = new System.Drawing.Point(325, 117);
            this.uiPanel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uiPanel2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel2.Name = "uiPanel2";
            this.uiPanel2.Size = new System.Drawing.Size(306, 366);
            this.uiPanel2.TabIndex = 9;
            this.uiPanel2.Text = "uiPanel2";
            this.uiPanel2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnChat
            // 
            this.btnChat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnChat.Location = new System.Drawing.Point(540, 493);
            this.btnChat.Margin = new System.Windows.Forms.Padding(2);
            this.btnChat.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnChat.Name = "btnChat";
            this.btnChat.Size = new System.Drawing.Size(91, 41);
            this.btnChat.Symbol = 119;
            this.btnChat.SymbolSize = 35;
            this.btnChat.TabIndex = 9;
            this.btnChat.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnChat.Click += new System.EventHandler(this.btnChat_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Server.Properties.Resources.logo2;
            this.pictureBox1.Location = new System.Drawing.Point(15, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(113, 109);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // swVoice
            // 
            this.swVoice.ActiveText = "Mic";
            this.swVoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.swVoice.InActiveText = "Mic";
            this.swVoice.Location = new System.Drawing.Point(37, 505);
            this.swVoice.MinimumSize = new System.Drawing.Size(1, 1);
            this.swVoice.Name = "swVoice";
            this.swVoice.Size = new System.Drawing.Size(75, 29);
            this.swVoice.TabIndex = 12;
            this.swVoice.Text = "Bat";
            this.swVoice.ValueChanged += new Sunny.UI.UISwitch.OnValueChanged(this.swVoice_ValueChanged);
            // 
            // swSpeaker
            // 
            this.swSpeaker.ActiveText = "Speaker";
            this.swSpeaker.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.swSpeaker.InActiveText = "Speaker";
            this.swSpeaker.Location = new System.Drawing.Point(134, 505);
            this.swSpeaker.MinimumSize = new System.Drawing.Size(1, 1);
            this.swSpeaker.Name = "swSpeaker";
            this.swSpeaker.Size = new System.Drawing.Size(75, 29);
            this.swSpeaker.TabIndex = 13;
            this.swSpeaker.Text = "Bat";
            this.swSpeaker.ValueChanged += new Sunny.UI.UISwitch.OnValueChanged(this.swSpeaker_ValueChanged);
            // 
            // FormServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(677, 559);
            this.Controls.Add(this.swSpeaker);
            this.Controls.Add(this.swVoice);
            this.Controls.Add(uiSmoothLabel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnChat);
            this.Controls.Add(this.uiPanel2);
            this.Controls.Add(this.uiPanel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormServer";
            this.Text = "Form1";
            this.uiPanel1.ResumeLayout(false);
            this.uiPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIPanel uiPanel1;
        private Sunny.UI.UIIPTextBox txtIP;
        private Sunny.UI.UISymbolLabel uiSymbolLabel1;
        private Sunny.UI.UITextBox txtPassword;
        private Sunny.UI.UITextBox uiTextBox1;
        private Sunny.UI.UISymbolLabel uiSymbolLabel2;
        private Sunny.UI.UISymbolLabel uiSymbolLabel3;
        private Sunny.UI.UISymbolButton btnResetPass;
        private Sunny.UI.UIRichTextBox txtaLog;
        private Sunny.UI.UISymbolButton btnStop;
        private Sunny.UI.UISymbolButton btnListen;
        private Sunny.UI.UISymbolLabel uiSymbolLabel4;
        private Sunny.UI.UIPanel uiPanel2;
        private Sunny.UI.UISymbolButton btnChat;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Sunny.UI.UISwitch swVoice;
        private Sunny.UI.UISwitch swSpeaker;
    }
}

