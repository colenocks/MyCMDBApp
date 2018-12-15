using CMBLL;
using CMEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCMDBApp
{
    public partial class NewContactForm : Form
    {
        private string Db_Name;
        private string Db_Path;
        private string _userName;
        private string _userFolderPath;

        //Validation instance
        DB_Validator _Validator = new DB_Validator();

        public NewContactForm() { }

        public NewContactForm(string dbname, string dbpath, string username, string userpath)
        {
            InitializeComponent();
            Db_Name = dbname;
            Db_Path = dbpath;
            _userName = username;
            _userFolderPath = userpath;
        }

        private void Btn_Add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Txt_Name.Text))
            {
                MessageBox.Show("Fill the required fields");
            }
            else
            {
                //call contact constructor to add the appropriate text boxes
                Contact contactObj = new Contact(Db_Name, Txt_Name.Text, Txt_Email.Text, Txt_Mobile.Text, Txt_Alt_Mobile.Text, Txt_Address.Text, Txt_Notes.Text, Db_Path);

                //open up the xml for writing
                DB_Handler _Handler = new DB_Handler();
                _Handler.AddContact(contactObj);

                //Clear after adding
                foreach (Control ctrl in GrBox_Contact_Form.Controls)
                {
                    if (ctrl is TextBox)
                    {
                        ctrl.Text = "";
                    }
                }
                
                MessageBox.Show($"Contact successfully added to {Db_Name.ToUpper()} Database");
            }
        }

        private void Btn_Add_Event_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Txt_Name.Text))
            {//Get the username and userfolder of co
                //Create instance of Alert Form
                NewAlertForm newAlert = new NewAlertForm(Txt_Name.Text, _userName, _userFolderPath)
                {
                    Tag = this
                };
                newAlert.Show(this);
            }
            else { MessageBox.Show("set name for alert"); }
        }
        
        private void Btn_Back_Click(object sender, EventArgs e)
        {
            var manageDatabaseForm = (ManageDatabasesForm)Tag; //use the tag property of the previous to hold it's state.
            manageDatabaseForm.Show();
                Close();
        }

        /***************************************************************
                *  FIELDS VALIDATION  *
        **************************************************************/
        private void Txt_Name_TextChanged(object sender, EventArgs e)
        {
            if (_Validator.ValidateName(Txt_Name.Text)) //if validation succeeds
            {
                
                errorProvider.SetError(Txt_Name, "");
                errorProvider.Clear();
            }
            else
            {
                errorProvider.SetError(Txt_Name, $"You must Enter Text Only");
                return;
            }
        }

        private void Txt_Email_TextChanged(object sender, EventArgs e)
        {
            if (_Validator.ValidateEmailAddress(Txt_Email.Text))
            {
                errorProvider.SetError(Txt_Email, "");
            }
            else
            {
                errorProvider.SetError(Txt_Email, "Please provide a valid email address");
                return;
            }
        }

        private void Txt_Mobile_TextChanged(object sender, EventArgs e)
        {
            if (_Validator.ValidatePhoneNumber(Txt_Mobile.Text))
            {
                errorProvider.SetError(Txt_Mobile, "");
            }
            else
            {
                errorProvider.SetError(Txt_Mobile, "Contact Number Format xxx-10 Digit Number");
                return;
            }
        }

        private void Txt_Alt_Mobile_TextChanged(object sender, EventArgs e)
        {
            if (!_Validator.ValidatePhoneNumber(Txt_Alt_Mobile.Text))
            {
                errorProvider.SetError(Txt_Alt_Mobile, "");
            }
            else
            {
                errorProvider.SetError(Txt_Alt_Mobile, "Contact Number Format xxx-10 Digit Number");
                return;
            }
        }
    }
}