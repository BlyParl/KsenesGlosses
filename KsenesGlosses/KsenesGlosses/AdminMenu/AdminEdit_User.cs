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

            //initializeUsersDataGridView();
            
        }

        /// <summary>
        /// Initializes the Data Grid View with the current Users Table
        /// </summary>
        

        private void CancelChanges_Button_Click(object sender, EventArgs e)
        {
            //this way the datagrid is reverted to its previous state discarding all changes
            this.uSERSTableAdapter.Fill(this.vocLearningDataSet.USERS);
        }

        private void deleteUser_Button_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in Users_dataGridView.SelectedRows)
                if (!row.IsNewRow) Users_dataGridView.Rows.Remove(row);
        }

        private void SaveChanges_button_Click(object sender, EventArgs e)
        {
            this.uSERSBindingSource1.EndEdit();
            this.uSERSTableAdapter.Update(this.vocLearningDataSet.USERS);
        }

        private void AdminEdit_User_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'vocLearningDataSet.USERS' table. You can move, or remove it, as needed.
            this.uSERSTableAdapter.Fill(this.vocLearningDataSet.USERS);

        }
    }
}
