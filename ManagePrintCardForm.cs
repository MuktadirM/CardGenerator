using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CardGenerator
{
    public partial class ManagePrintCardForm : Form
    {
        private Form activeForm = null;
        public ManagePrintCardForm()
        {
            InitializeComponent();
        }

        private void PrintIdCard_btn_Click(object sender, EventArgs e)
        {
            openChildForm(new PrintCard());
        }

        private void RePrintIdCard_btn_Click(object sender, EventArgs e)
        {
            openChildForm(new RePrintCard());
        }


        private void openChildForm(Form childForm)
        {
            if (activeForm != null) activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            PrintIdCardBody_panel.Controls.Add(childForm);
            PrintIdCardBody_panel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void ManagePrintCardForm_Load(object sender, EventArgs e)
        {
            openChildForm(new PrintCard());
        }
    }
}
