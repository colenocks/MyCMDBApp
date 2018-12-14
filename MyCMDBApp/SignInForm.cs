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
    public partial class SignInForm : Form
    {
        public string ALL_USERS_FILE { get; private set; }

        /**********SESSION PROPERTIES***********/
        public string CurrentUser_FolderPath { get; private set; }

        //info retrieved from successful sign in
        public string RetrievedUserFilePath { get; private set; }
        public string RetrievedUsername { get; private set; }

        public SignInForm()
        {
            InitializeComponent();

                //ON FIRST INSTANCE OF APPLICATION

            //create usersXmlFile "string path" in CMA_ALL_USERS_FOLDER
            DB_Handler _Handler = new DB_Handler();
            //CMA_USERS_FILE Folder
            if (!Directory.Exists(_Handler.CMA_ALL_USERS_FOLDER))
            {
                Directory.CreateDirectory(_Handler.CMA_ALL_USERS_FOLDER);
            }
            ALL_USERS_FILE = Path.GetFullPath(Path.Combine(_Handler.CMA_ALL_USERS_FOLDER, "CMA_users.xml"));    
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
                if (!Directory.Exists(userPath + "\\CMA"))
                {
                    Directory.CreateDirectory(userPath + "\\CMA"); //Custom folder in application Data
                }
                //display the folder path on rtb field
                Rtb_User_Directory.Text = Path.GetFullPath(userPath + "\\CMA");
                //User.User_Directory
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
            if (string.IsNullOrEmpty(Txt_Username.Text) || string.IsNullOrEmpty(Txt_Password.Text) /*|| Txt_Username.Text.All(c => !char.IsLetterOrDigit(c) || c != '_')*/)
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
                DB_Handler _Handler = new DB_Handler();
                XmlDocument xmlDocument = new XmlDocument();

                //trim the username for white spaces
                string username = Txt_Username.Text.Trim().ToLower();

                //first check if the CMA_Users.xml file has been created
                if (File.Exists(ALL_USERS_FILE))
                {
                    //Load and check if username and path exists
                    xmlDocument.Load(ALL_USERS_FILE);
                    foreach (XmlNode node in xmlDocument.SelectNodes("allusers/user"))
                    {
                        if (node.SelectSingleNode("username").InnerText == username)
                        {
                            MessageBox.Show("The username already exists");
                            ClearFields();
                        }
                    }
                    xmlDocument.Save(ALL_USERS_FILE);
                }
                //else if username doesn't exists validate password
                else 
                { 
                    if (Txt_Password.Text != Txt_Repeat_Password.Text)
                    {
                        MessageBox.Show("Passwords do not match!");
                        Txt_Password.Clear();
                        Txt_Repeat_Password.Clear();
                    }
                    //WHEN ALL VALIDATION SUCCEEDS
                    else
                    {
                        //save selected folder from the browse dialog
                        CurrentUser_FolderPath = Rtb_User_Directory.Text;

                        //concatenate empty user file "string path" into CMA_Users Folder
                        string CMA_UsersFolder = Path.Combine(Path.GetDirectoryName(CurrentUser_FolderPath), "CMA_Users");
                        //check if the CMA_Users Folder has been created already
                        if (!Directory.Exists(CMA_UsersFolder))
                        {
                            Directory.CreateDirectory(CMA_UsersFolder);
                        }
                        //concatenate empty user file "string path"
                        string emptyUserFilePath = Path.Combine(CMA_UsersFolder, username+".xml");

                        //instantiate User constructor B
                        User userObj = new User(username, Txt_Password.Text, Path.GetFullPath(emptyUserFilePath));

                        //Create the user's xml file to store info
                        _Handler.CreateUserInfo(userObj);
                        
                        //saves the user into autoGenerated "CMA_Users.xml" file
                        _Handler.SaveUsersAccount(userObj);

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
                string userId = Txt_User_ID.Text.Trim().ToLower();

                //get the ALL USERS folder path from handler class
                DB_Handler _Handler = new DB_Handler();
                string CMA_UsersFile = Path.Combine(_Handler.CMA_ALL_USERS_FOLDER, "CMA_users.xml"); //this file has been created on the first registration 
                
                XmlDocument xmlDocument = new XmlDocument();
                //Load the CMA_users.xml file and check if username and path exists
                if (!File.Exists(CMA_UsersFile))
                {
                   MessageBox.Show("No user have been created in this application yet");
                    ClearFields();
                }
                else
                {
                    xmlDocument.Load(Path.GetFullPath(CMA_UsersFile));
                    //loop through each saved users for the matching user
                    foreach (XmlNode node in xmlDocument.SelectNodes("allusers/user"))
                    {
                        if (node.SelectSingleNode("username").InnerText == userId)
                        {
                            //retrieve the path, username and directoryPath
                            RetrievedUsername = userId;
                            RetrievedUserFilePath = node.SelectSingleNode("path").InnerText; 
                            CurrentUser_FolderPath = Path.GetDirectoryName(RetrievedUserFilePath);
                        }
                    }
                    xmlDocument.Save(Path.GetFullPath(CMA_UsersFile));
                    
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
                            xmlDocument.Save(Path.GetFullPath(RetrievedUserFilePath));
                            //Open the Start up form and pass SESSION PROPERTIES
                            StartupForm startupForm = new StartupForm(RetrievedUsername, RetrievedUserFilePath, CurrentUser_FolderPath);
                            startupForm.Show();
                            Hide();
                        }
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
        public void ClearFields() //hybrid method
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

        private void SignInForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

    }
}