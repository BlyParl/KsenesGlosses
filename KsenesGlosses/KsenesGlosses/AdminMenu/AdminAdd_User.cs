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
    public partial class AdminAdd_User : Form
    {
        public AdminAdd_User()
        {
            InitializeComponent();
        }

        private void addUser_Button_Click(object sender, EventArgs e)
        {
            try
            {
                VocLearningDataSetTableAdapters.USERSTableAdapter usersTableAdapter = new VocLearningDataSetTableAdapters.USERSTableAdapter();

                usersTableAdapter.InsertUser(firstName_TextBox.Text,
                    lastName_TextBox.Text,
                    username_TextBox.Text,
                    email_TextBox.Text,
                    password_TextBox.Text);
            }
            catch(Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }
            
        }
    }
}
