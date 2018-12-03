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
    public partial class ManageDatabasesForm : Form
    {
        public ManageDatabasesForm()
        {   
            InitializeComponent();
            
            ComboBox_Databases.DataSource = AllDatabases;
        }

        public List<Database> AllDatabases { get; private set; } = new List<Database>();

        public void LoadToList()
        {
            SignInForm homeForm = new SignInForm();
            string userPath = homeForm.CurrentUserFilePath;
            string username = Path.GetFileNameWithoutExtension(userPath);

            //Load the users xml file and retrieve all database paths
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load(Path.GetFullPath(userPath));
            Database databaseObj = null;
            string databaseName, databasePath;
            foreach (XmlNode node in xmlDocument.SelectNodes($"{username}/Files"))
            {
                databaseName = node.SelectSingleNode("database_name").InnerText;
                databasePath = node.SelectSingleNode("database_path").InnerText;
                databaseObj = new Database(databaseName, databasePath);
                AllDatabases.Add(databaseObj);
            }
            xmlDocument.Save(Path.GetFullPath(userPath));
        }

        private void Btn_Search_Click(object sender, EventArgs e)
        {

            string command = Rtb_Search.Text.Trim(); //As so- "Key:Value" = command
            if (command.Contains(":") || command.Contains("$") || command.Contains("+") || command.Contains("-"))
            {
                int searchContentLength = command.Length; //get the length
                int colonIndex = command.IndexOf(":"); // Key ":" Value
                int afterColon = colonIndex + 1; // move cursor to next character. key: "V"alue
                string Key = command.Substring(0, colonIndex); //"key" : Value
                
                //Load lists
                LoadToList();
                int numberOfDatabases = AllDatabases.Count;
                XmlDocument xmlDocument = new XmlDocument();
                if (numberOfDatabases > 0) // if List is not empty
                {
                    int dbListIndex; //represents each string "Dbase File Path" in list
                    string[] NodesArray = new string[] { "name", "email", "mobile", "alternative", "address", "information" }; //an array of contact elements
                    string key_Value;
                    foreach (string keyString in NodesArray)
                    {
                        if (keyString == Key)
                        {
                            key_Value = command.Substring(afterColon, searchContentLength - afterColon); // key: "value"
                            for (dbListIndex = 0; dbListIndex < numberOfDatabases; dbListIndex++)
                            {
                                xmlDocument.Load(AllDatabases[dbListIndex].Database_File_Path); //load all user's databases
                                foreach (XmlNode node in xmlDocument.SelectNodes($"{AllDatabases[dbListIndex].Database_Name}/contact"))
                                {
                                    if (node.SelectSingleNode(keyString).InnerText == key_Value)
                                    {
                                        MessageBox.Show("Found You!");
                                    }

                                }
                                xmlDocument.Save(AllDatabases[dbListIndex].Database_File_Path);
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Invalid Command Language");
                Rtb_Search.Text = "";
                Rtb_Search.Focus();
            }
        }

        private void ComboBox_Databases_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Load all user
            LoadToList();
            
            //for (int i = 0; i<AllDatabases.Count; i++)
            //{

            //}
        }
    }
}
