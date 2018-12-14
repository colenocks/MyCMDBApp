using CMBLL;
using CMEntities; //reference to the CMentities Class Library
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCMDBApp
{
    public partial class NewAlertForm : Form
    {
        private string ContactOrDb_name; //contact or database alert
        private string UserFolderPath; //contact or database alert path
        private string Username;
        private string AlertFolderPath;

        public NewAlertForm() { }

        public NewAlertForm(string label, string username, string userFolder)
        {
            InitializeComponent();

            Tag_Label.Text = "Alert for "+label;
            Tag_Label.ForeColor = Color.DarkOliveGreen;

            ContactOrDb_name = label;
            UserFolderPath = userFolder;
            Username = username; //create the alert folder with username
        }

        private void NewAlertForm_Load(object sender, EventArgs e)
        {
            //Create folder structure for alert in Browse location
            string browseFolder = Path.GetDirectoryName(UserFolderPath);
            //create Alert Folder inside CMA Folder as alert form loads
            string alertFolderPath = Path.Combine(browseFolder, "CMA_Alerts");
            if (!Directory.Exists(alertFolderPath))
            {
                Directory.CreateDirectory(alertFolderPath);
            }
            AlertFolderPath = alertFolderPath;
        }

        private void Btn_Save_Alert_Click(object sender, EventArgs e)
        {
            Alert alertObj = new Alert(Username, ContactOrDb_name, Txt_Alert_Title.Text, Dtp_DateTime.Value.ToShortDateString(), Dtp_DateTime.Value.ToShortTimeString(), AlertFolderPath, numericUpDown1.Value);

            MessageBox.Show("Finish changes","", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

             DB_Handler _Handler = new DB_Handler();
            _Handler.AddAlert(alertObj);

            //Clear after adding
            foreach (Control ctrl in GrBox_AlertBox.Controls)
            {
                if (ctrl is TextBox)
                {
                    ctrl.Text = "";
                }
            }
            GrBox_AlertBox.Enabled = false;
            Btn_Save_Alert.Enabled = false;
        }

        private void Btn_Home_Click(object sender, EventArgs e)
        {
            var newContactForm = (NewContactForm)Tag; //use the tag property of the previous to hold it's state.
            newContactForm.Show();
            Close();
        }

        private void Btn_Add_Alert_Click(object sender, EventArgs e)
        {
            //re-enable fields for alerts
            GrBox_AlertBox.Enabled = false;
            Btn_Save_Alert.Enabled = false;
        }
    }
}
