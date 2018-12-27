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
    public partial class AdminAdd : Form
    {
        public AdminAdd()
        {
            InitializeComponent();
        }

        private void users_RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if(users_RadioButton.Checked)
            {
                AdminAdd_User adminAdd_User = new AdminAdd_User();
                adminAdd_User.Dock = DockStyle.Fill;
                adminAdd_User.TopLevel = false;
                splitContainer1.Panel2.Controls.Clear();
                splitContainer1.Panel2.Controls.Add(adminAdd_User);
                adminAdd_User.Show();
            }
        }

        private void words_RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            
        }
    }
}
