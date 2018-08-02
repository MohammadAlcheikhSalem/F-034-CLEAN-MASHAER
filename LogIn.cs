using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GarbageDetector
{
    public partial class LogIn : Form
    {
        private GarbageDetectorEntities dbx = new GarbageDetectorEntities();
        private User logUser;
        private bool CloseFactor = false;


        public LogIn()
        {
            InitializeComponent();
        }

        private void SignUpLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Signup sign = new Signup();
            sign.Show();
            GlobalVariables.RunPage = this;
            GlobalVariables.RunPage.Hide();

        }

        private void SigninBtn_Click(object sender, EventArgs e)
        {
            try
            {
                logUser = dbx.Users.Where(us1 => us1.Name == UserBox.Text).FirstOrDefault<User>();
                if (logUser == null) { MessageBox.Show("Invalid User name!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                else if (logUser.Password != PassBox.Text) MessageBox.Show("Invalid Password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    if (RUserChk.Checked) Properties.Settings.Default.UserName = UserBox.Text;
                    if (RPassChk.Checked) Properties.Settings.Default.Password = PassBox.Text;
                    GlobalVariables.RunUser = logUser;
                    new ManualMonitor().Show();
                    GlobalVariables.RunPage = this;
                    GlobalVariables.RunPage.Hide();
                }
            }
            catch { Exception ex = new Exception(); MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (e.CloseReason == CloseReason.WindowsShutDown) return;
            if (CloseFactor == true) return;
            // Confirm user wants to close
            switch (MessageBox.Show(this, "Are you sure you want to close?", "Closing", MessageBoxButtons.YesNo))
            {
                case DialogResult.No:
                    e.Cancel = true;
                    break;
                default:
                    this.Dispose();
                    this.Close();
                    break;
            }
        }

    }
}
