using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GarbageDetector
{
    class UserAccount
    {

        private static Regex UserNameRoles = new Regex(@"^[A-Za-z][A-Za-z0-9._]{3,15}$");
        private static Regex PasswordRoles = new Regex(@"^[A-Za-z0-9._]{3,15}$");
        private GarbageDetectorEntities dbx = new GarbageDetectorEntities();
        private User newuser = new User();

        //----------Define Fileds----------------

        private int _id;
        private string _name;
        private string _password;

        //----------Define Functions-------------
        
        public UserAccount(string NM,string PAS)
        {
            try
            {
                if (!UserNameRoles.IsMatch(NM))
                {
                    MessageBox.Show("User name is short or contatins invalid characters, Please make sure to use more than 4 letters or numbers, contains at least one upper case letter!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (!PasswordRoles.IsMatch(PAS))
                {
                    MessageBox.Show("Password is short or contains invalid charecters, Please make sure to use more than 4 letters or numbers, contains at least one upper case letter!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    _name = NM;
                    _password = PAS;
                    newuser.Name = NM;
                    newuser.Password = PAS;
                    dbx.Users.Add(newuser);
                    dbx.SaveChanges();
                    MessageBox.Show("Thanks for joining us!\nYou will receive activation message within 48 hours.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch { Exception ex = new Exception(); MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        //----------Define Properties------------
        public int ID
        {
            get { return _id; }
        }
        public string NAME
        {
            set { _name = value; }
            get { return _name; }
        }
        public string PASSWORD
        {
            set { _password = value; }
            get { return _password; }
        }
    }
}
