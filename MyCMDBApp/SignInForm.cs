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
    public partial class SignInForm : Form
    {
        //Session Properties
        public string CurrentUserFolderPath;
        public string RetrievedUserFilePath;
        public string RetrievedUsername;

        public SignInForm()
        {
            InitializeComponent();
        }
        
        private void Btn_Sign_In_Click(object sender, EventArgs e)
        {
            //Fields have to be checked for empty
            if (string.IsNullOrEmpty(Txt_User_ID.Text) || string.IsNullOrEmpty(Txt_Access_Code.Text))
            {
                MessageBox.Show("username is empty or contains invalid characters");
                ClearFields();
            }
            else
            {
                //trim whitespaces out and convert to lowercases
                string userId = Txt_User_ID.Text.Trim().ToLower();
                //get the users list folder path from handler class
                DB_Handler _Handler = new DB_Handler();
                string AllUsersFile = Path.Combine(_Handler.UsersFolderPath, "users.xml"); 
                

                XmlDocument xmlDocument = new XmlDocument();
                //Load the users xml file and check if username and path exists
                if (!File.Exists(AllUsersFile))
                {
                   MessageBox.Show("No user have been created in this application yet");
                    ClearFields();
                }
                else
                {
                    xmlDocument.Load(Path.GetFullPath(AllUsersFile));
                
                    foreach (XmlNode node in xmlDocument.SelectNodes("allusers/user"))
                    {
                        if (node.SelectSingleNode("username").InnerText == userId)
                        {
                            //retrieve the path and username
                            RetrievedUsername = userId;
                            RetrievedUserFilePath = node.SelectSingleNode("path").InnerText;
                            //store the folder to be passed into the newDatabase form and to be used to create databases 
                            CurrentUserFolderPath = Path.GetDirectoryName(RetrievedUserFilePath);
                        }
                    }
                    xmlDocument.Save(Path.GetFullPath(AllUsersFile));
                    
                    if (string.IsNullOrEmpty(RetrievedUserFilePath))
                    {
                        MessageBox.Show("User Does not exist");
                        ClearFields();
                    }
                    else
                    {
                        //load the xml file if path exists
                        xmlDocument.Load(Path.GetFullPath(RetrievedUserFilePath));
                //match the xml password attribute with access code provided, where ChildNodes[0] is the Xml Declaration node
                        if (xmlDocument.ChildNodes[1].Attributes["password"].Value.ToString() != Txt_Access_Code.Text)
                        {
                           MessageBox.Show("Wrong Password!");
                            ClearFields();
                        }
                        else
                        {
                            //Open the Start up form and pass properties
                            StartupForm dashboard = new StartupForm(RetrievedUsername, RetrievedUserFilePath, CurrentUserFolderPath);
                            dashboard.Show();
                            
                            xmlDocument.Save(Path.GetFullPath(RetrievedUserFilePath));

                            //close this form
                            Hide();
                        }
                    }

                }
            }
        }

        private void Btn_Browse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog browserDialog = new FolderBrowserDialog
            {
                ShowNewFolderButton = true, 
                Description = "Select Folder for your Database files",
                RootFolder = Environment.SpecialFolder.MyDocuments
            };
            if (browserDialog.ShowDialog() == DialogResult.OK)
            {
                string userPath = browserDialog.SelectedPath;
                //Predefined folder in MyDocuments folder
                if (!Directory.Exists(userPath + "\\cmdb"))
                {
                    Directory.CreateDirectory(userPath + "\\cmdb"); //Custom folder in application Data
                }
                //display the folder path on rtb field
                Rtb_User_Directory.Text = Path.GetFullPath(userPath + "\\cmdb"); //User.User_Directory
            }
            else
            {
                MessageBox.Show("You must select a Location!");
                Btn_Browse.Focus();   
            }
        }

        private void Btn_Register_Click(object sender, EventArgs e)
        {
            //Fields have to be checked if empty
            if (string.IsNullOrEmpty(Txt_Username.Text) || string.IsNullOrEmpty(Txt_Password.Text)/* || Txt_Username.Text.All(c => !char.IsLetterOrDigit(c) || c != '_')*/)
                {
                    MessageBox.Show("Fill fields, Username may contain invalid character(s)");
                    ClearFields();
                }

            if (string.IsNullOrEmpty(Rtb_User_Directory.Text))
            {
                MessageBox.Show("You must select a Location!");
            }
            else
            {
                //Go into the users file to retrieve user information
                DB_Handler _Handler = new DB_Handler();
                XmlDocument xmlDocument = new XmlDocument();

                //trim the username for white spaces
                string username = Txt_Username.Text.Trim().ToLower();
                if (!Directory.Exists(_Handler.UsersFolderPath))
                {
                    Directory.CreateDirectory(_Handler.UsersFolderPath);
                }
                string AllUsersFile = Path.GetFullPath(Path.Combine(_Handler.UsersFolderPath, "users.xml"));//create users.xml (empty) File

                //first check if the users.xml file has been created
                if (File.Exists("user.xml"))
                {
                    //Load the users.xml file and check if username and path exists
                    xmlDocument.Load(AllUsersFile);
                    foreach (XmlNode node in xmlDocument.SelectNodes("user"))
                    {
                        if (node.SelectSingleNode("username").InnerText == username)
                        {
                            MessageBox.Show("The username already exists");
                            ClearFields();
                        }
                    }
                    xmlDocument.Save(AllUsersFile);
                }
                //else if username/file doesn't exists validate password
                else 
                { 
                    if (Txt_Password.Text != Txt_Repeat_Password.Text)
                    {
                        MessageBox.Show("Passwords do not match!");
                        Txt_Password.Clear();
                        Txt_Repeat_Password.Clear();
                    }
                    //When validation succeeds
                    else
                    {
                        //generate empty file with username + xml extension
                        string generatedEmptyFilePath = Path.Combine(Rtb_User_Directory.Text, username+".xml");

                        //instantiate User constructor B
                        User userObj = new User(username, Txt_Password.Text, generatedEmptyFilePath);

                        //Create the user, write xml to "users.xml" file
                        _Handler.CreateUser(userObj);
                        
                        //saves user to autoGenerated All Users File
                        _Handler.SaveUsersAccount(username, generatedEmptyFilePath);
                        
                        MessageBox.Show("Your User Account has been Created successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.None);
                        ClearFields();

                        //Go to sign in form
                        GrB_Register_Form.Enabled = false;
                        GrB_Sign_In_Form.Enabled = true;
                        RadioBtn_Returning_User.Checked = true;
                    }
                }
            }
        }

        private void RadioBtn_New_User_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioBtn_New_User.Checked == true)
            {
                //enable registr_Form
                GrB_Register_Form.Enabled = true;
                GrB_Sign_In_Form.Enabled = false;
            }
        }

        private void RadioBtn_Returning_User_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioBtn_Returning_User.Checked == true)
            {
                //enable login form
                GrB_Sign_In_Form.Enabled = true;
                GrB_Register_Form.Enabled = false;
            }
        }

        //Clear Fields Method
        public void ClearFields()
        {
            if(GrB_Register_Form.Enabled == false)//when sign in form is enabled
            {
                Txt_User_ID.Clear();
                Txt_Access_Code.Clear();
                Txt_User_ID.Focus();
            }
            if(GrB_Sign_In_Form.Enabled == false) //when the register form is enabled
            {
                Txt_Username.Clear();
                Txt_Password.Clear();
                Txt_Repeat_Password.Clear();
                Rtb_User_Directory.Clear();
                Txt_Username.Focus();
            }  
        }
        


        ////FIELDS VALIDATION
        ////Username
        //private bool Txt_Username_Validated()
        //{
        //    bool valid = string.IsNullOrEmpty(Txt_Username.Text) || Txt_Username.Text == Path.GetFileNameWithoutExtension(CurrentUserPath) ? false :  true;
        //    return valid;    
        //}

        //private void Txt_Username_Validating(object sender, CancelEventArgs e)
        //{

        //}
        ////Password
        //private bool Txt_Password_Validated()
        //{
        //    bool valid = string.IsNullOrEmpty(Txt_Password.Text) || string.IsNullOrEmpty(Txt_Repeat_Password.Text) || Txt_Password.Text != Txt_Repeat_Password.Text ? false : true;
        //    return valid;
        //}

        //private void Txt_Password_Validating(object sender, CancelEventArgs e)
        //{

        //}
    }
}