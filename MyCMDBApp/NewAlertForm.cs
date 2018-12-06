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
        private string alertTag; //contact or database alert
        private string Tag_Path; //contact or database alert path

        public NewAlertForm() { }

        public NewAlertForm(string label, string name, string path)
        {
            InitializeComponent();

            Tag_Label.Text = label;
            alertTag = name;
            Tag_Path = path;
        }

        private void NewAlertForm_Load(object sender, EventArgs e)
        {
            

        }

        private void Btn_Save_Alert_Click(object sender, EventArgs e)
        {
            Alert alertObj = new Alert(Txt_Alert_Title.Text, Dtp_Date.Value.ToShortDateString(), Dtp_Time.Value.ToShortTimeString(), alertTag, numericUpDown1.Value);

            DB_Handler _Handler = new DB_Handler();
            //create new folder for alert
            string alertFolder = Path.Combine(Path.GetDirectoryName(Tag_Path), $"{alertTag}_Alerts");

            _Handler.AddAlert(alertObj, alertFolder);
            MessageBox.Show("Finish changes","", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            
        }
    }
}
