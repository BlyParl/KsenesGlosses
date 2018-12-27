using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KsenesGlosses.AdminMenu
{
    public partial class AdminMenu : Form
    {
        public AdminMenu()
        {
            InitializeComponent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Edit_RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if(Edit_RadioButton.Checked)
            {
                AdminEdit adminEdit = new AdminEdit();
                adminEdit.Dock = DockStyle.Fill;
                adminEdit.TopLevel = false;
                splitContainer1.Panel2.Controls.Clear();
                splitContainer1.Panel2.Controls.Add(adminEdit);
                adminEdit.Show();

            }
        }

        private void Add_RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (Add_RadioButton.Checked)
            {
                AdminAdd adminAdd = new AdminAdd();
                adminAdd.Dock = DockStyle.Fill;
                adminAdd.TopLevel = false;
                splitContainer1.Panel2.Controls.Clear();
                splitContainer1.Panel2.Controls.Add(adminAdd);
                adminAdd.Show();
            }
        }
    }
}
