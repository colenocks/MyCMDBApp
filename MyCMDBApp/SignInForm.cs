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
                //set default root folder
                string userPath = browserDialog.SelectedPath;
                userPath += "\\" + Txt_Username.Text + ".xml"; //update variable
                Rtb_User_Directory.Text = Path.GetFullPath(userPath);    
            }
            else
            {
                MessageBox.Show("You must select a folder!");
                Btn_Browse.Focus();   
            }
        }

        private void Btn_Sign_In_Click(object sender, EventArgs e)
        {
            if (!File.Exists(Rtb_User_Directory.Text))
            {
                MessageBox.Show("Sign in Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.None);
                //instantiate User constructor
                User user = new User(Txt_Username.Text, Rtb_User_Directory.Text);

                DB_Handler _Handler = new DB_Handler();
                _Handler.CreateUser(user);

                //close this form
                Hide();
            }
            else
            {
                MessageBox.Show("User Does not Exist");
            }
            //if user exist simply load the database file
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load(Rtb_User_Directory.Text);
            //Open the Start up form
            StartupForm dashboard = new StartupForm();
            dashboard.ShowDialog();

            //close this form
            Hide();

            //Load users xml document
            XmlDocument xmlDoc = new XmlDocument();
            //xmlDoc.Load(path of users xml file)
            //if (user == saved user)
            {

            }
        }
    }
}