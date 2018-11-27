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
            newDatabaseForm.ShowDialog();
            
            //close current form
            this.Close();
        }

        private void Btn_Search_Click(object sender, EventArgs e)
        {   
            string command = Rtb_Search.Text.Trim(); //As so- "Key:Value" = command
            if (!(command.Contains(":")) || (command.Contains("$")) || (command.Contains("+")) || (command.Contains("-")))
            {
                MessageBox.Show("Invalid Command Language");
                Rtb_Search.Text = "";
                Rtb_Search.Focus();
            }
            else
            { 
                int searchContentLength = command.Length; //get the length
                int colonIndex = command.IndexOf(":"); // Key ":" Value
                int afterColon = colonIndex + 1; // move cursor to next character. key: "V"alue
                string Key = command.Substring(0, colonIndex); //"key" : Value
                DB_Handler _Handler = new DB_Handler();
  
                int numberOfDatabase = _Handler.List_All_Databases.Count;
                XmlDocument xmlDocument = new XmlDocument();
                if(numberOfDatabase > 0) // if List is not empty
                {
                    int dbListIndex; //represents each string "Dbase directory" in list
                    string[] NodesArray = new string []{ "name", "email", "mobile", "alternative", "address", "information" }; //an array of contact elements
                    string key_Value;
                    foreach (string keyString in NodesArray)
                    {
                        if(keyString == Key)
                        {
                           key_Value = command.Substring(afterColon, searchContentLength - afterColon); // key: "value"
                            for (dbListIndex = 0; dbListIndex < numberOfDatabase; dbListIndex++)
                            {
                                xmlDocument.Load(_Handler.List_All_Databases[dbListIndex].Database_File_Path); //load all databases in the system
                                foreach (XmlNode node in xmlDocument.SelectNodes($"{Path.GetFileNameWithoutExtension(_Handler.List_All_Databases[dbListIndex].Database_File_Path)}/contact"))
                                {
                                    if(node.SelectSingleNode(keyString).InnerText == key_Value)
                                    {
                                        MessageBox.Show("Found You!");
                                    }
                                    
                                }
                                xmlDocument.Load(_Handler.List_All_Databases[dbListIndex].Database_File_Path);
                            }
                        }
                    }
                }
                
            }
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
