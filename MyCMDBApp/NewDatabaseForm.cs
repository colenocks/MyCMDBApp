using System;
using CMEntities;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;
using CMBLL;
using System.Xml;

namespace MyCMDBApp
{
    public partial class NewDatabaseForm : Form
    {
        private string _userFolder;
        private string _userName;

        public List<Contact> List_All_Contacts = new List<Contact>();

        public NewDatabaseForm(){}

        public NewDatabaseForm(string name, string folder)
        {
            InitializeComponent();
            _userName = name;
            _userFolder = folder;
        }

        private void Btn_Create_Click(object sender, EventArgs e)
        {
            string userDatabasesFolder = Path.Combine(_userFolder, $"{_userName}_Databases");
            //create the Directory, if it doesn't exist
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
                    _Handler.CreateDatabaseXml(databaseObj);

                    //back up one directory, get database storage file.
                    //instead of going into the file to retrieve
                    string userDatabaseXmlFile = Path.Combine(_userFolder, _userName+".xml");
                    //instantiate user constructor A
                    User userObj = new User(databaseName, Rtb_Database_Directory.Text);
                    //Add database details to the user xml file
                    _Handler.AddToUserDatabaseXml(userObj, userDatabaseXmlFile);

                    ///clear the contact list
                    List_All_Contacts.Clear();
                    
                }
                else
                {
                    MessageBox.Show("File Name exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
            
        }

        private void Btn_Create_Alert_Click(object sender, EventArgs e)
        {
            //Create instance of Alert Form
            NewAlertForm newAlert = new NewAlertForm();
            newAlert.ShowDialog();
            //... coming soon- Prajwal

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
        }

        private void Btn_View_Contacts_Click(object sender, EventArgs e)
        {
            //Display a message box, total number of contacts added
            MessageBox.Show($"{List_All_Contacts.Count} Contact(s) have been added Succesfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.None);

            //Disabled by default, enabled after one contact is added
            //pass in the contact list, database name and path as parameter
            ContactsViewForm viewContact = new ContactsViewForm(Rtb_Database_Directory.Text, Txt_Database_Name.Text);
            viewContact.Tag = this;
            viewContact.ShowDialog(this);
        }

        private void Btn_Finish_Click(object sender, EventArgs e)
        {
            //clear contacts list
            List_All_Contacts.Clear();
            Btn_New_Database.Enabled = true;

            Btn_Add.Enabled = false;
            Btn_View_Contacts.Enabled = false;
            Btn_Finish.Enabled = false;
        }

        private void Btn_Home_Click(object sender, EventArgs e)
        {
            var startupForm = (StartupForm)Tag;
            startupForm.Show();
            Close();
        }

        private void Btn_New_Database_Click(object sender, EventArgs e)
        {
            ////pass the list on to startUpForm
            //StartupForm startupForm = new StartupForm();
            ////call the method and pass in the list
            //startupForm.RetrieveDatabase(List_All_Databases);

            ////clear list
            //List_All_Contacts.Clear();

            //Disable group box controls
            GrBox_Contact_Form.Enabled = false;
            Btn_View_Contacts.Enabled = true;
            MessageBox.Show("Press the home key to return!");

            Txt_Database_Name.Enabled = true;
            Txt_Database_Name.Focus();
            Btn_Create.Enabled = true;
        }
        
        //FIELDS VALIDATION
        //Name
        //private bool Txt_Name_Validated()
        //{
            //bool valid = true;

            //if (string.IsNullOrEmpty(Txt_Name.Text))
            //{
            //    valid = false;
            //}
            
            //return valid;
        //}

        private void Txt_Name_Validating(object sender, CancelEventArgs e)
        {
            //if (!Txt_Name_Validated())
            //{
            //    errorProvider.SetError(Txt_Name, $"You must Enter a Name");
            //    e.Cancel = true;
            //}
            //else
            //{
            //    errorProvider.SetError(Txt_Name, "");
            //}
        }

        //Email

        //Phone

    }
}