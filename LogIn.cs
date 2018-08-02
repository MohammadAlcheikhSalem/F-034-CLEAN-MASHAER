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
        
        public LogIn()
        {
            InitializeComponent();
        }

        private void SignUpLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Signup sign = new Signup();
            this.Close();
            sign.Show();

           
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
                    new ManualMonitor().Show();
                    this.Hide();
                }
            }
            catch { Exception ex = new Exception(); MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
        private void GlobalVariables(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to close the form?", "Warning", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.No)
                e.Cancel = true;
            else this.Close();
            }
        }
}
