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
    public partial class ViewAlertsForm : Form
    {
        private List<Alert> Alert_List = new List<Alert>();

        public ViewAlertsForm() { }
        public ViewAlertsForm(List<Alert> list)
        {
            InitializeComponent();
            Alert_List = list;
        }

        private void ViewAlertsForm_Load(object sender, EventArgs e)
        {
            ContactDetailForm detailForm = new ContactDetailForm();
            DataGridView.DataSource = Alert_List;
        }
    }

}
