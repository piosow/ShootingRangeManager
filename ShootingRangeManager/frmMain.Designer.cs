namespace ShootingRangeManager
{
    partial class frmMain
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
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.lblUserName = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnEnterClient = new System.Windows.Forms.Button();
            this.btnLeaveClient = new System.Windows.Forms.Button();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblUserName});
            this.statusStrip.Location = new System.Drawing.Point(0, 433);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(530, 22);
            this.statusStrip.TabIndex = 1;
            this.statusStrip.Text = "statusStrip1";
            // 
            // menuStrip
            // 
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(530, 24);
            this.menuStrip.TabIndex = 2;
            this.menuStrip.Text = "menuStrip1";
            // 
            // lblUserName
            // 
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(71, 17);
            this.lblUserName.Text = "Użytkownik:";
            // 
            // btnEnterClient
            // 
            this.btnEnterClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnEnterClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnEnterClient.Location = new System.Drawing.Point(12, 319);
            this.btnEnterClient.Name = "btnEnterClient";
            this.btnEnterClient.Size = new System.Drawing.Size(200, 100);
            this.btnEnterClient.TabIndex = 4;
            this.btnEnterClient.Text = "Wejście na strzelnicę";
            this.btnEnterClient.UseVisualStyleBackColor = false;
            // 
            // btnLeaveClient
            // 
            this.btnLeaveClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnLeaveClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnLeaveClient.Location = new System.Drawing.Point(318, 319);
            this.btnLeaveClient.Name = "btnLeaveClient";
            this.btnLeaveClient.Size = new System.Drawing.Size(200, 100);
            this.btnLeaveClient.TabIndex = 5;
            this.btnLeaveClient.Text = "Wyjście ze strzelnicy";
            this.btnLeaveClient.UseVisualStyleBackColor = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 455);
            this.Controls.Add(this.btnLeaveClient);
            this.Controls.Add(this.btnEnterClient);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel lblUserName;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.Button btnEnterClient;
        private System.Windows.Forms.Button btnLeaveClient;
    }
}