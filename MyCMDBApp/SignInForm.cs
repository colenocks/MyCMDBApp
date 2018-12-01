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
        //User Session property to work with
        public string CurrentUserPath { get; private set; }

        public SignInForm()
        {
            InitializeComponent();
        }
        
        private void Btn_Sign_In_Click(object sender, EventArgs e)
        {
            //Fields have to be checked for empty
            if(string.IsNullOrEmpty(Txt_User_ID.Text)|| string.IsNullOrEmpty(Txt_Access_Code.Text))
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
                string userRetrievedPath = "";

                XmlDocument xmlDocument = new XmlDocument();
                //Load the users xml file and check if username and path exists
                xmlDocument.Load(Path.GetFullPath(AllUsersFile));
                foreach (XmlNode node in xmlDocument.SelectNodes("user"))
                {
                    if (node.SelectSingleNode("username").InnerText == userId)
                    {
                        //retrieve the path
                        userRetrievedPath = node.SelectSingleNode("path").InnerText;
                    }
                }

                xmlDocument.Save(Path.GetFullPath(AllUsersFile));
                //check if user file exists
                if (!File.Exists(userRetrievedPath))
                {
                    MessageBox.Show("User does not exist");
                    ClearFields();
                }
                else
                {
                    //if user exist simply Load xml file
                    xmlDocument.Load(userRetrievedPath);
                    if (xmlDocument.ChildNodes[1].Attributes["password"].Value.ToString() == Txt_Access_Code.Text)//match the xml password attribute with access code provided
                    {
                        //set the user session property
                        CurrentUserPath = userRetrievedPath;
                         
                        //Open the Start up form
                        StartupForm dashboard = new StartupForm();
                        dashboard.Show();
                        //close this form
                        Hide();
                        xmlDocument.Save(userRetrievedPath);
                    }
                    else
                    {
                        MessageBox.Show("Wrong Password!");
                        ClearFields();
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
                string AllUsersFile = Path.Combine(_Handler.UsersFolderPath, "users.xml");

                //first check if the user file exists
                if (File.Exists(AllUsersFile))
                {
                    //Load the users xml file and check if username and path exists
                    xmlDocument.Load(Path.GetFullPath(AllUsersFile));
                    foreach (XmlNode node in xmlDocument.SelectNodes("user"))
                    {
                        if (node.SelectSingleNode("username").InnerText == username)
                        {
                            MessageBox.Show("The username already exists");
                            ClearFields();
                        }
                    }

                 xmlDocument.Save(Path.GetFullPath(AllUsersFile));
                }//endif -check for All users file existence
                
                else //else if All users file doesn't exists validate password
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
                        //concatenate an xml extension to the username
                        string autoCreatedUserFile = Path.Combine(Rtb_User_Directory.Text, username+".xml");

                        //instantiate User constructor
                        User userObj = new User(username, Txt_Password.Text, autoCreatedUserFile);//pass in auto-generated xml empty file as "username.xml"
                        //Create the user
                        _Handler.CreateUser(userObj);

                        //set the user session property
                        CurrentUserPath = autoCreatedUserFile;

                        //saves user to autoGenerated All Users File
                        _Handler.SaveUsersAccount(Txt_Username.Text, autoCreatedUserFile);
                           
                        MessageBox.Show("Your User Account has been Created successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.None);
                    ClearFields();

                        //Go to sign in form
                        GrB_Register_Form.Enabled = false;
                        GrB_Sign_In_Form.Enabled = true;
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