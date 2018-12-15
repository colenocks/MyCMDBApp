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
    public partial class ContactDetailForm : Form
    {
        private string contactDb_name;
        private string contactDb_path;
        public string userAlertFilePath;
        private string userName;
        private string contactId;
        private Contact currentContact;

        private List<Alert> Contact_Alerts_List = new List<Alert>();
        DB_Validator _Validator = new DB_Validator();
        public ContactDetailForm() { }

        public ContactDetailForm(string DbName, string DbPath, string name, string email, string mobile, string altMobile, string address, string notes, string username)
        {
            InitializeComponent();
            //display in fields
            Txt_Name.Text = name;
            Txt_Email.Text = email;
            Txt_Mobile.Text = mobile;
            Txt_Alt_Mobile.Text = altMobile;
            Txt_Address.Text = address;
            Txt_Notes.Text = notes;
            //transport to object
            currentContact = new Contact(DbName, name, email, mobile, altMobile, address, notes, 
                DbPath);

            contactDb_name = DbName;
            contactDb_path = DbPath;
            userName = username;
            contactId = name;

            //Load alert lists if any
            LoadAlertList();
        }

        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Are you sure you want to delete this contact", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            DB_Handler _Handler = new DB_Handler();
            _Handler.DeleteContact(currentContact, contactId);//delete
            
        }

        private void Btn_Edit_Click(object sender, EventArgs e)
        {
            GrBox_Contact_Form.Enabled = true;
            //Clear Txt
            //foreach (Control ctrl in GrBox_Contact_Form.Controls)
            //{
            //    if (ctrl is TextBox)
            //    {
            //        ctrl.Text = "";
            //    }
            //}

            Btn_Save.Enabled = true;
        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Txt_Name.Text))
            {
                MessageBox.Show("Changes have not been saved, please provide a name");
            }
            else
            {
                MessageBox.Show("Save changes to this contact", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                //grabs update contact details
                Contact editedContact = new Contact(contactDb_name, Txt_Name.Text, Txt_Email.Text, Txt_Mobile.Text, Txt_Alt_Mobile.Text, Txt_Address.Text, Txt_Notes.Text, contactDb_path);

                DB_Handler _Handler = new DB_Handler();
                _Handler.UpdateContact(editedContact, contactId);

                //disable fields
                GrBox_Contact_Form.Enabled = false;
            }
        }

        private void Btn_Back_Click(object sender, EventArgs e)
        {
            var mdbForm = (ManageDatabasesForm)Tag;
            mdbForm.Show();
            Close();
        }

        private void ListBox_Alerts_SelectedIndexChanged(object sender, EventArgs e)
        {
            Btn_Delete_Alert.Enabled = true;
        }

        private void Btn_Delete_Alert_Click(object sender, EventArgs e)
        {
            if(listBox_Alerts.SelectedIndex != -1)
            {
                DB_Handler _Handler = new DB_Handler();
                _Handler.DeleteAlert(Contact_Alerts_List[listBox_Alerts.SelectedIndex]);
            }
        }

        private void LoadAlertList()
        {
            DB_Handler _Handler = new DB_Handler();

            //Load the CMA_Users xml file and retrieve alert path
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load(Path.GetFullPath(_Handler.CMA_ALL_USERS_FILE));
            
            foreach (XmlNode node in xmlDocument.SelectNodes("allusers/user"))
            {
                if(node.SelectSingleNode("user").InnerText == userName)
                {
                    userAlertFilePath = node.SelectSingleNode("alert_path").InnerText;
                }
            }
            xmlDocument.Save(Path.GetFullPath(_Handler.CMA_ALL_USERS_FILE));
            if (File.Exists(userAlertFilePath))
            {
                //open up the retrieved alert path
                xmlDocument.Load(Path.GetFullPath(userAlertFilePath));
                Alert alerts = null;
                string tag, title, date, time, reminder;
                tag = contactDb_name;
                foreach (XmlNode node in xmlDocument.SelectNodes($"alerts/{contactDb_name}_alert"))
                {
                    title = node.SelectSingleNode("title").InnerText;
                    date = node.SelectSingleNode("date").InnerText;
                    time = node.SelectSingleNode("time").InnerText;
                    reminder = node.SelectSingleNode("reminder").InnerText;
                    decimal.TryParse(reminder, out decimal _reminder);
                    alerts = new Alert(userName, tag, title, date, time, userAlertFilePath, _reminder);
                    Contact_Alerts_List.Add(alerts);
                }
                xmlDocument.Load(Path.GetFullPath(userAlertFilePath));
            }
            else
            {
                MessageBox.Show("No alerts created yet");
            }
        }
        
        /***************************************************************
                *  FIELDS VALIDATION  *
        **************************************************************/
        private void Txt_Name_TextChanged(object sender, EventArgs e)
        {
            if (_Validator.ValidateName(Txt_Name.Text)) //if validation succeeds
            {
                //errorProvider.Clear();
                errorProvider.SetError(Txt_Name, "");
            }
            else
            {
                errorProvider.SetError(Txt_Name, $"You must Enter Text Only");
                return;
            }
        }

        private void Txt_Email_TextChanged(object sender, EventArgs e)
        {
            if (_Validator.ValidateEmailAddress(Txt_Email.Text))
            {
                errorProvider.SetError(Txt_Email, "");
            }
            else
            {
                errorProvider.SetError(Txt_Email, "Please provide a valid email address");
                return;
            }
        }

        private void Txt_Mobile_TextChanged(object sender, EventArgs e)
        {
            if (_Validator.ValidatePhoneNumber(Txt_Mobile.Text))
            {
                errorProvider.SetError(Txt_Mobile, "");
            }
            else
            {
                errorProvider.SetError(Txt_Mobile, "Contact Number Format xxx-10 Digit Number");
                return;
            }
        }

        private void Txt_Alt_Mobile_TextChanged(object sender, EventArgs e)
        {
            if (!_Validator.ValidatePhoneNumber(Txt_Alt_Mobile.Text))
            {
                errorProvider.SetError(Txt_Alt_Mobile, "");
            }
            else
            {
                errorProvider.SetError(Txt_Alt_Mobile, "Contact Number Format xxx-10 Digit Number");
                return;
            }
        }

    }
}
