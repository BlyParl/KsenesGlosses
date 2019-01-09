using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KsenesGlosses
{
    public partial class ImageTestForm : Form
    {
        public ImageTestForm()
        {
            InitializeComponent();
        }

        VocLearningDataSetTableAdapters.WORD_INFOTableAdapter word_info_addapter;

        private void Exit_test_Click(object sender, EventArgs e)
        {
            //create login item
            MainForm temp = new MainForm();
            //hide create form
            this.Hide();
            //shows login form
            temp.Show_main_panel();
        }

        private void Next_Click(object sender, EventArgs e)
        {

        }

        private void ImageTestForm_Load(object sender, EventArgs e)
        {
            word_info_addapter= new VocLearningDataSetTableAdapters.WORD_INFOTableAdapter();

                word_info_addapter.Get_image_by_wordid(1);
        }
    }
}
