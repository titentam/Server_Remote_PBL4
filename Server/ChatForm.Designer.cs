namespace Server
{
    partial class ChatForm
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
            this.chatArea = new Sunny.UI.UIRichTextBox();
            this.uiRichTextBox2 = new Sunny.UI.UIRichTextBox();
            this.uiPanel1 = new Sunny.UI.UIPanel();
            this.btnSend = new Sunny.UI.UISymbolButton();
            this.chatTxt = new Sunny.UI.UITextBox();
            this.uiPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chatArea
            // 
            this.chatArea.Dock = System.Windows.Forms.DockStyle.Top;
            this.chatArea.FillColor = System.Drawing.Color.White;
            this.chatArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.chatArea.Location = new System.Drawing.Point(0, 0);
            this.chatArea.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chatArea.MinimumSize = new System.Drawing.Size(1, 1);
            this.chatArea.Name = "chatArea";
            this.chatArea.Padding = new System.Windows.Forms.Padding(2);
            this.chatArea.ShowText = false;
            this.chatArea.Size = new System.Drawing.Size(416, 324);
            this.chatArea.Style = Sunny.UI.UIStyle.Custom;
            this.chatArea.TabIndex = 0;
            this.chatArea.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiRichTextBox2
            // 
            this.uiRichTextBox2.FillColor = System.Drawing.Color.White;
            this.uiRichTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiRichTextBox2.Location = new System.Drawing.Point(128, 4);
            this.uiRichTextBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uiRichTextBox2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiRichTextBox2.Name = "uiRichTextBox2";
            this.uiRichTextBox2.Padding = new System.Windows.Forms.Padding(2);
            this.uiRichTextBox2.ShowText = false;
            this.uiRichTextBox2.Size = new System.Drawing.Size(6, 6);
            this.uiRichTextBox2.Style = Sunny.UI.UIStyle.Custom;
            this.uiRichTextBox2.TabIndex = 1;
            this.uiRichTextBox2.Text = "uiRichTextBox2";
            this.uiRichTextBox2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPanel1
            // 
            this.uiPanel1.Controls.Add(this.btnSend);
            this.uiPanel1.Controls.Add(this.chatTxt);
            this.uiPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.uiPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiPanel1.Location = new System.Drawing.Point(0, 323);
            this.uiPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uiPanel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel1.Name = "uiPanel1";
            this.uiPanel1.Size = new System.Drawing.Size(416, 42);
            this.uiPanel1.TabIndex = 2;
            this.uiPanel1.Text = "uiPanel1";
            this.uiPanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSend
            // 
            this.btnSend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnSend.Location = new System.Drawing.Point(356, 1);
            this.btnSend.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(60, 41);
            this.btnSend.Symbol = 557699;
            this.btnSend.SymbolSize = 35;
            this.btnSend.TabIndex = 1;
            this.btnSend.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnSend.Click += new System.EventHandler(this.uiSymbolButton1_Click);
            // 
            // chatTxt
            // 
            this.chatTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.chatTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.chatTxt.Location = new System.Drawing.Point(2, 3);
            this.chatTxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chatTxt.MinimumSize = new System.Drawing.Size(1, 16);
            this.chatTxt.Name = "chatTxt";
            this.chatTxt.Padding = new System.Windows.Forms.Padding(5);
            this.chatTxt.ShowText = false;
            this.chatTxt.Size = new System.Drawing.Size(347, 39);
            this.chatTxt.TabIndex = 0;
            this.chatTxt.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.chatTxt.Watermark = "";
            // 
            // ChatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 365);
            this.Controls.Add(this.uiPanel1);
            this.Controls.Add(this.uiRichTextBox2);
            this.Controls.Add(this.chatArea);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ChatForm";
            this.Text = "ChatForm";
            this.uiPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIRichTextBox chatArea;
        private Sunny.UI.UIRichTextBox uiRichTextBox2;
        private Sunny.UI.UIPanel uiPanel1;
        private Sunny.UI.UISymbolButton btnSend;
        private Sunny.UI.UITextBox chatTxt;
    }
}