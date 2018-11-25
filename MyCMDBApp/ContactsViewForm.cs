using CMBLL;
using CMEntities;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MyCMDBApp
{
    public partial class ContactsViewForm : Form
    {
        public ContactsViewForm(List<Contact> contactList)
        {
            InitializeComponent();

            List<ContactInfo> contactViewList = new List<ContactInfo>();

            //this shows the list is successfully brought into the form
            MessageBox.Show($"contacts: {contactList.Count}");

            DB_Handler _Handler = new DB_Handler();
            _Handler.CloneContact(contactList, contactViewList);
            for(int i = 0; i < contactViewList.Count; i++)
            {
               contactInfoBindingSource.Add(contactViewList[i]);
            }
            
        }
        /*for (int row = 1; row < contactList.Count; row++)
            {
                dataGridView1.Rows[row].Cells[1].Value = contactViewList[row].Name_View;
                dataGridView1.Rows[row].Cells[2].Value = contactViewList[row].Mobile_View;
                dataGridView1.Rows[row].Cells[3].Value = contactViewList[row].Email_View;
                dataGridView1.Rows[row].Cells[3].Value = contactViewList[row].Email_View;
                //add rows to grid view
                dataGridView1.Columns.Add()
            }*/
    }
}

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
       