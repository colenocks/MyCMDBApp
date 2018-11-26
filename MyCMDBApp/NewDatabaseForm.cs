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
        private string InitialPath { get; set; } 
        //private Stream Db_Stream { get; set; }
        List<Contact> List_All_Contacts = new List<Contact>();
        List<Databases> List_All_Databases = new List<Databases>();

        public NewDatabaseForm()
        {
            InitializeComponent();
        }

        private void NewDatabaseForm_Load(object sender, EventArgs e)
        {
            //Set initial directory
            InitialPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            if (!Directory.Exists(InitialPath += "\\testCMDB"))
            {
                Directory.CreateDirectory(InitialPath += "\\testCMDB");
            }
        }

        private void Btn_Create_Click(object sender, EventArgs e)
        {
            // Saving empty file in directory chosen already)
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.InitialDirectory = InitialPath;
            saveFile.Filter = "XML File | *.xml";
            saveFile.Title = "Create Empty Xml File";
            saveFile.FileName = Txt_Database_Name.Text; //automatically adds the name to the dialog
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                Rtb_Show_Location.Text = saveFile.FileName;
                if(Txt_Database_Name.Text == "" || Txt_Database_Name.Text != Path.GetFileNameWithoutExtension(saveFile.FileName))
                {
                    Txt_Database_Name.Text = Path.GetFileNameWithoutExtension(saveFile.FileName);
                }

                MessageBox.Show("Empty File saved succesfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.None);
                Txt_Database_Name.Enabled = false;
                Btn_Create.Enabled = false;
                //Enable the add Contacts and Create Alert Button
                Btn_Add_Contacts.Enabled = true;
                Btn_Create_Alert.Enabled = true;

                //instantiate database constructor
                Databases databaseObj = new Databases(Path.GetFileNameWithoutExtension(saveFile.FileName), Rtb_Show_Location.Text);

                DB_Handler _Handler = new DB_Handler();
                _Handler.SaveDatabase(databaseObj);
            }
            else
            {
                MessageBox.Show("File not saved", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void Btn_Add_Contacts_Click(object sender, EventArgs e)
        {
            //Enables the contact Form Group box
            GrBox_Contact_Form.Enabled = true;

            //Enable finish button after adding contacts
            Btn_Finish.Enabled = true;
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
            //call contact constructor to add the appropriate text boxes
            Contact contactObj = new Contact(Txt_Database_Name.Text, Txt_Name.Text, Txt_Email.Text, Txt_Mobile.Text, Txt_Alt_Mobile.Text, Txt_Address.Text, Txt_Notes.Text, Rtb_Show_Location.Text);
            
            //open up the xml for writing
            DB_Handler _Handler = new DB_Handler();
            _Handler.SaveContact(contactObj);

            //add to List to keep count
            List_All_Contacts.Add(contactObj);

            //Clear after adding
            foreach (Control ctrl in GrBox_Contact_Form.Controls)
            {
                if(ctrl is TextBox)
                {
                    (ctrl as TextBox).Text = "";
                    
                }
            }

            if(List_All_Contacts.Count > 0)
            {
                Btn_View_Contacts.Enabled = true;
                Btn_Finish.Enabled = true;
            }
        }

        private void Btn_View_Contacts_Click(object sender, EventArgs e)
        {
            //Display a message box, total number of contacts added
            MessageBox.Show($"{List_All_Contacts.Count} Contact(s) have been added Succesfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.None);

            //Disabled by default, enabled after one contact is added
            //pass in the contact list, database name and path as parameter
            ContactsViewForm viewContact = new ContactsViewForm(List_All_Contacts);
            viewContact.ShowDialog();
        }

        private void Btn_Finish_Click_1(object sender, EventArgs e)
        {
            //clear list
            List_All_Contacts.Clear();

            //Disable group box controls
            GrBox_Contact_Form.Enabled = false;
            Btn_View_Contacts.Enabled = true;
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

