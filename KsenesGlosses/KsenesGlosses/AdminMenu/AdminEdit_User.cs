using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KsenesGlosses;

namespace KsenesGlosses.AdminMenu
{
    public partial class AdminEdit_User : Form
    {
        public AdminEdit_User()
        {
            InitializeComponent();

            initializeUsersDataGridView();
            
        }

        /// <summary>
        /// Initializes the Data Grid View with the current Users Table
        /// </summary>
        void initializeUsersDataGridView()
        {
            VocLearningDataSetTableAdapters.USERSTableAdapter usersTableAdapter = new VocLearningDataSetTableAdapters.USERSTableAdapter();
            Users_dataGridView.DataSource = usersTableAdapter.GetData();
        }
    }
}
