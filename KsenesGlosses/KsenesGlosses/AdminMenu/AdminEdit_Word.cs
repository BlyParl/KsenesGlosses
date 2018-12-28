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
    public partial class AdminEdit_Word : Form
    {
        public AdminEdit_Word()
        {
            InitializeComponent();
        }

        private void SaveChanges_button_Click(object sender, EventArgs e)
        {

        }

        private void deleteUser_Button_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in wordsInfo_DataGridView.SelectedRows)
                if (!row.IsNewRow)
                {
                    wordsInfo_DataGridView.Rows.Remove(row);
                }

            foreach (DataGridViewRow row in greekWords_DataGridView.SelectedRows)
                if (!row.IsNewRow)
                {
                    greekWords_DataGridView.Rows.Remove(row);
                }

            foreach (DataGridViewRow row in englishWords_DataGridView.SelectedRows)
                if (!row.IsNewRow)
                {
                    englishWords_DataGridView.Rows.Remove(row);
                }

            foreach (DataGridViewRow row in spanishWords_DataGridView.SelectedRows)
            {
                if (!row.IsNewRow)
                {
                    spanishWords_DataGridView.Rows.Remove(row);
                }
            }
        }

        private void AdminEdit_Word_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'vocLearningDataSet.SPANISH' table. You can move, or remove it, as needed.
            this.sPANISHTableAdapter.Fill(this.vocLearningDataSet.SPANISH);
            // TODO: This line of code loads data into the 'vocLearningDataSet.GREEK' table. You can move, or remove it, as needed.
            this.gREEKTableAdapter.Fill(this.vocLearningDataSet.GREEK);
            // TODO: This line of code loads data into the 'vocLearningDataSet.USERS' table. You can move, or remove it, as needed.
            this.uSERSTableAdapter.Fill(this.vocLearningDataSet.USERS);
            // TODO: This line of code loads data into the 'vocLearningDataSet.ENGLISH' table. You can move, or remove it, as needed.
            this.eNGLISHTableAdapter.Fill(this.vocLearningDataSet.ENGLISH);
            // TODO: This line of code loads data into the 'vocLearningDataSet.WORD_INFO' table. You can move, or remove it, as needed.
            this.wORD_INFOTableAdapter.Fill(this.vocLearningDataSet.WORD_INFO);

        }

        private void CancelChanges_Button_Click(object sender, EventArgs e)
        {
            AdminEdit_Word_Load(this, new EventArgs());
        }

        private void SaveChanges_button_Click_1(object sender, EventArgs e)
        {
            try
            {
                //word info update
                wORDINFOBindingSource.EndEdit();
                wORD_INFOTableAdapter.Update(vocLearningDataSet.WORD_INFO);

                //greek words update
                gREEKBindingSource.EndEdit();
                gREEKTableAdapter.Update(vocLearningDataSet.GREEK);

                //english words update
                eNGLISHBindingSource.EndEdit();
                eNGLISHTableAdapter.Update(vocLearningDataSet.ENGLISH);

                //spanish words update
                sPANISHBindingSource.EndEdit();
                sPANISHTableAdapter.Update(vocLearningDataSet.SPANISH);
            }
            catch(Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }
        }
    }
}
