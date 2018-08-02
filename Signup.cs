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

        public Signup()
        {
            InitializeComponent();
        }

        private void SignupBtn_Click(object sender, EventArgs e)
        {
            try
            {
                UserAccount newUser = new UserAccount(UserBox.Text, PasswordBox.Text);
            }
            catch { Exception ex = new Exception(); MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }

        }
    }
}
