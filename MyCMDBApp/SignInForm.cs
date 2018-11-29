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
        public SignInForm()
        {
            InitializeComponent();
        }

        private void Btn_Sign_In_Click(object sender, EventArgs e)
        {
            
            //    //if user exist simply load the database file
            //    XmlDocument xmlDocument = new XmlDocument();
            ////Load the xml file that contains the list of users
            //    xmlDocument.Load(/*users.xml saved with their "username" and password" filepath */);

            //    //Open the Start up form
            //    StartupForm dashboard = new StartupForm();
            //    dashboard.ShowDialog();

            //    //close this form
            //    Hide();
            //    MessageBox.Show("User does not exist!");
            //    //clear fields
            
        }

        private void Btn_Browse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog browserDialog = new FolderBrowserDialog
            {
                ShowNewFolderButton = false,
                Description = "Select Folder for your Database files",
                RootFolder = Environment.SpecialFolder.ApplicationData
            };
            if (browserDialog.ShowDialog() == DialogResult.OK)
            {
                //set default root folder
                string userPath = browserDialog.SelectedPath;
                userPath += "\\MyDatabases"; //Custom folder in application Data
                Rtb_User_Directory.Text = userPath; //User.User_Directory
            }
            else
            {
                MessageBox.Show("You must select a folder!");
                Btn_Browse.Focus();   
            }
        }

        private void Btn_Register_Click(object sender, EventArgs e)
        {   
            //instantiate User constructor
            User userObj = new User(Txt_Username.Text, Txt_Password.Text, Rtb_User_Directory.Text +"\\"+Txt_Username.Text + ".xml");//pass in auto-generated xml empty file as "username.xml", 

            DB_Handler _Handler = new DB_Handler();
            _Handler.CreateUser(userObj);

            MessageBox.Show("Your User Account has been ceated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.None);

            GrB_Register_Form.Enabled = false;
            GrB_Sign_In_Form.Enabled = true;
        }
    }
}