namespace KsenesGlosses
{
    partial class Email
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Border = new System.Windows.Forms.Panel();
            this.Minimize = new System.Windows.Forms.PictureBox();
            this.Close = new System.Windows.Forms.PictureBox();
            this.email_textbox = new System.Windows.Forms.TextBox();
            this.panel_email = new System.Windows.Forms.Panel();
            this.img_email = new System.Windows.Forms.PictureBox();
            this.Send_email = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Border.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_email)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::KsenesGlosses.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // Border
            // 
            this.Border.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(36)))), ((int)(((byte)(60)))));
            this.Border.Controls.Add(this.Minimize);
            this.Border.Controls.Add(this.pictureBox1);
            this.Border.Controls.Add(this.Close);
            this.Border.Location = new System.Drawing.Point(0, 0);
            this.Border.Name = "Border";
            this.Border.Size = new System.Drawing.Size(410, 32);
            this.Border.TabIndex = 9;
            this.Border.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Border_MouseDown);
            this.Border.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Border_MouseMove);
            // 
            // Minimize
            // 
            this.Minimize.Image = global::KsenesGlosses.Properties.Resources.minimize;
            this.Minimize.Location = new System.Drawing.Point(346, 0);
            this.Minimize.Name = "Minimize";
            this.Minimize.Size = new System.Drawing.Size(32, 32);
            this.Minimize.TabIndex = 7;
            this.Minimize.TabStop = false;
            this.Minimize.Click += new System.EventHandler(this.Minimize_Click);
            // 
            // Close
            // 
            this.Close.Image = global::KsenesGlosses.Properties.Resources.close;
            this.Close.Location = new System.Drawing.Point(378, 0);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(32, 32);
            this.Close.TabIndex = 7;
            this.Close.TabStop = false;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // email_textbox
            // 
            this.email_textbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.email_textbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.email_textbox.Font = new System.Drawing.Font("Arial", 14.25F);
            this.email_textbox.ForeColor = System.Drawing.Color.White;
            this.email_textbox.HideSelection = false;
            this.email_textbox.Location = new System.Drawing.Point(133, 80);
            this.email_textbox.Name = "email_textbox";
            this.email_textbox.Size = new System.Drawing.Size(201, 22);
            this.email_textbox.TabIndex = 12;
            this.email_textbox.TabStop = false;
            this.email_textbox.Text = "email";
            this.email_textbox.Click += new System.EventHandler(this.email_textbox_Click);
            // 
            // panel_email
            // 
            this.panel_email.BackColor = System.Drawing.Color.White;
            this.panel_email.Location = new System.Drawing.Point(84, 108);
            this.panel_email.Name = "panel_email";
            this.panel_email.Size = new System.Drawing.Size(250, 5);
            this.panel_email.TabIndex = 11;
            // 
            // img_email
            // 
            this.img_email.Image = global::KsenesGlosses.Properties.Resources.email;
            this.img_email.Location = new System.Drawing.Point(84, 70);
            this.img_email.Name = "img_email";
            this.img_email.Size = new System.Drawing.Size(32, 32);
            this.img_email.TabIndex = 10;
            this.img_email.TabStop = false;
            // 
            // Send_email
            // 
            this.Send_email.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(255)))));
            this.Send_email.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Send_email.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Send_email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.Send_email.Location = new System.Drawing.Point(84, 148);
            this.Send_email.Name = "Send_email";
            this.Send_email.Size = new System.Drawing.Size(250, 41);
            this.Send_email.TabIndex = 13;
            this.Send_email.Text = "Send email";
            this.Send_email.UseVisualStyleBackColor = false;
            this.Send_email.Click += new System.EventHandler(this.Send_email_Click);
            // 
            // Email
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(409, 249);
            this.Controls.Add(this.Send_email);
            this.Controls.Add(this.email_textbox);
            this.Controls.Add(this.panel_email);
            this.Controls.Add(this.img_email);
            this.Controls.Add(this.Border);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Email";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Email_Load);
            this.Click += new System.EventHandler(this.Email_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Border.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_email)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel Border;
        private System.Windows.Forms.PictureBox Minimize;
        private System.Windows.Forms.PictureBox Close;
        private System.Windows.Forms.TextBox email_textbox;
        private System.Windows.Forms.Panel panel_email;
        private System.Windows.Forms.PictureBox img_email;
        private System.Windows.Forms.Button Send_email;
    }
}