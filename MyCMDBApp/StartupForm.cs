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
    public partial class StartupForm : Form
    {
        public StartupForm()
        {
            InitializeComponent();
        }

        private void Btn_Create_Database_Click(object sender, EventArgs e)
        {
            //Create an instance of the new database form
            NewDatabaseForm newDatabaseForm = new NewDatabaseForm();
            //open the form
            newDatabaseForm.ShowDialog();
        }
    }
}
