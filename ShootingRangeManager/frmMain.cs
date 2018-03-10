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
            btnAddShooter.BackColor = Classes.LayoutSetting.BtnBackground;
            btnAddShooter.ForeColor = Classes.LayoutSetting.BtnForeground;
            btnAddShooter.Font = Classes.LayoutSetting.BtnFont;
            ssVersion.Text = $"Wersja aplikacji: {Application.ProductVersion}";
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

        private void btnAddShooter_Click(object sender, EventArgs e)
        {
            try
            {
                C();
            }
            catch (Exception ex)
            {
                string message = "";
                Classes.ErrorHandler a = new Classes.ErrorHandler(ex, out message);
                MessageBox.Show(message + "Wciśnięcie przycisku Dodaj", "Błąd przycisku Dodaj");

            }
        }

        private void A()
        {
            try
            {
                throw new Exception();
            }
            catch (Exception ex)
            {
                throw new Exception("Pierwszy",ex);
            
            }
        }

        private void B()
        {
            try
            {
                A();
            }
            catch (Exception ex)
            {
                throw new Exception("Drugi", ex);

            }
        }

        private void C()
        {
            try
            {
                B();
            }
            catch (Exception ex)
            {
                throw new Exception("Trzeci", ex);

            }
        }
    }
}
