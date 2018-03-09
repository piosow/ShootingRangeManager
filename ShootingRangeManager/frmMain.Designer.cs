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
            this.button2 = new System.Windows.Forms.Button();
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
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(318, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 100);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(530, 455);
            this.ControlBox = false;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnCardScan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCardScan;
        private System.Windows.Forms.Button button2;
    }
}