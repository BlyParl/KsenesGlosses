namespace KsenesGlosses.AdminMenu
{
    partial class AdminAdd_User
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.firstName_TextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lastName_TextBox = new System.Windows.Forms.TextBox();
            this.username_TextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.email_TextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.password_TextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.addUser_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            // 
            // firstName_TextBox
            // 
            this.firstName_TextBox.Location = new System.Drawing.Point(16, 30);
            this.firstName_TextBox.Name = "firstName_TextBox";
            this.firstName_TextBox.Size = new System.Drawing.Size(100, 20);
            this.firstName_TextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Last Name";
            // 
            // lastName_TextBox
            // 
            this.lastName_TextBox.Location = new System.Drawing.Point(16, 69);
            this.lastName_TextBox.Name = "lastName_TextBox";
            this.lastName_TextBox.Size = new System.Drawing.Size(100, 20);
            this.lastName_TextBox.TabIndex = 3;
            // 
            // username_TextBox
            // 
            this.username_TextBox.Location = new System.Drawing.Point(16, 108);
            this.username_TextBox.Name = "username_TextBox";
            this.username_TextBox.Size = new System.Drawing.Size(100, 20);
            this.username_TextBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Username";
            // 
            // email_TextBox
            // 
            this.email_TextBox.Location = new System.Drawing.Point(16, 147);
            this.email_TextBox.Name = "email_TextBox";
            this.email_TextBox.Size = new System.Drawing.Size(100, 20);
            this.email_TextBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Email";
            // 
            // password_TextBox
            // 
            this.password_TextBox.Location = new System.Drawing.Point(16, 186);
            this.password_TextBox.Name = "password_TextBox";
            this.password_TextBox.PasswordChar = '*';
            this.password_TextBox.Size = new System.Drawing.Size(100, 20);
            this.password_TextBox.TabIndex = 9;
            this.password_TextBox.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Password";
            // 
            // addUser_Button
            // 
            this.addUser_Button.Location = new System.Drawing.Point(16, 213);
            this.addUser_Button.Name = "addUser_Button";
            this.addUser_Button.Size = new System.Drawing.Size(100, 23);
            this.addUser_Button.TabIndex = 10;
            this.addUser_Button.Text = "Add new user";
            this.addUser_Button.UseVisualStyleBackColor = true;
            this.addUser_Button.Click += new System.EventHandler(this.addUser_Button_Click);
            // 
            // AdminAdd_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.addUser_Button);
            this.Controls.Add(this.password_TextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.email_TextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.username_TextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lastName_TextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.firstName_TextBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminAdd_User";
            this.Text = "AdminAdd_User";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox firstName_TextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox lastName_TextBox;
        private System.Windows.Forms.TextBox username_TextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox email_TextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox password_TextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button addUser_Button;
    }
}