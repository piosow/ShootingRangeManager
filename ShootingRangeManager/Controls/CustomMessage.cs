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
        public enum MessageType
        {
            Info,
            Warning,
            Exception,
            YesNo
        }

        private MessageType _type;

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

        public CustomMessage(MessageType type, string header, string body)
        {
            InitializeComponent();
            label1.Text = header;
            richTextBox1.Text = body;
            _type = type;
            SetupButtons();
            this.ShowDialog();
        }

        private void CustomMessage_Paint(object sender, PaintEventArgs e)
        {
            Pen borderPen = new Pen((_type == MessageType.Exception || _type == MessageType.Warning) ? Color.Red : LayoutSetting.BtnBackground, 2F);
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

        private void SetupButtons()
        {
            if (_type == MessageType.YesNo)
            {
                btnCancel.Visible = true;
                btnCancel.Text = "Anuluj";
                btnCancel.DialogResult = DialogResult.Cancel;

                btnOK.Visible = true;
                btnOK.Text = "Ok";
                btnOK.DialogResult = DialogResult.OK;
            }
            else
            {
                btnCancel.Visible = true;
                btnCancel.Text = "Ok";
                btnCancel.DialogResult = DialogResult.Cancel;

                btnOK.Visible = false;
            }
        }
    }
}
