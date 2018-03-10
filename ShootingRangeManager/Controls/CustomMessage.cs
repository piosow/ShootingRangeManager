using ShootingRangeManager.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShootingRangeManager.Controls
{
    public partial class CustomMessage : Form
    {
        public CustomMessage()
        {
            InitializeComponent();
            btnOK.BackColor = LayoutSetting.BtnBackground;
            btnOK.ForeColor = LayoutSetting.BtnForeground;
            btnOK.Font = LayoutSetting.BtnFont;
            btnCancel.BackColor = LayoutSetting.BtnBackground;
            btnCancel.ForeColor = LayoutSetting.BtnForeground;
            btnCancel.Font = LayoutSetting.BtnFont;

        }

        private void CustomMessage_Paint(object sender, PaintEventArgs e)
        {
            Pen borderPen = new Pen(LayoutSetting.BtnBackground, 2F);
            e.Graphics.DrawRectangle(borderPen, e.ClipRectangle.X + 2, e.ClipRectangle.Y + 2, Width - 4, Height - 4);
            
        }

        private void CustomMessage_Load(object sender, EventArgs e)
        {
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
