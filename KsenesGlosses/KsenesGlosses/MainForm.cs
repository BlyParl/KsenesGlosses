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
    public partial class MainForm : Form
    {
       
        public MainForm()
        {
            InitializeComponent();
        }
        public Panel GetMainPanel()
        {
            return MainPanel;
        }


        // gia na kinite to frame
        Point lastPoint;

        private void button4_Click(object sender, EventArgs e)
        {
            foreach (Control c in this.MainPanel.Controls)
            {
                c.Visible = false;
            }

            if (comboBox1.SelectedIndex == 0)
            {
                TranslationTestForm vocal = new TranslationTestForm();
                vocal.Dock = DockStyle.Fill;
                vocal.TopLevel = false;
                MainPanel.Controls.Add(vocal);
                vocal.Show();
                
            }
            else

                 if (comboBox1.SelectedIndex == 1)
            {
                VocalTestForm imagesTest = new VocalTestForm();
                imagesTest.Dock = DockStyle.Fill;
                imagesTest.TopLevel = false;
                MainPanel.Controls.Add(imagesTest);
                imagesTest.Show();
            }
            else
            {
                ImageTestForm TranslationTest = new ImageTestForm();
                TranslationTest.Dock = DockStyle.Fill;
                TranslationTest.TopLevel = false;
                MainPanel.Controls.Add(TranslationTest);
                TranslationTest.Show();
            }


        }


        //picturebox3 EventHandlers
        private void pictureBox3_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
           /*
            this.pictureBox3.BackColor = Color.FromArgb(192, 225, 0);
            this.pictureBox1.BackColor = Color.FromArgb(34, 36, 49);
            this.pictureBox2.BackColor = Color.FromArgb(34, 36, 49);
            
            if (pictureBox1.BackColor == Color.FromArgb(192, 225, 0))
            {
                this.pictureBox3.BackColor = Color.FromArgb(192, 225, 0);
                this.pictureBox2.BackColor = Color.FromArgb(34, 36, 49);
            }
            else
              if (pictureBox2.BackColor == Color.FromArgb(192, 225, 0))
            {
                this.pictureBox3.BackColor = Color.FromArgb(192, 225, 0);
                this.pictureBox1.BackColor = Color.FromArgb(34, 36, 49);
            }
            else
            {
                this.pictureBox3.BackColor = Color.FromArgb(192, 225, 0);
            }
             */

        }
        
        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
            
        }


        private void pictureBox3_Click(object sender, EventArgs e)
        {

            this.pictureBox3.BackColor = Color.FromArgb(192, 225, 0);
            this.pictureBox1.BackColor = Color.FromArgb(34, 36, 49);
            this.pictureBox2.BackColor = Color.FromArgb(34, 36, 49);

        }

        
        //picturebox2 EventHandlers

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
            /* 
            this.pictureBox2.BackColor = Color.FromArgb(192, 225, 0);
            this.pictureBox1.BackColor = Color.FromArgb(34, 36, 49);

            this.pictureBox3.BackColor = Color.FromArgb(34, 36, 49);
            
            
           
              if (pictureBox3.BackColor == Color.FromArgb(192, 225, 0))
            {
                this.pictureBox2.BackColor = Color.FromArgb(192, 225, 0);
                this.pictureBox1.BackColor = Color.FromArgb(34, 36, 49);
            }
            else
               if (pictureBox1.BackColor == Color.FromArgb(192, 225, 0))
            {
                this.pictureBox2.BackColor = Color.FromArgb(192, 225, 0);
                this.pictureBox3.BackColor = Color.FromArgb(34, 36, 49);
            }
            else
            {
                this.pictureBox2.BackColor = Color.FromArgb(192, 225, 0);
            }
          */

        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
            

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.pictureBox2.BackColor = Color.FromArgb(192, 225, 0);
            this.pictureBox1.BackColor = Color.FromArgb(34, 36, 49);
            this.pictureBox3.BackColor = Color.FromArgb(34, 36, 49);
        }

        

        //picturebox1 EventHandlers
        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
            /*
            this.pictureBox1.BackColor = Color.FromArgb(192, 225, 0);
            this.pictureBox2.BackColor = Color.FromArgb(34, 36, 49);
            this.pictureBox3.BackColor = Color.FromArgb(34, 36, 49);
            
            if (pictureBox3.BackColor == Color.FromArgb(192, 225, 0))
            {
                this.pictureBox1.BackColor = Color.FromArgb(192, 225, 0);
                this.pictureBox2.BackColor = Color.FromArgb(34, 36, 49);
            }
            else
              if (pictureBox2.BackColor == Color.FromArgb(192, 225, 0))
            {
                this.pictureBox1.BackColor = Color.FromArgb(192, 225, 0);
                this.pictureBox3.BackColor = Color.FromArgb(34, 36, 49);
            }
            else
            {
                this.pictureBox1.BackColor = Color.FromArgb(192, 225, 0);
            }
            */
        }
        private void pictureBox1_MouseLeave(object sender,EventArgs e)
        {
            this.Cursor = Cursors.Default;
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.pictureBox1.BackColor = Color.FromArgb(192, 225, 0);
            this.pictureBox2.BackColor = Color.FromArgb(34, 36, 49);
            this.pictureBox3.BackColor = Color.FromArgb(34, 36, 49);
        }


        private void Close_Click(object sender, EventArgs e)
        {
            //exit aplication
            Application.Exit();
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            //minimize aplication
            this.WindowState = FormWindowState.Minimized;
        }

        private void Border_MouseMove(object sender, MouseEventArgs e)
        {
            //metakinisi tou frame
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void Border_MouseDown(object sender, MouseEventArgs e)
        {
            //apothikeuei to teleuteo simio pou afise to parathiro
            lastPoint = new Point(e.X, e.Y);
        }
    }
}
