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
        private string UserParentDirectory; //contact or database alert path
        private string Username;
        private string AlertfilePath;

        public NewAlertForm() { }

        public NewAlertForm(string label, string username, string userFolder)
        {
            InitializeComponent();
            Tag_Label.Text = "Alert for "+label;
            Tag_Label.ForeColor = Color.DarkOliveGreen;

            ContactOrDb_name = label;
            UserParentDirectory = userFolder;
            Username = username; //create the alert folder with username
        }

        private void NewAlertForm_Load(object sender, EventArgs e)
        {
            //create Alert Folder in the paren directory as alert form loads
            string alertFolder = Path.Combine(UserParentDirectory, $"{Username}_Alerts");
            if (!Directory.Exists(alertFolder))
            {
                Directory.CreateDirectory(alertFolder);
            }
            AlertfilePath = Path.GetFullPath(Path.Combine(alertFolder, "Alerts.xml"));
        }

        private void Btn_Save_Alert_Click(object sender, EventArgs e)
        {
            Alert alertObj = new Alert(Username, ContactOrDb_name, Txt_Alert_Title.Text, Dtp_DateTime.Value.ToShortDateString(), Dtp_DateTime.Value.ToShortTimeString(), AlertfilePath, numericUpDown1.Value);

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
            Btn_Add_Alert.Enabled = true;
        }

        private void Btn_Home_Click(object sender, EventArgs e)
        {
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
