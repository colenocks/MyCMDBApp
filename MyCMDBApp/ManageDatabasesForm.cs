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
    public partial class ManageDatabasesForm : Form
    {
        public ManageDatabasesForm()
        {
            InitializeComponent();
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
                DB_Handler _Handler = new DB_Handler();

                int numberOfDatabase = _Handler.List_All_Databases.Count;
                XmlDocument xmlDocument = new XmlDocument();
                if (numberOfDatabase > 0) // if List is not empty
                {
                    int dbListIndex; //represents each string "Dbase directory" in list
                    string[] NodesArray = new string[] { "name", "email", "mobile", "alternative", "address", "information" }; //an array of contact elements
                    string key_Value;
                    foreach (string keyString in NodesArray)
                    {
                        if (keyString == Key)
                        {
                            key_Value = command.Substring(afterColon, searchContentLength - afterColon); // key: "value"
                            for (dbListIndex = 0; dbListIndex < numberOfDatabase; dbListIndex++)
                            {
                                xmlDocument.Load(_Handler.List_All_Databases[dbListIndex].Database_File_Path); //load all user's databases
                                foreach (XmlNode node in xmlDocument.SelectNodes($"{Path.GetFileNameWithoutExtension(_Handler.List_All_Databases[dbListIndex].Database_File_Path)}/contact"))
                                {
                                    if (node.SelectSingleNode(keyString).InnerText == key_Value)
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
            else
            {
                MessageBox.Show("Invalid Command Language");
                Rtb_Search.Text = "";
                Rtb_Search.Focus();
            }
        }
    }
}
