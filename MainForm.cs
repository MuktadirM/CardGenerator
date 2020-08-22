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
    public partial class MainForm : Form
    {
        private Form activeForm = null;
        public bool ClosedByXButtonOrAltF4 { get; private set; }
        private const int SC_CLOSE = 0xF060;
        private const int WM_SYSCOMMAND = 0x0112;

        public MainForm()
        {
            InitializeComponent();
        }
            
        private void TestButton_Click(object sender, EventArgs e)
        {
            
        }


        private void ExitApp_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormHome_FormClosing(object sender, FormClosingEventArgs e)
        {
            //In case windows is trying to shut down, don't hold the process up
            if (e.CloseReason == CloseReason.WindowsShutDown) return;

            if (this.DialogResult == DialogResult.Cancel)
            {
                // Assume that X has been clicked and act accordingly.
                // Confirm user wants to close
                switch (MessageBox.Show(this, "Are you sure?", "Do you still want ... ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    //Stay on this form
                    case DialogResult.No:
                        e.Cancel = true;
                        break;
                    default:
                        break;
                }
            }

        }

    
        protected override void WndProc(ref Message msg)
        {
            if (msg.Msg == WM_SYSCOMMAND && msg.WParam.ToInt32() == SC_CLOSE)
                ClosedByXButtonOrAltF4 = true;
            base.WndProc(ref msg);
        }
        protected override void OnShown(EventArgs e)
        {
            ClosedByXButtonOrAltF4 = false;
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (ClosedByXButtonOrAltF4)
                MessageBox.Show("Exiting App");
            else
                MessageBox.Show("Closed by calling Close()");
        }


        private void FormHome_Load(object sender, EventArgs e)
        {
           
        }



        private void Home_btn_Click(object sender, EventArgs e)
        {
            openChildForm(new HomeForm());
        }

        private void Generate_btn_Click(object sender, EventArgs e)
        {
            openChildForm(new GenerateForm());
        }

        private void PrintCard_btn_Click(object sender, EventArgs e)
        {
            openChildForm(new ManagePrintCardForm());
        }

        private void ManageUser_btn_Click(object sender, EventArgs e)
        {
            openChildForm(new ManageUserForm());
        }

        private void ManageStorage_btn_Click(object sender, EventArgs e)
        {
            openChildForm(new ManageStorageForm());
        }

        private void Settings_btn_Click(object sender, EventArgs e)
        {
            openChildForm(new SettingsForm());
        }


        private void openChildForm(Form childForm)
        {
            if (activeForm != null) activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }


    }
}
