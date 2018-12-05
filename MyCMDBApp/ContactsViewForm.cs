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

/*   

            ////this shows the list is successfully brought into the form
            //MessageBox.Show($"contacts: {contactList.Count}");

            //DB_Handler _Handler = new DB_Handler();
            ////populate the newly created contactViewList from the contactList
            //contactViewList = _Handler.CloneContact(contactList, contactViewList);

            //for (int i = 0; i < contactViewList.Count; i++)
            //{
            //    contactInfoBindingSource.Add(contactViewList[i]);
            //}   for (int row = 1; row < contactList.Count; row++)
        {
            dataGridView1.Rows[row].Cells[1].Value = contactViewList[row].Name_View;
            dataGridView1.Rows[row].Cells[2].Value = contactViewList[row].Mobile_View;
            dataGridView1.Rows[row].Cells[3].Value = contactViewList[row].Email_View;
            dataGridView1.Rows[row].Cells[3].Value = contactViewList[row].Email_View;
            //add rows to grid view
            dataGridView1.Columns.Add()
        }*/

    //dataGridView1.BorderStyle = BorderStyle.None; dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249); dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal; dataGridView1.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise; dataGridView1.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke; dataGridView1.BackgroundColor = Color.White; dataGridView1.EnableHeadersVisualStyles = false; dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None; dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72); dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

    //for(int col = 0; col < Dgv_ContactInfo.Columns.Count; col++)
    //{
    //    switch (col)
    //    {
    //        case 0: Dgv_ContactInfo.Columns[col].Rows[row].Cells[col].Value = GridColumns[row].Name_View;
//            break;
//        case 1: Dgv_ContactInfo.Rows[row].Cells[col].Value = GridColumns[row].Mobile_View;
//            break;
//        case 2: Dgv_ContactInfo.Rows[row].Cells[col].Value = GridColumns[row].Email_View;
//            break;
//    }

//}  
//}
//else
//{
//    MessageBox.Show("No Contacts", "Null", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
//}
