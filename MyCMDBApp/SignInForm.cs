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
        public string UserParentDirectory { get; private set; }

        //info retrieved from successful sign in
        public string RetrievedUserFilePath { get; private set; }
        public string RetrievedUsername { get; private set; }

        public SignInForm()
        {
            InitializeComponent();
        }

        private void SignInForm_Load(object sender, EventArgs e)
        {
            //create usersXmlFile "string path" in CMA_ALL_USERS_FOLDER
            DB_Handler _Handler = new DB_Handler();

            //CMA_USERS_FILE Folder
            //this is created when a user registers
            string usersfile = Path.Combine(_Handler.CMA_ALL_USERS_FOLDER, "CMA_users.xml");
            ALL_USERS_FILE = Path.GetFullPath(usersfile);

            DB_Handler b_Handler = new DB_Handler(ALL_USERS_FILE);
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
                if (!Directory.Exists(userPath))
                {
                    Directory.CreateDirectory(userPath); //Custom folder in application Data
                }
                //display the folder path on rtb field
                Rtb_User_Directory.Text = Path.GetFullPath(userPath);
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
                bool userExists = false;
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
                            userExists = true;
                        }
                    }
                    xmlDocument.Save(ALL_USERS_FILE);
                }
                //else if username doesn't exists validate password
                if(!userExists) 
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
                        UserParentDirectory = Rtb_User_Directory.Text;
                        
                        if (!Directory.Exists(UserParentDirectory))
                        {
                            Directory.CreateDirectory(UserParentDirectory);
                        }
                        //concatenate empty user file "string path"
                        string UserFilePath = Path.GetFullPath(Path.Combine(UserParentDirectory, username+".xml"));

                        //instantiate User constructor B
                        User userObj = new User(username, Txt_Password.Text, UserFilePath, UserParentDirectory);

                        //Create the user's xml file to store info
                        _Handler.CreateUserInfo(userObj);
                        
                        //saves the user into autoGenerated "CMA_Users.xml" file
                        _Handler.SaveUsersAccount(userObj, ALL_USERS_FILE);

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
                //string CMA_UsersFile = Path.Combine(_Handler.CMA_ALL_USERS_FOLDER, "CMA_users.xml"); //this file has been created on the first registration 
                
                XmlDocument xmlDocument = new XmlDocument();
                //Load the CMA_users.xml file and check if username and path exists
                if (!File.Exists(ALL_USERS_FILE))
                {
                   MessageBox.Show("No user have been created in this application yet");
                    ClearFields();
                }
                else
                {
                    xmlDocument.Load(Path.GetFullPath(ALL_USERS_FILE));
                    //loop through each saved users for the matching user
                    foreach (XmlNode node in xmlDocument.SelectNodes("allusers/user"))
                    {
                        if (node.SelectSingleNode("username").InnerText == userId)
                        {
                            //retrieve the path, username and directoryPath
                            RetrievedUsername = userId;
                            RetrievedUserFilePath = node.SelectSingleNode("path").InnerText; 
                            UserParentDirectory = Path.GetDirectoryName(RetrievedUserFilePath);
                        }
                    }
                    xmlDocument.Save(Path.GetFullPath(ALL_USERS_FILE));
                    
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
                            StartupForm startupForm = new StartupForm(RetrievedUsername, RetrievedUserFilePath, UserParentDirectory);
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
                ClearFields();
            }
        }

        private void RadioBtn_Returning_User_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioBtn_Returning_User.Checked == true)
            {
                //enable login form
                GrB_Sign_In_Form.Enabled = true;
                GrB_Register_Form.Enabled = false;
                ClearFields();
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