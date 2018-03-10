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
        }

        private void CustomMessage_Paint(object sender, PaintEventArgs e)
        {
            Pen borderPen = new Pen(LayoutSetting.BtnBackground, 4F);
            e.Graphics.DrawRectangle(borderPen, e.ClipRectangle.X + 2, e.ClipRectangle.Y + 2, Width - 4, Height - 4);
            
        }

        private void CustomMessage_Load(object sender, EventArgs e)
        {
            
        }
    }
}
