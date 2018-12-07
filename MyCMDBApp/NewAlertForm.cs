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
        private string AlertFolder;

        public NewAlertForm() { }

        public NewAlertForm(string label, string username, string userFolder)
        {
            InitializeComponent();

            Tag_Label.Text = label;

            ContactOrDb_name = label;
            UserFolderPath = userFolder;
            Username = username;
        }

        private void NewAlertForm_Load(object sender, EventArgs e)
        {
            DB_Handler _Handler = new DB_Handler();
            //Create the alert folder
            AlertFolder = _Handler.CreateAlertFolder(Username, UserFolderPath);
        }

        private void Btn_Save_Alert_Click(object sender, EventArgs e)
        {
            Alert alertObj = new Alert(Txt_Alert_Title.Text, Dtp_Date.Value.ToShortDateString(), Dtp_Time.Value.ToShortTimeString(), ContactOrDb_name, numericUpDown1.Value);

            MessageBox.Show("Finish changes","", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            DB_Handler _Handler = new DB_Handler();
            _Handler.AddAlert(alertObj, AlertFolder);
        }
    }
}
