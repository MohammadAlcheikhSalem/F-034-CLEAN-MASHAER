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

    public partial class Signup : Form
    {
        private UserAccount newUser;
        private bool CloseFactor = false;
        public Signup()
        {
            InitializeComponent();
        }

        private void SignupBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (PasswordBox.Text == RepasswordBox.Text)
                    newUser = new UserAccount(UserBox.Text, PasswordBox.Text);
                else MessageBox.Show("Password confirm not matched!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                GlobalVariables.RunPage.Show();
                CloseFactor = true;
                Close();
            }
            catch { Exception ex = new Exception(); MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }

        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            CloseFactor = true;
            Close();
            GlobalVariables.RunPage.Show();
            
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
                case DialogResult.Yes:
                    GlobalVariables.RunPage.Dispose();
                    GlobalVariables.RunPage.Close();
                    break;
            }
        }
    }
}
