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

namespace ShootingRangeManager
{
    public partial class frmScan : Form
    {
        #region Constructor

        public frmScan()
        {
            InitializeComponent();
        }
        #endregion


        #region Events

        /// <summary>
        /// Załadowanie formatki
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmScan_Load(object sender, EventArgs e)
        {
            //Focusuję textbox na otwarciu formy
            this.ActiveControl = txtInput;
        }

        /// <summary>
        /// Obsługa zamknięcia formatki
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
        

        /// <summary>
        /// Złapanie momentu do sprawdzenia kodu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtInput_TextChanged(object sender, EventArgs e)
        {
            if (txtInput.Text.Length >= 6)
            {
                var a = Manager.ShootersList.Where(w => w.CardNumber == Convert.ToInt32(txtInput.Text)).FirstOrDefault();
                if (a==null)
                {
                    MessageBox.Show("Użytkownik nie istnieje");
                    txtInput.Text = "";
                }
                else
                {
                    DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
        }

        #endregion



        

        
    }
}
