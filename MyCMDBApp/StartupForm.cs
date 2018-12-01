using CMBLL;
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
        private string Username { get; set; }
        public StartupForm()
        {
            InitializeComponent();
        }
        //public void RetrieveDatabase(List<string> Retrieved_Database_List)
        //{
        //    DatabaseList = Retrieved_Database_List;
        //}

        private void Btn_Create_Database_Click(object sender, EventArgs e)
        {
            //Create an instance of the new database form
            NewDatabaseForm newDatabaseForm = new NewDatabaseForm();
            //open the form
            newDatabaseForm.Show();
            
            //close current form
            Hide();
        }

        private void Btn_Search_Click(object sender, EventArgs e)
        {   

        }

        private void Btn_Open_Database_Click(object sender, EventArgs e)
        {
           /*   //  openDatabase form
            *   in openDatatabase form
            *   populate gridview with paths of all databases in user
                if(_Handler.List_All_Databases.Count <= 0)
                {
                    MessageBox.Show("No Database has been created");
                }
                else
                {
                    MessageBox.Show($"{_Handler.List_All_Databases.Count} database(s) found");
                    //open Open_Database form to select database
                    //coming soon...
                 }
             */
        }

        private void Btn_SignOut_Click(object sender, EventArgs e)
        {
            SignInForm homeForm = new SignInForm();
            homeForm.Show();
            Hide();
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
