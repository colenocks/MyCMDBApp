﻿using CMBLL;
using CMEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace MyCMDBApp
{
    public partial class ManageDatabasesForm : Form
    {
        private string _userPath;
        private string _userFolderPath;
        private string _userName;

        private string dbFilePath;
        private string dbFileName;
        public List<Database> AllDatabases { get; private set; } = new List<Database>();

        public ManageDatabasesForm() { }

        public ManageDatabasesForm(string username, string path, string folderPath)
        {   
            InitializeComponent();

            _userName = username;
            _userPath = path;
            _userFolderPath = folderPath;

            //fill list on load
            LoadToList();
            ComboBox_Databases.DataSource = AllDatabases;
            ComboBox_Databases.DisplayMember = "DisplayName";
        }

        //if command contains ":"
        //call colon. call dollar. call plus, call minus
        //depending on the contants of the strings call these methods on any of them or their substrings.
        //If command contains "$"- call CheckSpecialCharacter on substring before and after specialCharacter and return the
        public string ParseColon(string commandString)//if command string contains ":"
        {
            //command string is passed in
            string valueReturned = "";
            int searchContentLength = commandString.Length; //get the length
            int colonIndex = commandString.IndexOf(":"); // Key ":" Value
            int afterColon = colonIndex + 1; // move cursor to next character. key: "V"alue
            string Key = commandString.Substring(0, colonIndex); //"key" : Value

            //string value = SearchValue(key); //return value
            //command string is parsed
            //the result of the command string is returns a value
            XmlDocument xmlDocument = new XmlDocument();
            if (AllDatabases.Count > 0) // if List is not empty
            {
                int dbListIndex; //represents each string "Dbase File Path" in list
                string[] ArrayNodes = new string[] { "name", "email", "mobile", "alternative", "address", "information" }; //an array of contact elements
                string key_Value;
                foreach (string arrayNode in ArrayNodes)
                {
                    if (arrayNode == Key)
                    {
                        key_Value = commandString.Substring(afterColon, searchContentLength - afterColon); //gets the value key: "value"
                        for (dbListIndex = 0; dbListIndex < AllDatabases.Count; dbListIndex++)
                        {
                            xmlDocument.Load(AllDatabases[dbListIndex].Database_File_Path); //load all user's databases
                            foreach (XmlNode node in xmlDocument.SelectNodes($"{AllDatabases[dbListIndex].Database_Name}/contact"))
                            {
                                if (key_Value == node.SelectSingleNode(arrayNode).InnerText.ToLower() || Regex.IsMatch(node.SelectSingleNode(arrayNode).InnerText, "^"+key_Value+"(.*)"))
                                {
                                    valueReturned = key_Value;

                                    //Select the corresponding combobox index
                                    ComboBox_Databases.SelectedIndex = dbListIndex;
                                    ComboBox_Databases.Enabled = false;
                                    //disable the select button
                                    Btn_Select.Enabled = false;

                                    //Highlight contact or showDialog() on a eachContact form, and clear the search button
                                    //MessageBox.Show("Shyam's Contact Form");
                                    Rtb_Search.Clear();
                                }
                                else
                                {
                                    Rtb_Search.Clear();
                                    Rtb_Search.Focus();
                                }
                            }
                            xmlDocument.Save(AllDatabases[dbListIndex].Database_File_Path);
                        }
                    }
                }
            }
            //this value is vital to display the matched contact's database and highlight the row matched
            return valueReturned;
        }

        // Confirm that there is an ":" and a "$" in the search string, and in the correct order.

        private void Btn_Search_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            string command = Rtb_Search.Text.ToLower().Trim(); //As so -> "Key:Value" = command

            if (command.Contains(":"))
            {
                var retrievedContent = ParseColon(command);
                //Highlight the Row on display
                DisplayContacts(retrievedContent);
            }
            if (command.Contains("$"))
            {

            }
            else
            {
                MessageBox.Show("Invalid Command Language");
                Rtb_Search.Text = "";
                Rtb_Search.Focus();
            }
        }

        private void Btn_Display_Click(object sender, EventArgs e)
        {
            DisplayContacts();
            Btn_Display.Enabled = false;
        }

        private void Btn_Select_Click(object sender, EventArgs e)
        {
            ComboBox_Databases.Enabled = false;
            Btn_Display.Enabled = true;
        }

        private void Btn_Clear_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            ComboBox_Databases.Enabled = true;
            Btn_Select.Enabled = true;
            Btn_Display.Enabled = true;
        }

        private void Btn_Home_Click(object sender, EventArgs e)
        {
            var startupForm = (StartupForm)Tag;
            startupForm.Show();
            Close();
        }

        //METHODS
        //Method load databases to list
        private void LoadToList()
        {
            string username = Path.GetFileNameWithoutExtension(_userPath);

            //Load the users xml file and retrieve all database paths
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load(Path.GetFullPath(_userPath));
            Database databaseObj = null;
            string databaseName, databasePath;
            foreach (XmlNode node in xmlDocument.SelectNodes($"{username}/Files"))
            {
                databaseName = node.SelectSingleNode("database_name").InnerText;
                databasePath = node.SelectSingleNode("database_path").InnerText;
                databaseObj = new Database(databaseName, databasePath);

                AllDatabases.Add(databaseObj);
            }
            xmlDocument.Save(Path.GetFullPath(_userPath));
        }

        //Method display to gridview
        private void DisplayContacts(string value_highlightedRow = null)
        {
            //if search button was not clicked i.e if combobox selected item has not been
            for (int i = 0; i < AllDatabases.Count; i++)
            {
                if (ComboBox_Databases.SelectedIndex == i)
                {
                    dbFilePath = AllDatabases[i].Database_File_Path;
                    dbFileName = AllDatabases[i].Database_Name;
                }
            }
            //load the xml file and display on gridview
            XmlDocument xmlDocument = new XmlDocument();
            if (!File.Exists(dbFilePath))
            {
                MessageBox.Show("This file has been Deleted!");
            }
            else
            {
                xmlDocument.Load(dbFilePath);
                //load alerts too
                //xmlDocument.Load(_userFolderPath);
                int n = 0;
                foreach (XmlNode node in xmlDocument.SelectNodes($"{dbFileName}/contact"))
                {
                    n = dataGridView1.Rows.Add();//gets the number of rows already in the table
                    dataGridView1.Rows[n].Cells[0].Value = node.SelectSingleNode("name").InnerText;
                    dataGridView1.Rows[n].Cells[1].Value = node.SelectSingleNode("email").InnerText;
                    dataGridView1.Rows[n].Cells[2].Value = node.SelectSingleNode("mobile").InnerText;
                    dataGridView1.Rows[n].Cells[3].Value = node.SelectSingleNode("alternative").InnerText;
                    dataGridView1.Rows[n].Cells[4].Value = node.SelectSingleNode("address").InnerText;
                    dataGridView1.Rows[n].Cells[5].Value = node.SelectSingleNode("information").InnerText;
                    //highlight row if string matches passed in value
                    if (!string.IsNullOrEmpty(value_highlightedRow))
                    {
                        for(int i = 0; i < 6; i++) //number of columns = 6
                        {
                            if ((string)dataGridView1.Rows[n].Cells[i].Value == value_highlightedRow)
                            {
                                dataGridView1.Rows[n].DefaultCellStyle.BackColor = Color.DarkOrange;
                            }
                        }
                    }
                }
                xmlDocument.Save(dbFilePath);
            }
            
        }

        private void DataGridViewContacts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            bool checkNull = false;
            do
            {  
                if (string.IsNullOrEmpty(dataGridView1.CurrentRow.Cells[0].Value.ToString()))
                {
                    MessageBox.Show("You have selected an empty row");
                }
                else
                {
                    checkNull = true;
                }
            } while (!checkNull);
            
            string name = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            string email = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            string mobile = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            string alternative = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            string address = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            string info = dataGridView1.CurrentRow.Cells[5].Value.ToString();

            ContactDetailForm contactDetail = new ContactDetailForm(dbFileName, dbFilePath, name, email, mobile, alternative, address, info, _userName)
            {
                Tag = this //tag contact detail form to this form object
            };
            contactDetail.Show(this);
            Hide();
            
        }

        private void Btn_Add_New_Contact_Click(object sender, EventArgs e)
        {
            string dbName;
            string dbPath;
            if (!Btn_Select.Enabled || ComboBox_Databases.SelectedIndex <= 0)
            {
                int dbIndex = ComboBox_Databases.SelectedIndex;
                dbName = AllDatabases[dbIndex].Database_Name;
                dbPath = AllDatabases[dbIndex].Database_File_Path;

                NewContactForm newContactForm = new NewContactForm(dbName, dbPath, _userPath, _userFolderPath);
                newContactForm.Tag = this; //tag this form to the next form
                newContactForm.Show(this);
            }
            else
            {
                MessageBox.Show("You must selcet a database first");
            }
        }
    }
}

