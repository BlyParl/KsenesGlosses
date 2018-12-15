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
    public partial class TranslationTestForm : Form
    {
        public TranslationTestForm()
        {
            InitializeComponent();
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            progressBar1.PerformStep();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
                
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Exit Current Test?", "Exit", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                MainForm main = new MainForm();
                this.Close();
                
             
            }
        }
    }
}
