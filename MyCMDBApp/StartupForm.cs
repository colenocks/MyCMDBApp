using CMBLL;
using CMEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace MyCMDBApp
{
    public partial class StartupForm : Form
    {
        //Session Properties
        public string UserFolderPath { get; private set; }
        public string UserFilePath { get; private set; }
        public string Username { get; private set; }
        
        public StartupForm(string username, string path, string folder)
        {
            InitializeComponent();
            UserFolderPath = folder;
            UserFilePath = path;
            Username = username;
            Top_Label.Text = $"Welcome {Username}";
        }

        public StartupForm()
        {
            
        }

        //public void RetrieveDatabase(List<string> Retrieved_Database_List)
        //{
        //    DatabaseList = Retrieved_Database_List;
        //}

        private void StartupForm_Load(object sender, EventArgs e)
        {
            MessageBox.Show(Username);
        }

        private void Btn_Create_Database_Click(object sender, EventArgs e)
        {
            //Create an instance of the new database form
            NewDatabaseForm newDatabaseForm = new NewDatabaseForm(Username, UserFolderPath);
            newDatabaseForm.Show();
            //close current form
            Hide();
        }

        private void Btn_Open_Database_Click(object sender, EventArgs e)
        {
            //  ManageDatabase form
            //*   in openDatatabase form
            //*   populate gridview with paths of all databases in user
            DB_Handler _Handler = new DB_Handler();
                 if(_Handler.List_All_Databases == null || _Handler.List_All_Databases.Count == 0)
                 {
                     MessageBox.Show("No Database has been created");
                 }
                 else
                 {
                     MessageBox.Show($"{_Handler.List_All_Databases.Count} database(s) found");
                //open ManageDatabase form to select database
                    ManageDatabasesForm databaseForm = new ManageDatabasesForm(UserFilePath);
                databaseForm.Show();
                Hide();
            }
              
        }

        private void Btn_SignOut_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"See You Later, {Username}");
            SignInForm signInForm = new SignInForm();
            signInForm.Show();
            Close();
        }

        private void Btn_Manage_Alerts_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Alerts Coming Soon");
        }


        //public void NameCommand()
        //{
        //    string command = "name:coleman";
        //    int Len = command.Length; //12 
        //    int colonIndex = command.IndexOf(":"); // = 4
        //    int afterColon = colonIndex + 1; // = 5
        //    string Key1 = command.Substring(0, colonIndex);
        //    MessageBox.Show($"{Key1}");
        //    string key1_Value = command.Substring(afterColon, Len - afterColon);
        //    MessageBox.Show($"{key1_Value}");
        //}
    }
}
