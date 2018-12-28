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
            this.components = new System.ComponentModel.Container();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.CancelChanges_Button = new System.Windows.Forms.Button();
            this.SaveChanges_button = new System.Windows.Forms.Button();
            this.deleteUser_Button = new System.Windows.Forms.Button();
            this.vocLearningDataSet = new KsenesGlosses.VocLearningDataSet();
            this.uSERSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uSERSTableAdapter = new KsenesGlosses.VocLearningDataSetTableAdapters.USERSTableAdapter();
            this.Users_dataGridView = new System.Windows.Forms.DataGridView();
            this.uSERSBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailAdressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vocLearningDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSERSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Users_dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSERSBindingSource1)).BeginInit();
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
            // CancelChanges_Button
            // 
            this.CancelChanges_Button.Location = new System.Drawing.Point(144, 12);
            this.CancelChanges_Button.Name = "CancelChanges_Button";
            this.CancelChanges_Button.Size = new System.Drawing.Size(101, 23);
            this.CancelChanges_Button.TabIndex = 2;
            this.CancelChanges_Button.Text = "Cancel Changes";
            this.CancelChanges_Button.UseVisualStyleBackColor = true;
            this.CancelChanges_Button.Click += new System.EventHandler(this.CancelChanges_Button_Click);
            // 
            // SaveChanges_button
            // 
            this.SaveChanges_button.Location = new System.Drawing.Point(251, 12);
            this.SaveChanges_button.Name = "SaveChanges_button";
            this.SaveChanges_button.Size = new System.Drawing.Size(101, 23);
            this.SaveChanges_button.TabIndex = 1;
            this.SaveChanges_button.Text = "Save Changes";
            this.SaveChanges_button.UseVisualStyleBackColor = true;
            this.SaveChanges_button.Click += new System.EventHandler(this.SaveChanges_button_Click);
            // 
            // deleteUser_Button
            // 
            this.deleteUser_Button.Location = new System.Drawing.Point(12, 12);
            this.deleteUser_Button.Name = "deleteUser_Button";
            this.deleteUser_Button.Size = new System.Drawing.Size(126, 23);
            this.deleteUser_Button.TabIndex = 0;
            this.deleteUser_Button.Text = "Delete Selected User";
            this.deleteUser_Button.UseVisualStyleBackColor = true;
            this.deleteUser_Button.Click += new System.EventHandler(this.deleteUser_Button_Click);
            // 
            // vocLearningDataSet
            // 
            this.vocLearningDataSet.DataSetName = "VocLearningDataSet";
            this.vocLearningDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uSERSBindingSource
            // 
            this.uSERSBindingSource.DataMember = "USERS";
            this.uSERSBindingSource.DataSource = this.vocLearningDataSet;
            // 
            // uSERSTableAdapter
            // 
            this.uSERSTableAdapter.ClearBeforeFill = true;
            // 
            // Users_dataGridView
            // 
            this.Users_dataGridView.AutoGenerateColumns = false;
            this.Users_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Users_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.userNameDataGridViewTextBoxColumn,
            this.emailAdressDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn});
            this.Users_dataGridView.DataSource = this.uSERSBindingSource1;
            this.Users_dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Users_dataGridView.Location = new System.Drawing.Point(0, 0);
            this.Users_dataGridView.Name = "Users_dataGridView";
            this.Users_dataGridView.Size = new System.Drawing.Size(800, 386);
            this.Users_dataGridView.TabIndex = 0;
            // 
            // uSERSBindingSource1
            // 
            this.uSERSBindingSource1.DataMember = "USERS";
            this.uSERSBindingSource1.DataSource = this.vocLearningDataSet;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "First_Name";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "First_Name";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "Last_Name";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "Last_Name";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            // 
            // userNameDataGridViewTextBoxColumn
            // 
            this.userNameDataGridViewTextBoxColumn.DataPropertyName = "User_Name";
            this.userNameDataGridViewTextBoxColumn.HeaderText = "User_Name";
            this.userNameDataGridViewTextBoxColumn.Name = "userNameDataGridViewTextBoxColumn";
            // 
            // emailAdressDataGridViewTextBoxColumn
            // 
            this.emailAdressDataGridViewTextBoxColumn.DataPropertyName = "Email_Adress";
            this.emailAdressDataGridViewTextBoxColumn.HeaderText = "Email_Adress";
            this.emailAdressDataGridViewTextBoxColumn.Name = "emailAdressDataGridViewTextBoxColumn";
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
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
            this.Load += new System.EventHandler(this.AdminEdit_User_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.vocLearningDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSERSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Users_dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSERSBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button CancelChanges_Button;
        private System.Windows.Forms.Button SaveChanges_button;
        private System.Windows.Forms.Button deleteUser_Button;
        private VocLearningDataSet vocLearningDataSet;
        private System.Windows.Forms.BindingSource uSERSBindingSource;
        private VocLearningDataSetTableAdapters.USERSTableAdapter uSERSTableAdapter;
        private System.Windows.Forms.DataGridView Users_dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailAdressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource uSERSBindingSource1;
    }
}