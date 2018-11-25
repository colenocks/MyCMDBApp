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
        private static int Contacts_Count;
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
        }

        private void Btn_Create_Alert_Click(object sender, EventArgs e)
        {
            //Create instance of Alert Form
            NewAlertForm newAlert = new NewAlertForm();
            newAlert.ShowDialog();
            //... coming soon

        }

        private void Btn_Finish_Click(object sender, EventArgs e)
        {
            //reset contact count
            Contacts_Count = 0;
            //Disable group box controls
            GrBox_Contact_Form.Enabled = false;
            Btn_View_Contacts.Enabled = true;
        }

        private void Btn_Add_Click(object sender, EventArgs e)
        {
            //call contact constructor to add the appropriate text boxes
            Contact contactObj = new Contact(Txt_Database_Name.Text, Txt_Name.Text, Txt_Email.Text, Txt_Mobile.Text, Txt_Alt_Mobile.Text, Txt_Address.Text, Txt_Notes.Text, Rtb_Show_Location.Text);
                
            DB_Handler _Handler = new DB_Handler();
            //opens up the xml for writing
            _Handler.SaveContact(contactObj);

            //add to List
            List_All_Contacts.Add(contactObj);

            foreach (Control ctrl in GrBox_Contact_Form.Controls)
            {
                if (ctrl is TextBox )
                {
                    //update count
                    Contacts_Count++;
                }
            }
            
            //Display a message box, contact added
            MessageBox.Show($"{Contacts_Count} Contact(s) have been added Succesfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.None);

            //Clear after adding
            foreach (Control ctrl in GrBox_Contact_Form.Controls)
            {
                
            }
            if(Contacts_Count > 0)
            {
                Btn_View_Contacts.Enabled = true;
            }
        }

        //Validation For name
        private bool Txt_First_Name_Validated()
        {
            bool valid = true;

            if (string.IsNullOrEmpty(Txt_Name.Text))
            {
                valid = false;
            }

            return valid;
        }

        private void Txt_First_Name_Validating(object sender, CancelEventArgs e)
        {
            if (!Txt_First_Name_Validated())
            {
                errorProvider.SetError(Txt_Name, $"You must Enter a Name");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(Txt_Name, "");
            }
        }

        private void Btn_View_Contacts_Click(object sender, EventArgs e)
        {
            //Disabled by default, enabled after one contact is added
            ContactsViewForm viewContact = new ContactsViewForm(List_All_Contacts);
            viewContact.ShowDialog();
        }
    }
}

/*
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

