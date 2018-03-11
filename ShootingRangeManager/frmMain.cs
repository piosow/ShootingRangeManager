using ShootingRangeManager.Controls;
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
            SetupControls();

        }

        private void SetupControls()
        {
            try
            {
                //Przyciski
                btnAddShooter.BackColor = Classes.LayoutSetting.BtnBackground;
                btnAddShooter.ForeColor = Classes.LayoutSetting.BtnForeground;
                btnAddShooter.Font = Classes.LayoutSetting.BtnFont;

                btnCardScan.BackColor = Classes.LayoutSetting.BtnBackground;
                btnCardScan.ForeColor = Classes.LayoutSetting.BtnForeground;
                btnCardScan.Font = Classes.LayoutSetting.BtnFont;

                //Status bar
                ssVersion.Text = $"Wersja aplikacji: {Application.ProductVersion}";
            }
            catch (Exception ex)
            {
                throw new Exception("Ustawienie kontrolek", ex);
            }
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
        
        private void a()
        {
            throw new Exception("Tralalalalalallla", ex);
        }
        
        private void b()
        {
            try
            {
                a();
            }
            catch(Exception ex)
            {
                throw new Exception("Forward błędu", ex);
            }
        }
        
        private void c()
        {
            try
            {
                b();
            }
            catch(Exception ex)
            {
                throw new Exception("Jeszcze jeden forward błędu", ex);
            }
        }

        private void btnAddShooter_Click(object sender, EventArgs e)
        {
            try
            {
                //CustomMessage customMessage = new CustomMessage();
                //customMessage.ShowDialog();
                c();

            }
            catch (Exception ex)
            {
                string message = "";
                Classes.ErrorHandler a = new Classes.ErrorHandler(ex, out message);
                CustomMessage customMessage = new CustomMessage(CustomMessage.MessageType.Exception, "Błąd przycisku Dodaj", message + "\nWciśnięcie przycisku Dodaj");
                customMessage.Dispose();
            }
        }
    }
}
