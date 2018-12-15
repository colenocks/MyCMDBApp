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
    public partial class StartupForm : Form
    {
        //Session Properties
        public string UserParentDirectory { get; private set; }
        public string UserFilePath { get; private set; }
        public string Username { get; private set; }
        
        public StartupForm() {}
        
        public StartupForm(string username, string path, string folder)
        {
            InitializeComponent();
            UserParentDirectory = folder;
            UserFilePath = path;
            Username = username;
            Top_Label.Text = $"Welcome {Username}";
        }

        private void Btn_Create_Database_Click(object sender, EventArgs e)
        {
            //Create an instance of the new database form
            NewDatabaseForm newDatabaseForm = new NewDatabaseForm(Username, UserFilePath, UserParentDirectory)
            {
                Tag = this
            };
            newDatabaseForm.Show(this);
            Hide();
        }

        private void Btn_Open_Database_Click(object sender, EventArgs e)
        {
            ////   populate gridview with paths of all databases in user
            //DB_Handler _Handler = new DB_Handler();
            //if (_Handler.List_All_Databases == null || _Handler.List_All_Databases.Count == 0)
            //{
            //    MessageBox.Show("No Database has been created");
            //}
            //else
            //{
            //}
            //MessageBox.Show($"{_Handler.List_All_Databases.Count} database(s) found");

            //open ManageDatabase form to select database
            ManageDatabasesForm databaseForm = new ManageDatabasesForm(Username, UserFilePath, UserParentDirectory)
            {
                Tag = this //set this form as a tag property of the next form instance
            };
            databaseForm.Show(this);
            Hide();
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
            
    }
}
