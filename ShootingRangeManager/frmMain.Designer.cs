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
            this.btnCardScan = new System.Windows.Forms.Button();
            this.btnAddShooter = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ssVersion = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCardScan
            // 
            this.btnCardScan.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnCardScan.FlatAppearance.BorderSize = 0;
            this.btnCardScan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCardScan.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnCardScan.ForeColor = System.Drawing.Color.White;
            this.btnCardScan.Location = new System.Drawing.Point(12, 12);
            this.btnCardScan.Margin = new System.Windows.Forms.Padding(0);
            this.btnCardScan.Name = "btnCardScan";
            this.btnCardScan.Size = new System.Drawing.Size(200, 100);
            this.btnCardScan.TabIndex = 1;
            this.btnCardScan.Text = "SKANUJ KARTĘ";
            this.btnCardScan.UseVisualStyleBackColor = false;
            this.btnCardScan.Click += new System.EventHandler(this.btnCardScan_Click);
            // 
            // btnAddShooter
            // 
            this.btnAddShooter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddShooter.Location = new System.Drawing.Point(318, 12);
            this.btnAddShooter.Name = "btnAddShooter";
            this.btnAddShooter.Size = new System.Drawing.Size(200, 100);
            this.btnAddShooter.TabIndex = 2;
            this.btnAddShooter.Text = "button2";
            this.btnAddShooter.UseVisualStyleBackColor = true;
            this.btnAddShooter.Click += new System.EventHandler(this.btnAddShooter_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.SystemColors.Highlight;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ssVersion});
            this.statusStrip1.Location = new System.Drawing.Point(0, 433);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(530, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // ssVersion
            // 
            this.ssVersion.ForeColor = System.Drawing.Color.White;
            this.ssVersion.Name = "ssVersion";
            this.ssVersion.Size = new System.Drawing.Size(118, 17);
            this.ssVersion.Text = "toolStripStatusLabel1";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(530, 455);
            this.ControlBox = false;
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnAddShooter);
            this.Controls.Add(this.btnCardScan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCardScan;
        private System.Windows.Forms.Button btnAddShooter;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel ssVersion;
    }
}