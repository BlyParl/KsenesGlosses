namespace KsenesGlosses.AdminMenu
{
    partial class AdminEdit_User
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.deleteUser_Button = new System.Windows.Forms.Button();
            this.Users_dataGridView = new System.Windows.Forms.DataGridView();
            this.SaveChanges_button = new System.Windows.Forms.Button();
            this.CancelChanges_Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Users_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.CancelChanges_Button);
            this.splitContainer1.Panel1.Controls.Add(this.SaveChanges_button);
            this.splitContainer1.Panel1.Controls.Add(this.deleteUser_Button);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.Users_dataGridView);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 60;
            this.splitContainer1.TabIndex = 0;
            // 
            // deleteUser_Button
            // 
            this.deleteUser_Button.Location = new System.Drawing.Point(12, 12);
            this.deleteUser_Button.Name = "deleteUser_Button";
            this.deleteUser_Button.Size = new System.Drawing.Size(126, 23);
            this.deleteUser_Button.TabIndex = 0;
            this.deleteUser_Button.Text = "Delete Selected User";
            this.deleteUser_Button.UseVisualStyleBackColor = true;
            // 
            // Users_dataGridView
            // 
            this.Users_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Users_dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Users_dataGridView.Location = new System.Drawing.Point(0, 0);
            this.Users_dataGridView.Name = "Users_dataGridView";
            this.Users_dataGridView.Size = new System.Drawing.Size(800, 386);
            this.Users_dataGridView.TabIndex = 0;
            // 
            // SaveChanges_button
            // 
            this.SaveChanges_button.Location = new System.Drawing.Point(687, 12);
            this.SaveChanges_button.Name = "SaveChanges_button";
            this.SaveChanges_button.Size = new System.Drawing.Size(101, 23);
            this.SaveChanges_button.TabIndex = 1;
            this.SaveChanges_button.Text = "Save Changes";
            this.SaveChanges_button.UseVisualStyleBackColor = true;
            // 
            // CancelChanges_Button
            // 
            this.CancelChanges_Button.Location = new System.Drawing.Point(580, 12);
            this.CancelChanges_Button.Name = "CancelChanges_Button";
            this.CancelChanges_Button.Size = new System.Drawing.Size(101, 23);
            this.CancelChanges_Button.TabIndex = 2;
            this.CancelChanges_Button.Text = "Cancel Changes";
            this.CancelChanges_Button.UseVisualStyleBackColor = true;
            // 
            // AdminEdit_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminEdit_User";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Users_dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button CancelChanges_Button;
        private System.Windows.Forms.Button SaveChanges_button;
        private System.Windows.Forms.Button deleteUser_Button;
        private System.Windows.Forms.DataGridView Users_dataGridView;
    }
}