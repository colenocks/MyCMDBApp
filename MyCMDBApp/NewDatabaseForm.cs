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
        //private string InitialPath { get; set; }
        public List<Contact> List_All_Contacts = new List<Contact>();

        public string RetrievedUserPath { get; set; }

        public NewDatabaseForm()
        {
            InitializeComponent();
            //get path from currentUserPath session Property
            SignInForm signInForm = new SignInForm();
            RetrievedUserPath = signInForm.CurrentUserPath;
        }

        private void NewDatabaseForm_Load(object sender, EventArgs e)
        {
            ////Set initial directory
            //InitialPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            //if (!Directory.Exists(InitialPath += "\\testCMDB"))
            //{
            //    Directory.CreateDirectory(InitialPath += "\\testCMDB");
            //}
        }

        private void Btn_Create_Click(object sender, EventArgs e)
        {
            
            //move back one directory, create new folder, and save file
            string parentDir = Path.GetDirectoryName(RetrievedUserPath);

            string userPath = Path.Combine(parentDir, "My Databases");
            //trim name for white spaces
            string databaseName = Txt_Database_Name.Text.Trim().ToLower();

            SaveFileDialog savefile = new SaveFileDialog
            {
                Filter = "XML File|.xml",
                FileName = databaseName,
                Title = "Save Database File",
                InitialDirectory = userPath
            };

            if (savefile.ShowDialog() == DialogResult.OK)
            {
                //check if the file exists
                if (!File.Exists(savefile.FileName))
                {
                    MessageBox.Show("Database file created succesfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.None);
                    //display directory
                    Rtb_Database_Directory.Text = savefile.FileName;
                    Txt_Database_Name.Enabled = false;
                    Btn_Create.Enabled = false;
                    //Enable the add Contacts and Create Alert Button
                    Btn_Add_Contacts.Enabled = true;
                    Btn_Create_Alert.Enabled = true;

                    //instantiate database constructor
                    Database databaseObj = new Database(databaseName, Rtb_Database_Directory.Text);

                    DB_Handler _Handler = new DB_Handler();
                    _Handler.CreateDatabase(databaseObj);

                    //instantiate user constructor A
                    User userObj = new User(databaseName, Rtb_Database_Directory.Text);
                    //Add database details to the user xml file
                    _Handler.AddUserFiles(userObj);
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
            GrBox_Contact_Form.Enabled = true;
            
            Btn_Add_Contacts.Enabled = false;
            
        }

        private void Btn_Create_Alert_Click(object sender, EventArgs e)
        {
            //Create instance of Alert Form
            NewAlertForm newAlert = new NewAlertForm();
            newAlert.ShowDialog();
            //... coming soon

        }

        private void Btn_Add_Click(object sender, EventArgs e)
        {
            //clear list contact
            List_All_Contacts.Clear();

           foreach(Control txtControls in GrBox_Contact_Form.Controls)
            {
                if((txtControls is TextBox) && (string.IsNullOrEmpty(txtControls.Text)))
                {
                    MessageBox.Show("Fill in the required contact fields");
                    Txt_Name.Focus();
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
        }

        private void Btn_View_Contacts_Click(object sender, EventArgs e)
        {
            //Display a message box, total number of contacts added
            MessageBox.Show($"{List_All_Contacts.Count} Contact(s) have been added Succesfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.None);

            //Disabled by default, enabled after one contact is added
            //pass in the contact list, database name and path as parameter
            ContactsViewForm viewContact = new ContactsViewForm(Rtb_Database_Directory.Text, Txt_Database_Name.Text);
            viewContact.ShowDialog();
        }

        private void Btn_Finish_Click(object sender, EventArgs e)
        {
            //loops through the list and adds the contact details to the user file xml
            //if all contact list is not empty
            if(List_All_Contacts.Count != 0)
            {
                for(int i = 0; i < List_All_Contacts.Count; i++)
                {
                    DB_Handler _Handler = new DB_Handler();
                    User userObj = new User(List_All_Contacts[i].Contact_Database, List_All_Contacts[i].Full_Path);
                    _Handler.AddUserFiles(userObj);
                }
                //clear contacts list
                List_All_Contacts.Clear();

                Btn_New_Database.Enabled = true;
            }
        }

        private void Btn_Home_Click(object sender, EventArgs e)
        {
            StartupForm parentForm = new StartupForm();
            parentForm.Show();
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
        private bool Txt_Name_Validated()
        {
            bool valid = true;

            if (string.IsNullOrEmpty(Txt_Name.Text))
            {
                valid = false;
            }
            
            return valid;
        }

        private void Txt_Name_Validating(object sender, CancelEventArgs e)
        {
            if (!Txt_Name_Validated())
            {
                errorProvider.SetError(Txt_Name, $"You must Enter a Name");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(Txt_Name, "");
            }
        }

        //Email

        //Phone

    }
}

/*
        //add to List to keep count
        List_All_Contacts.Add(contactObj);

        //Display a message box, contact added
        MessageBox.Show($"{List_All_Contacts.Count} Contact(s) have been added Succesfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.None);

 foreach (Control c in GrBox_Contact_Form.Controls)
            {
                if (c is TextBox)
                {
                    TextBox textBox = c as TextBox;
                    if (textBox.Text == string.Empty)
                    {
                        MessageBox.Show($"{List_All_Contacts.Count} Contact(s) have been added Succesfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.None);
                    }
                    else
                    {
                        //add to List to keep count
                        List_All_Contacts.Add(contactObj);

                        //Display a message box, contact added
                        MessageBox.Show($"{List_All_Contacts.Count} Contact(s) have been added Succesfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.None);
                    }
                }
            }

            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.InitialDirectory = InitialPath;
            saveFile.Filter = "XML File | *.xml";
            saveFile.Title = "Create Empty Xml File";
            saveFile.FileName = Txt_Database_Name.Text; //automatically adds the name to the dialog
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                //displays the 
                Rtb_Show_Location.Text = saveFile.FileName;
                Txt_Database_Name.Text = Path.GetFileNameWithoutExtension(saveFile.FileName);
               
            }
            else
            {
            //clear fields
                Txt_Database_Name.Clear();
                Rtb_Show_Location.Clear();
            }
     */
//DB_Handler _Handler = new DB_Handler();

////convert name to lower case, use as xml root element
//string convertedDbName = Txt_Database_Name.Text.ToLower();

////Use the SaveFileDialog component's OpenFile method to save the file. This method gives me a Stream object (getStream) I can write to.
//FileStream getStream = (FileStream)saveFile.OpenFile();

////Set _handler properties
//_Handler.Database_Stream = getStream; //opened stream
//                _Handler.Database_FullPath = saveFile.FileName; //full path

//                //pass in name and path for use in BLL class
//                Databases databaseObj = new Databases(convertedDbName, _Handler.Database_FullPath);


////flag the indicator
//IsEmptyFileSaved = true;

