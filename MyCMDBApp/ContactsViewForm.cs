using CMBLL;
using CMEntities;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Xml;

namespace MyCMDBApp
{
    public partial class ContactsViewForm : Form
    {
        public ContactsViewForm(){}

        public ContactsViewForm(string path, string dbName)
        {
            InitializeComponent();

            XmlDocument xmlDocument = new XmlDocument();
            //Note: all contacts in contactList have common database name and path; contactList[0].Full_Path == contactList[1].Full_Path
            xmlDocument.Load(path.ToString());
            int n = 0;
            foreach (XmlNode node in xmlDocument.SelectNodes($"{dbName}/contact"))
            {
                n = dataGridView1.Rows.Add();//gets the number of rows already in the table

                dataGridView1.Rows[n].Cells[0].Value = node.SelectSingleNode("name").InnerText;
                dataGridView1.Rows[n].Cells[1].Value = node.SelectSingleNode("email").InnerText;
                dataGridView1.Rows[n].Cells[2].Value = node.SelectSingleNode("mobile").InnerText;
                dataGridView1.Rows[n].Cells[3].Value = node.SelectSingleNode("address").InnerText;
            }
            
            xmlDocument.Save(path.ToString());
        }

        private void Btn_Back_Click(object sender, EventArgs e)
        {
            var goBack = (NewDatabaseForm)Tag;
            goBack.Show();
            Close();
        }
    }
}