
namespace Client
{
    partial class ChatUDP
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.boxIP = new System.Windows.Forms.TextBox();
            this.boxPort = new System.Windows.Forms.TextBox();
            this.boxName = new System.Windows.Forms.TextBox();
            this.butConnect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.boxMessage = new System.Windows.Forms.TextBox();
            this.boxDialog = new System.Windows.Forms.TextBox();
            this.butSend = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tcpClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // boxIP
            // 
            this.boxIP.Location = new System.Drawing.Point(13, 45);
            this.boxIP.Name = "boxIP";
            this.boxIP.Size = new System.Drawing.Size(134, 20);
            this.boxIP.TabIndex = 0;
            // 
            // boxPort
            // 
            this.boxPort.Location = new System.Drawing.Point(172, 45);
            this.boxPort.Name = "boxPort";
            this.boxPort.Size = new System.Drawing.Size(67, 20);
            this.boxPort.TabIndex = 1;
            // 
            // boxName
            // 
            this.boxName.Location = new System.Drawing.Point(260, 45);
            this.boxName.Name = "boxName";
            this.boxName.Size = new System.Drawing.Size(100, 20);
            this.boxName.TabIndex = 2;
            // 
            // butConnect
            // 
            this.butConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butConnect.Location = new System.Drawing.Point(386, 36);
            this.butConnect.Name = "butConnect";
            this.butConnect.Size = new System.Drawing.Size(75, 29);
            this.butConnect.TabIndex = 3;
            this.butConnect.Text = "Connect";
            this.butConnect.UseVisualStyleBackColor = true;
            this.butConnect.Click += new System.EventHandler(this.butConnect_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(76, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "IP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(185, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Port";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(152, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = ":";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(287, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Name";
            // 
            // boxMessage
            // 
            this.boxMessage.Location = new System.Drawing.Point(13, 371);
            this.boxMessage.Multiline = true;
            this.boxMessage.Name = "boxMessage";
            this.boxMessage.Size = new System.Drawing.Size(371, 47);
            this.boxMessage.TabIndex = 9;
            // 
            // boxDialog
            // 
            this.boxDialog.Location = new System.Drawing.Point(12, 81);
            this.boxDialog.Multiline = true;
            this.boxDialog.Name = "boxDialog";
            this.boxDialog.Size = new System.Drawing.Size(449, 284);
            this.boxDialog.TabIndex = 10;
            // 
            // butSend
            // 
            this.butSend.Location = new System.Drawing.Point(392, 371);
            this.butSend.Name = "butSend";
            this.butSend.Size = new System.Drawing.Size(69, 47);
            this.butSend.TabIndex = 11;
            this.butSend.Text = "Отправить";
            this.butSend.UseVisualStyleBackColor = true;
            this.butSend.Click += new System.EventHandler(this.butSend_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tcpClientToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(479, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tcpClientToolStripMenuItem
            // 
            this.tcpClientToolStripMenuItem.Name = "tcpClientToolStripMenuItem";
            this.tcpClientToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.tcpClientToolStripMenuItem.Text = "Tcp client";
            this.tcpClientToolStripMenuItem.Click += new System.EventHandler(this.tcpClientToolStripMenuItem_Click);
            // 
            // ChatUDP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 452);
            this.Controls.Add(this.butSend);
            this.Controls.Add(this.boxDialog);
            this.Controls.Add(this.boxMessage);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.butConnect);
            this.Controls.Add(this.boxName);
            this.Controls.Add(this.boxPort);
            this.Controls.Add(this.boxIP);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ChatUDP";
            this.Text = "ChatUDP";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ChatUDP_FormClosing);
            this.Load += new System.EventHandler(this.ChatUDP_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox boxIP;
        private System.Windows.Forms.TextBox boxPort;
        private System.Windows.Forms.TextBox boxName;
        private System.Windows.Forms.Button butConnect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox boxMessage;
        private System.Windows.Forms.TextBox boxDialog;
        private System.Windows.Forms.Button butSend;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tcpClientToolStripMenuItem;
    }
}

