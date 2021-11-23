
namespace Client
{
    partial class TcpClient
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
            this.button1 = new System.Windows.Forms.Button();
            this.butDrop = new System.Windows.Forms.Button();
            this.boxString = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(105, 77);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 41);
            this.button1.TabIndex = 1;
            this.button1.Text = "Add string";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // butDrop
            // 
            this.butDrop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butDrop.Location = new System.Drawing.Point(105, 171);
            this.butDrop.Name = "butDrop";
            this.butDrop.Size = new System.Drawing.Size(100, 41);
            this.butDrop.TabIndex = 2;
            this.butDrop.Text = "Drop file";
            this.butDrop.UseVisualStyleBackColor = true;
            this.butDrop.Click += new System.EventHandler(this.butDrop_Click);
            // 
            // boxString
            // 
            this.boxString.Location = new System.Drawing.Point(12, 12);
            this.boxString.Multiline = true;
            this.boxString.Name = "boxString";
            this.boxString.Size = new System.Drawing.Size(272, 59);
            this.boxString.TabIndex = 3;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox1.ForeColor = System.Drawing.Color.Red;
            this.checkBox1.Location = new System.Drawing.Point(82, 143);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(138, 22);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "I want to drop file";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // TcpClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 224);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.boxString);
            this.Controls.Add(this.butDrop);
            this.Controls.Add(this.button1);
            this.Name = "TcpClient";
            this.Text = "TcpClient";
            this.Load += new System.EventHandler(this.TcpClient_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button butDrop;
        private System.Windows.Forms.TextBox boxString;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}