using CMBLL;
using CMEntities;
using System;
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
    public partial class ContactDetailForm : Form
    {
        private string contactDb_name;
        private string contactDb_path;
        private string contactId;
        private Contact currentContact;
        //private List<Alerts> contact_Alerts = new List<Alerts>();

        public ContactDetailForm() { }

        public ContactDetailForm(string DbName, string DbPath, string name, string email, string mobile, string altMobile, string address, string notes/*, string contactAlerts*/)
        {
            InitializeComponent();
            currentContact = new Contact(DbName, name, email, mobile, altMobile, address, notes, 
                DbPath);
            contactDb_name = DbName;
            contactDb_path = DbPath;
            contactId = name;
        }

        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Are you sure you want to delete this contact", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            DB_Handler _Handler = new DB_Handler();
            _Handler.DeleteContact(currentContact, contactId);//delete
        }

        private void Btn_Edit_Click(object sender, EventArgs e)
        {
            //Disable the form
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
            MessageBox.Show("Save changes to this contact", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            //grabs update contact details
            Contact editedContact = new Contact(contactDb_name, Txt_Name.Text, Txt_Email.Text, Txt_Mobile.Text, Txt_Alt_Mobile.Text, Txt_Address.Text, Txt_Notes.Text, contactDb_path);

            DB_Handler _Handler = new DB_Handler();
            _Handler.UpdateContact(editedContact, contactId);
        }

        private void Btn_Back_Click(object sender, EventArgs e)
        {
            var mdbForm = (ManageDatabasesForm)Tag;
            mdbForm.Show();
            Close();
        }
    }
}
