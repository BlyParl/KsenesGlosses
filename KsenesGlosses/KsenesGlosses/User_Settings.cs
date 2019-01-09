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
    public partial class User_Settings : Form
    {
        public User_Settings()
        {
            InitializeComponent();
        }
        
        // gia na kinite to frame
        Point lastPoint;

        private User user;
        /// <summary>
        /// Gets or sets the user that Loged in
        /// </summary>
        public User LoggedUser
        {
            get { return user; }
            set { user = value; }
        }

        private void User_Settings_Load(object sender, EventArgs e)
        {
            First_name.Text = user.first_name;
            Last_name.Text = user.last_name;
            Username.Text = user.user_name;
            email.Text = user.email_address;

        }
    }
}
