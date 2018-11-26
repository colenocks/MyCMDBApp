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

        private void Btn_Search_Click(object sender, EventArgs e)
        {   
            string command = Rtb_Search.Text.Trim();
            if (!(command.Contains(":")) || (command.Contains("$")) || (command.Contains("+")) || (command.Contains("-")))
            {
                MessageBox.Show("Invalid Command Language");
                Rtb_Search.Text = "";
                Rtb_Search.Focus();
            }
            else
            {
                //get length
                int searchContentLength = command.Length;
                char[] commandArray = new char[searchContentLength];
                int colonIndex = command.IndexOf(":");
                int afterColon = colonIndex + 1;
                string Key1 = command.Substring(0, colonIndex);
                string [] NodesArray = new string []{ "name", "email", "mobile", "alternative", "address", "information" };
                string key1_Value;
                foreach (string node in NodesArray)
                {
                    if(node == Key1)
                    {
                       key1_Value = command.Substring(afterColon, searchContentLength - afterColon);
                    }
                }
            }
        }

        //public void NameCommand()
        //{
        //    string command = "name:coleman";
        //    int Len = command.Length; //12 
        //    int colonIndex = command.IndexOf(":"); // = 4
        //    int afterColon = colonIndex + 1; // = 5
        //    string Key1 = command.Substring(0, colonIndex);
        //    MessageBox.Show($"{Key1}");
        //    string key1_Value = command.Substring(afterColon, Len - afterColon);
        //    MessageBox.Show($"{key1_Value}");
        //}
    }
}
