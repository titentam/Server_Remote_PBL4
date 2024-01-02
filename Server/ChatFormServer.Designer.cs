namespace Server
{
    partial class ChatFormServer
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
            this.chatTxt = new Sunny.UI.UITextBox();
            this.uiSymbolButton1 = new Sunny.UI.UISymbolButton();
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
            this.chatArea.Size = new System.Drawing.Size(375, 313);
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
            this.uiPanel1.Controls.Add(this.chatTxt);
            this.uiPanel1.Controls.Add(this.uiSymbolButton1);
            this.uiPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.uiPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiPanel1.Location = new System.Drawing.Point(0, 315);
            this.uiPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uiPanel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel1.Name = "uiPanel1";
            this.uiPanel1.Size = new System.Drawing.Size(375, 53);
            this.uiPanel1.TabIndex = 2;
            this.uiPanel1.Text = "uiPanel1";
            this.uiPanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chatTxt
            // 
            this.chatTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.chatTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.chatTxt.Location = new System.Drawing.Point(4, 4);
            this.chatTxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chatTxt.MinimumSize = new System.Drawing.Size(1, 16);
            this.chatTxt.Name = "chatTxt";
            this.chatTxt.Padding = new System.Windows.Forms.Padding(5);
            this.chatTxt.ShowText = false;
            this.chatTxt.Size = new System.Drawing.Size(305, 46);
            this.chatTxt.TabIndex = 0;
            this.chatTxt.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.chatTxt.Watermark = "";
            // 
            // uiSymbolButton1
            // 
            this.uiSymbolButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiSymbolButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiSymbolButton1.Location = new System.Drawing.Point(312, 5);
            this.uiSymbolButton1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolButton1.Name = "uiSymbolButton1";
            this.uiSymbolButton1.Size = new System.Drawing.Size(60, 45);
            this.uiSymbolButton1.Symbol = 557699;
            this.uiSymbolButton1.SymbolSize = 35;
            this.uiSymbolButton1.TabIndex = 1;
            this.uiSymbolButton1.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.uiSymbolButton1.Click += new System.EventHandler(this.uiSymbolButton1_Click);
            // 
            // ChatFormServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 368);
            this.Controls.Add(this.uiPanel1);
            this.Controls.Add(this.uiRichTextBox2);
            this.Controls.Add(this.chatArea);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ChatFormServer";
            this.Text = "ChatFormServer";

            this.uiPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIRichTextBox chatArea;
        private Sunny.UI.UIRichTextBox uiRichTextBox2;
        private Sunny.UI.UIPanel uiPanel1;
        private Sunny.UI.UISymbolButton uiSymbolButton1;
        private Sunny.UI.UITextBox chatTxt;
    }
}