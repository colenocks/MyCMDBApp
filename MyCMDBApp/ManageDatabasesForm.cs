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
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace MyCMDBApp
{
    public partial class ManageDatabasesForm : Form
    {
        private string _userPath;
        private string dbFilePath;
        private string dbFileName;
        public List<Database> AllDatabases { get; private set; } = new List<Database>();

        public ManageDatabasesForm() { }

        public ManageDatabasesForm(string path)
        {   
            InitializeComponent();

            _userPath = path;
            //fill list on load
            LoadToList();
            ComboBox_Databases.DataSource = AllDatabases;
            ComboBox_Databases.DisplayMember = "DisplayName";
        }

        private void Btn_Search_Click(object sender, EventArgs e)
        {
            string command = Rtb_Search.Text.ToLower().Trim(); //As so -> "Key:Value" = command
            if (command.Contains(":") || command.Contains("$") || command.Contains("+") || command.Contains("-"))
            {
                int searchContentLength = command.Length; //get the length
                int colonIndex = command.IndexOf(":"); // Key ":" Value
                int afterColon = colonIndex + 1; // move cursor to next character. key: "V"alue
                string Key = command.Substring(0, colonIndex); //"key" : Value
                
                //list has been loaded through the constructor
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
                                    if (node.SelectSingleNode(keyString).InnerText.ToLower() == key_Value)
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

        private void Btn_Display_Click(object sender, EventArgs e)
        {
            DisplayContacts();
        }
        private void Btn_Select_Click(object sender, EventArgs e)
        {
            ComboBox_Databases.Enabled = false;
        }

        private void Btn_Clear_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            ComboBox_Databases.Enabled = true;
        }

        private void Btn_Home_Click(object sender, EventArgs e)
        {
            Close();
            StartupForm startupForm = new StartupForm();
            startupForm.Show();
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
        private void DisplayContacts()
        {
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
                }
                xmlDocument.Save(dbFilePath);
            }
            
        }

    }
}
