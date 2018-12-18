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

        private void Exit_test_Click(object sender, EventArgs e)
        {
            //create login item
            MainForm temp = new MainForm();
            //hide create form
            this.Hide();
            //shows login form
            temp.Show_main_panel();
        }
    }
}
