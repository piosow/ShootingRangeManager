using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShootingRangeManager
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            button2.BackColor = Classes.LayoutSetting.BtnBackground;
        }

        private void btnCardScan_Click(object sender, EventArgs e)
        {
            frmScan scan = new frmScan();
            scan.ShowDialog();
            if (scan.DialogResult == DialogResult.OK)
            {
                MessageBox.Show("ASDASDASD");
            }
        }
    }
}
