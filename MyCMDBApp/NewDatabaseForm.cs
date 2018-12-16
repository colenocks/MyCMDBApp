using System;
using CMEntities;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;
using CMBLL;
using System.Xml;
using System.Text.RegularExpressions;

namespace MyCMDBApp
{
    public partial class NewDatabaseForm : Form
    {
        private string _userParentDirectory;
        private string _userFilePath;
        private string _userName;
        private List<Contact> List_All_Contacts = new List<Contact>();

        //validator instance
        DB_Validator _Validator = new DB_Validator();

        public NewDatabaseForm() { }

        public NewDatabaseForm(string name, string path, string folder)
        {
            InitializeComponent();
            _userName = name;
            _userFilePath = path;
            _userParentDirectory = folder;
        }

        private void Btn_Create_Click(object sender, EventArgs e)
        {
            //create two level directory, if it doesn't exist
            string userDatabasesFolder = Path.Combine(_userParentDirectory, $"{_userName}_Databases");
            if (!Directory.Exists(userDatabasesFolder))
            {
                Directory.CreateDirectory(userDatabasesFolder);
            }
            //trim name for white spaces
            string databaseName = Txt_Database_Name.Text.Trim().ToLower();

            SaveFileDialog savefile = new SaveFileDialog
            {
                Title = "Save Database File",
                Filter = "XML File|.xml",
                FileName = databaseName,
                InitialDirectory = userDatabasesFolder
            };
            if (savefile.ShowDialog() == DialogResult.OK)
            {
                //check if the file exists
                if (!File.Exists(savefile.FileName))
                {
                    MessageBox.Show("Database file created succesfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.None);
                    //display directory
                    Rtb_Database_Directory.Text = savefile.FileName;
                    //if database name text field is empty
                    Txt_Database_Name.Text = Path.GetFileNameWithoutExtension(savefile.FileName);

                    //disable controls
                    Txt_Database_Name.Enabled = false;
                    Btn_Create.Enabled = false;
                    //Enable the add Contacts and Create Alert Button
                    Btn_Add_Contacts.Enabled = true;
                    Btn_Create_Alert.Enabled = true;

                    //instantiate database constructor
                    Database databaseObj = new Database(Txt_Database_Name.Text, Rtb_Database_Directory.Text);

                    DB_Handler _Handler = new DB_Handler();
                    _Handler.CreateDatabase(databaseObj);
                    
                    //instantiate user constructor A
                    User userObj = new User(Txt_Database_Name.Text, Rtb_Database_Directory.Text, _userFilePath);

                    //Add database details to the user xml file
                    _Handler.SaveUserDatabaseInfo(userObj);

                    ///clear the contact list
                    List_All_Contacts.Clear();

                }
                else
                {
                    MessageBox.Show("File Name Duplication", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Txt_Database_Name.Clear();
                    Txt_Database_Name.Focus();
                }

            }
        }

        private void Btn_Add_Contacts_Click(object sender, EventArgs e)
        {
            //Enables the contact Form Group box
            //Btn_Add_Contacts.Enabled = false;
            GrBox_Contact_Form.Enabled = true;
            Btn_Add.Enabled = true;
            Btn_Add_Event.Enabled = true;

        }

        private void Btn_Create_Alert_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Txt_Database_Name.Text))
            {
                //Create instance of Alert Form
                NewAlertForm newAlert = new NewAlertForm(Txt_Database_Name.Text, _userName, _userParentDirectory);
                {
                    Tag = this;
                }
                newAlert.Show(this);
            }
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
                Contact contactObj = new Contact(Txt_Database_Name.Text, Txt_Name.Text, Txt_Email.Text, Txt_Mobile.Text, Txt_Alt_Mobile.Text, Txt_Address.Text, Txt_Notes.Text, Rtb_Database_Directory.Text);

                //open up the xml for writing
                DB_Handler _Handler = new DB_Handler();
                _Handler.AddContact(contactObj);

                //add contact object to list
                List_All_Contacts.Add(contactObj);

                //Clear after adding
                foreach (Control ctrl in GrBox_Contact_Form.Controls)
                {
                    if (ctrl is TextBox)
                    {
                        ctrl.Text = "";
                    }
                }

                if (List_All_Contacts.Count > 0)
                {
                    //Enable buttons after adding 1 or more contacts
                    Btn_Finish.Enabled = true;
                    Btn_View_Contacts.Enabled = true;
                }
            }
            GrBox_Contact_Form.Enabled = true;
        }

        private void Btn_Add_Event_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Txt_Name.Text))
            {
                //Create instance of Alert Form
                NewAlertForm newAlert = new NewAlertForm(Txt_Name.Text, _userName, _userParentDirectory);
                newAlert.ShowDialog();
            }
            else { MessageBox.Show("set name for alert"); }
            
        }

        private void Btn_View_Contacts_Click(object sender, EventArgs e)
        {
            //Display a message box, total number of contacts added
            MessageBox.Show($"{List_All_Contacts.Count} Contact(s) have been added Succesfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.None);

            //Disabled by default, enabled after one contact is added
            //pass in the contact list, database name and path as parameter
            ContactsViewForm viewContact = new ContactsViewForm(Rtb_Database_Directory.Text, Txt_Database_Name.Text)
            {
                Tag = this
            };
            viewContact.Show(this);
        }

        private void Btn_Finish_Click(object sender, EventArgs e)
        {
            //clear contacts list
            List_All_Contacts.Clear();

            //Disable contact form controls
            GrBox_Contact_Form.Enabled = false;
            Btn_New_Database.Enabled = true;

            Btn_Add.Enabled = false;
            Btn_View_Contacts.Enabled = false;
            Btn_Finish.Enabled = false;
        }

        private void Btn_Home_Click(object sender, EventArgs e)
        {
            var startupForm = (StartupForm)Tag; //use the tag property of the previous to hold it's state.
            startupForm.Show();
            Close();
        }

        private void Btn_New_Database_Click(object sender, EventArgs e)
        {
            Txt_Database_Name.Enabled = true;
            Txt_Database_Name.Focus();
            Btn_Create.Enabled = true;
        }

        /***************************************************************
         *  FIELDS VALIDATION
         **************************************************************/
        private void Txt_Database_Name_Validating(object sender, CancelEventArgs e)
        {
            if (_Validator.ValidateName(Txt_Database_Name.Text)) //if validation succeeds
            {

                errorProvider.SetError(Txt_Database_Name, "");
            }
            else
            {
                errorProvider.SetError(Txt_Database_Name, $"You must Enter Text Only");
                e.Cancel = true;
            }
        }

        private void Txt_Name_Validating(object sender, CancelEventArgs e)
        {
            if (_Validator.ValidateName(Txt_Name.Text)) //if validation succeeds
            {

                errorProvider.SetError(Txt_Name, "");
                errorProvider.Clear();
            }
            else
            {
                errorProvider.SetError(Txt_Name, $"You must Enter Text Only");
                e.Cancel = true;
            }
        }

        private void Txt_Email_Validating(object sender, CancelEventArgs e)
        {
            if (_Validator.ValidateEmailAddress(Txt_Email.Text))
            {
                errorProvider.SetError(Txt_Email, "");
            }
            else
            {
                errorProvider.SetError(Txt_Email, "Please provide a valid email address");
                e.Cancel = true;
            }
        }

        private void Txt_Mobile_Validating(object sender, CancelEventArgs e)
        {
            if (_Validator.ValidatePhoneNumber(Txt_Mobile.Text))
            {
                errorProvider.SetError(Txt_Mobile, "");
            }
            else
            {
                errorProvider.SetError(Txt_Mobile, "Contact Number Format xxx-10 Digit Number");
                e.Cancel = true;
            }
        }

        private void Txt_Alt_Mobile_Validating(object sender, CancelEventArgs e)
        {
            if (_Validator.ValidatePhoneNumber(Txt_Alt_Mobile.Text))
            {
                errorProvider.SetError(Txt_Alt_Mobile, "");
            }
            else
            {
                errorProvider.SetError(Txt_Alt_Mobile, "Contact Number Format xxx-10 Digit Number");
                e.Cancel = true;
            }
        }
    }
}