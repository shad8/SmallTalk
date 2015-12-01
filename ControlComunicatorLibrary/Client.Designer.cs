namespace ControlComunicatorLibrary
{
    partial class Client
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
      this.components = new System.ComponentModel.Container();
      this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
      this.startButon = new System.Windows.Forms.Button();
      this.sendButton = new System.Windows.Forms.Button();
      this.listMessage = new System.Windows.Forms.ListBox();
      this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.messageTextBox = new System.Windows.Forms.TextBox();
      this.IPClient2Label = new System.Windows.Forms.Label();
      this.portClient2Label = new System.Windows.Forms.Label();
      this.portClient2TextBox = new System.Windows.Forms.TextBox();
      this.IPClient2TextBox = new System.Windows.Forms.TextBox();
      this.client2GroupBox = new System.Windows.Forms.GroupBox();
      this.portClient1Label = new System.Windows.Forms.Label();
      this.IPClient1Label = new System.Windows.Forms.Label();
      this.portClient1TextBox = new System.Windows.Forms.TextBox();
      this.IPClient1TextBox = new System.Windows.Forms.TextBox();
      this.closeButton = new System.Windows.Forms.Button();
      this.client1GroupBox = new System.Windows.Forms.GroupBox();
      ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
      this.client2GroupBox.SuspendLayout();
      this.client1GroupBox.SuspendLayout();
      this.SuspendLayout();
      // 
      // errorProvider1
      // 
      this.errorProvider1.ContainerControl = this;
      // 
      // startButon
      // 
      this.startButon.Location = new System.Drawing.Point(470, 26);
      this.startButon.Name = "startButon";
      this.startButon.Size = new System.Drawing.Size(77, 43);
      this.startButon.TabIndex = 13;
      this.startButon.Text = "Start";
      this.startButon.UseVisualStyleBackColor = true;
      // 
      // sendButton
      // 
      this.sendButton.Enabled = false;
      this.sendButton.Location = new System.Drawing.Point(472, 341);
      this.sendButton.Name = "sendButton";
      this.sendButton.Size = new System.Drawing.Size(75, 23);
      this.sendButton.TabIndex = 12;
      this.sendButton.Text = "Send";
      this.sendButton.UseVisualStyleBackColor = true;
      // 
      // listMessage
      // 
      this.listMessage.ForeColor = System.Drawing.SystemColors.HotTrack;
      this.listMessage.FormattingEnabled = true;
      this.listMessage.Location = new System.Drawing.Point(15, 139);
      this.listMessage.Name = "listMessage";
      this.listMessage.Size = new System.Drawing.Size(532, 186);
      this.listMessage.TabIndex = 11;
      // 
      // contextMenuStrip1
      // 
      this.contextMenuStrip1.Name = "contextMenuStrip1";
      this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
      // 
      // messageTextBox
      // 
      this.messageTextBox.Location = new System.Drawing.Point(15, 344);
      this.messageTextBox.Name = "messageTextBox";
      this.messageTextBox.Size = new System.Drawing.Size(449, 20);
      this.messageTextBox.TabIndex = 10;
      // 
      // IPClient2Label
      // 
      this.IPClient2Label.AutoSize = true;
      this.IPClient2Label.Location = new System.Drawing.Point(6, 36);
      this.IPClient2Label.Name = "IPClient2Label";
      this.IPClient2Label.Size = new System.Drawing.Size(17, 13);
      this.IPClient2Label.TabIndex = 4;
      this.IPClient2Label.Text = "IP";
      // 
      // portClient2Label
      // 
      this.portClient2Label.AutoSize = true;
      this.portClient2Label.Location = new System.Drawing.Point(6, 63);
      this.portClient2Label.Name = "portClient2Label";
      this.portClient2Label.Size = new System.Drawing.Size(26, 13);
      this.portClient2Label.TabIndex = 5;
      this.portClient2Label.Text = "Port";
      // 
      // portClient2TextBox
      // 
      this.portClient2TextBox.Location = new System.Drawing.Point(66, 60);
      this.portClient2TextBox.Name = "portClient2TextBox";
      this.portClient2TextBox.Size = new System.Drawing.Size(136, 20);
      this.portClient2TextBox.TabIndex = 1;
      // 
      // IPClient2TextBox
      // 
      this.IPClient2TextBox.Location = new System.Drawing.Point(66, 33);
      this.IPClient2TextBox.Name = "IPClient2TextBox";
      this.IPClient2TextBox.Size = new System.Drawing.Size(136, 20);
      this.IPClient2TextBox.TabIndex = 0;
      // 
      // client2GroupBox
      // 
      this.client2GroupBox.Controls.Add(this.IPClient2Label);
      this.client2GroupBox.Controls.Add(this.portClient2Label);
      this.client2GroupBox.Controls.Add(this.portClient2TextBox);
      this.client2GroupBox.Controls.Add(this.IPClient2TextBox);
      this.client2GroupBox.Location = new System.Drawing.Point(246, 20);
      this.client2GroupBox.Name = "client2GroupBox";
      this.client2GroupBox.Size = new System.Drawing.Size(218, 100);
      this.client2GroupBox.TabIndex = 9;
      this.client2GroupBox.TabStop = false;
      this.client2GroupBox.Text = "Client2";
      // 
      // portClient1Label
      // 
      this.portClient1Label.AutoSize = true;
      this.portClient1Label.Location = new System.Drawing.Point(7, 63);
      this.portClient1Label.Name = "portClient1Label";
      this.portClient1Label.Size = new System.Drawing.Size(26, 13);
      this.portClient1Label.TabIndex = 3;
      this.portClient1Label.Text = "Port";
      // 
      // IPClient1Label
      // 
      this.IPClient1Label.AutoSize = true;
      this.IPClient1Label.Location = new System.Drawing.Point(7, 36);
      this.IPClient1Label.Name = "IPClient1Label";
      this.IPClient1Label.Size = new System.Drawing.Size(17, 13);
      this.IPClient1Label.TabIndex = 2;
      this.IPClient1Label.Text = "IP";
      // 
      // portClient1TextBox
      // 
      this.portClient1TextBox.Location = new System.Drawing.Point(66, 60);
      this.portClient1TextBox.Name = "portClient1TextBox";
      this.portClient1TextBox.Size = new System.Drawing.Size(136, 20);
      this.portClient1TextBox.TabIndex = 1;
      // 
      // IPClient1TextBox
      // 
      this.IPClient1TextBox.Location = new System.Drawing.Point(66, 33);
      this.IPClient1TextBox.Name = "IPClient1TextBox";
      this.IPClient1TextBox.ReadOnly = true;
      this.IPClient1TextBox.Size = new System.Drawing.Size(136, 20);
      this.IPClient1TextBox.TabIndex = 0;
      // 
      // closeButton
      // 
      this.closeButton.Enabled = false;
      this.closeButton.Location = new System.Drawing.Point(470, 73);
      this.closeButton.Name = "closeButton";
      this.closeButton.Size = new System.Drawing.Size(77, 47);
      this.closeButton.TabIndex = 14;
      this.closeButton.Text = "Close";
      this.closeButton.UseVisualStyleBackColor = true;
      // 
      // client1GroupBox
      // 
      this.client1GroupBox.Controls.Add(this.portClient1Label);
      this.client1GroupBox.Controls.Add(this.IPClient1Label);
      this.client1GroupBox.Controls.Add(this.portClient1TextBox);
      this.client1GroupBox.Controls.Add(this.IPClient1TextBox);
      this.client1GroupBox.Location = new System.Drawing.Point(15, 20);
      this.client1GroupBox.Name = "client1GroupBox";
      this.client1GroupBox.Size = new System.Drawing.Size(218, 100);
      this.client1GroupBox.TabIndex = 8;
      this.client1GroupBox.TabStop = false;
      this.client1GroupBox.Text = "Client1";
      // 
      // Client
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.startButon);
      this.Controls.Add(this.sendButton);
      this.Controls.Add(this.listMessage);
      this.Controls.Add(this.messageTextBox);
      this.Controls.Add(this.client2GroupBox);
      this.Controls.Add(this.closeButton);
      this.Controls.Add(this.client1GroupBox);
      this.Name = "Client";
      this.Size = new System.Drawing.Size(563, 385);
      ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
      this.client2GroupBox.ResumeLayout(false);
      this.client2GroupBox.PerformLayout();
      this.client1GroupBox.ResumeLayout(false);
      this.client1GroupBox.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

        }

    #endregion

    private System.Windows.Forms.ErrorProvider errorProvider1;
    private System.Windows.Forms.Button startButon;
    private System.Windows.Forms.Button sendButton;
    private System.Windows.Forms.ListBox listMessage;
    private System.Windows.Forms.TextBox messageTextBox;
    private System.Windows.Forms.GroupBox client2GroupBox;
    private System.Windows.Forms.Label IPClient2Label;
    private System.Windows.Forms.Label portClient2Label;
    private System.Windows.Forms.TextBox portClient2TextBox;
    private System.Windows.Forms.TextBox IPClient2TextBox;
    private System.Windows.Forms.Button closeButton;
    private System.Windows.Forms.GroupBox client1GroupBox;
    private System.Windows.Forms.Label portClient1Label;
    private System.Windows.Forms.Label IPClient1Label;
    private System.Windows.Forms.TextBox portClient1TextBox;
    private System.Windows.Forms.TextBox IPClient1TextBox;
    private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
  }
}
