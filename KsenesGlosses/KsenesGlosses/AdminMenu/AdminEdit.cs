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
    public partial class AdminEdit : Form
    {
        public AdminEdit()
        {
            InitializeComponent();
        }

        private void Users_RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            AdminEdit_User adminEdit_User = new AdminEdit_User();
            adminEdit_User.Dock = DockStyle.Fill;
            adminEdit_User.TopLevel = false;
            splitContainer1.Panel2.Controls.Clear();
            splitContainer1.Panel2.Controls.Add(adminEdit_User);
            adminEdit_User.Show();
        }

        private void Words_CheckedChanged(object sender, EventArgs e)
        {
            AdminEdit_Word adminEdit_Word = new AdminEdit_Word();
            adminEdit_Word.Dock = DockStyle.Fill;
            adminEdit_Word.TopLevel = false;
            splitContainer1.Panel2.Controls.Clear();
            splitContainer1.Panel2.Controls.Add(adminEdit_Word);
            adminEdit_Word.Show();
        }
    }
}
