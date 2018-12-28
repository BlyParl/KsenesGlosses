namespace KsenesGlosses.AdminMenu
{
    partial class AdminEdit_Word
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
            this.deleteSelected_Button = new System.Windows.Forms.Button();
            this.vocLearningDataSet = new KsenesGlosses.VocLearningDataSet();
            this.wORDINFOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wORD_INFOTableAdapter = new KsenesGlosses.VocLearningDataSetTableAdapters.WORD_INFOTableAdapter();
            this.eNGLISHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eNGLISHTableAdapter = new KsenesGlosses.VocLearningDataSetTableAdapters.ENGLISHTableAdapter();
            this.uSERSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uSERSTableAdapter = new KsenesGlosses.VocLearningDataSetTableAdapters.USERSTableAdapter();
            this.wordsInfo_DataGridView = new System.Windows.Forms.DataGridView();
            this.wordIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.levelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gREEKBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gREEKTableAdapter = new KsenesGlosses.VocLearningDataSetTableAdapters.GREEKTableAdapter();
            this.greekWords_DataGridView = new System.Windows.Forms.DataGridView();
            this.wordIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneticDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.englishWords_DataGridView = new System.Windows.Forms.DataGridView();
            this.wordIDDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wordDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneticDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spanishWords_DataGridView = new System.Windows.Forms.DataGridView();
            this.sPANISHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sPANISHTableAdapter = new KsenesGlosses.VocLearningDataSetTableAdapters.SPANISHTableAdapter();
            this.wordIDDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wordDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneticDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vocLearningDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wORDINFOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eNGLISHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSERSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wordsInfo_DataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gREEKBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greekWords_DataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.englishWords_DataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spanishWords_DataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPANISHBindingSource)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.deleteSelected_Button);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AutoScroll = true;
            this.splitContainer1.Panel2.Controls.Add(this.spanishWords_DataGridView);
            this.splitContainer1.Panel2.Controls.Add(this.englishWords_DataGridView);
            this.splitContainer1.Panel2.Controls.Add(this.greekWords_DataGridView);
            this.splitContainer1.Panel2.Controls.Add(this.wordsInfo_DataGridView);
            this.splitContainer1.Size = new System.Drawing.Size(991, 450);
            this.splitContainer1.SplitterDistance = 61;
            this.splitContainer1.TabIndex = 0;
            // 
            // CancelChanges_Button
            // 
            this.CancelChanges_Button.Location = new System.Drawing.Point(144, 12);
            this.CancelChanges_Button.Name = "CancelChanges_Button";
            this.CancelChanges_Button.Size = new System.Drawing.Size(101, 23);
            this.CancelChanges_Button.TabIndex = 5;
            this.CancelChanges_Button.Text = "Cancel Changes";
            this.CancelChanges_Button.UseVisualStyleBackColor = true;
            this.CancelChanges_Button.Click += new System.EventHandler(this.CancelChanges_Button_Click);
            // 
            // SaveChanges_button
            // 
            this.SaveChanges_button.Location = new System.Drawing.Point(251, 12);
            this.SaveChanges_button.Name = "SaveChanges_button";
            this.SaveChanges_button.Size = new System.Drawing.Size(101, 23);
            this.SaveChanges_button.TabIndex = 4;
            this.SaveChanges_button.Text = "Save Changes";
            this.SaveChanges_button.UseVisualStyleBackColor = true;
            this.SaveChanges_button.Click += new System.EventHandler(this.SaveChanges_button_Click_1);
            // 
            // deleteSelected_Button
            // 
            this.deleteSelected_Button.Location = new System.Drawing.Point(12, 12);
            this.deleteSelected_Button.Name = "deleteSelected_Button";
            this.deleteSelected_Button.Size = new System.Drawing.Size(126, 23);
            this.deleteSelected_Button.TabIndex = 3;
            this.deleteSelected_Button.Text = "Delete Selected Rows";
            this.deleteSelected_Button.UseVisualStyleBackColor = true;
            this.deleteSelected_Button.Click += new System.EventHandler(this.deleteUser_Button_Click);
            // 
            // vocLearningDataSet
            // 
            this.vocLearningDataSet.DataSetName = "VocLearningDataSet";
            this.vocLearningDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // wORDINFOBindingSource
            // 
            this.wORDINFOBindingSource.DataMember = "WORD_INFO";
            this.wORDINFOBindingSource.DataSource = this.vocLearningDataSet;
            // 
            // wORD_INFOTableAdapter
            // 
            this.wORD_INFOTableAdapter.ClearBeforeFill = true;
            // 
            // eNGLISHBindingSource
            // 
            this.eNGLISHBindingSource.DataMember = "ENGLISH";
            this.eNGLISHBindingSource.DataSource = this.vocLearningDataSet;
            // 
            // eNGLISHTableAdapter
            // 
            this.eNGLISHTableAdapter.ClearBeforeFill = true;
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
            // wordsInfo_DataGridView
            // 
            this.wordsInfo_DataGridView.AllowUserToOrderColumns = true;
            this.wordsInfo_DataGridView.AutoGenerateColumns = false;
            this.wordsInfo_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.wordsInfo_DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.wordIDDataGridViewTextBoxColumn,
            this.imageDataGridViewTextBoxColumn,
            this.levelDataGridViewTextBoxColumn,
            this.categoryDataGridViewTextBoxColumn});
            this.wordsInfo_DataGridView.DataSource = this.wORDINFOBindingSource;
            this.wordsInfo_DataGridView.Dock = System.Windows.Forms.DockStyle.Left;
            this.wordsInfo_DataGridView.Location = new System.Drawing.Point(0, 0);
            this.wordsInfo_DataGridView.Name = "wordsInfo_DataGridView";
            this.wordsInfo_DataGridView.Size = new System.Drawing.Size(240, 385);
            this.wordsInfo_DataGridView.TabIndex = 0;
            // 
            // wordIDDataGridViewTextBoxColumn
            // 
            this.wordIDDataGridViewTextBoxColumn.DataPropertyName = "Word_ID";
            this.wordIDDataGridViewTextBoxColumn.HeaderText = "Word_ID";
            this.wordIDDataGridViewTextBoxColumn.Name = "wordIDDataGridViewTextBoxColumn";
            // 
            // imageDataGridViewTextBoxColumn
            // 
            this.imageDataGridViewTextBoxColumn.DataPropertyName = "Image";
            this.imageDataGridViewTextBoxColumn.HeaderText = "Image";
            this.imageDataGridViewTextBoxColumn.Name = "imageDataGridViewTextBoxColumn";
            // 
            // levelDataGridViewTextBoxColumn
            // 
            this.levelDataGridViewTextBoxColumn.DataPropertyName = "Level";
            this.levelDataGridViewTextBoxColumn.HeaderText = "Level";
            this.levelDataGridViewTextBoxColumn.Name = "levelDataGridViewTextBoxColumn";
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            this.categoryDataGridViewTextBoxColumn.DataPropertyName = "Category";
            this.categoryDataGridViewTextBoxColumn.HeaderText = "Category";
            this.categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            // 
            // gREEKBindingSource
            // 
            this.gREEKBindingSource.DataMember = "GREEK";
            this.gREEKBindingSource.DataSource = this.vocLearningDataSet;
            // 
            // gREEKTableAdapter
            // 
            this.gREEKTableAdapter.ClearBeforeFill = true;
            // 
            // greekWords_DataGridView
            // 
            this.greekWords_DataGridView.AutoGenerateColumns = false;
            this.greekWords_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.greekWords_DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.wordIDDataGridViewTextBoxColumn1,
            this.wordDataGridViewTextBoxColumn,
            this.phoneticDataGridViewTextBoxColumn});
            this.greekWords_DataGridView.DataSource = this.gREEKBindingSource;
            this.greekWords_DataGridView.Dock = System.Windows.Forms.DockStyle.Left;
            this.greekWords_DataGridView.Location = new System.Drawing.Point(240, 0);
            this.greekWords_DataGridView.Name = "greekWords_DataGridView";
            this.greekWords_DataGridView.Size = new System.Drawing.Size(240, 385);
            this.greekWords_DataGridView.TabIndex = 1;
            // 
            // wordIDDataGridViewTextBoxColumn1
            // 
            this.wordIDDataGridViewTextBoxColumn1.DataPropertyName = "Word_ID";
            this.wordIDDataGridViewTextBoxColumn1.HeaderText = "Word_ID";
            this.wordIDDataGridViewTextBoxColumn1.Name = "wordIDDataGridViewTextBoxColumn1";
            // 
            // wordDataGridViewTextBoxColumn
            // 
            this.wordDataGridViewTextBoxColumn.DataPropertyName = "Word";
            this.wordDataGridViewTextBoxColumn.HeaderText = "Greek Word";
            this.wordDataGridViewTextBoxColumn.Name = "wordDataGridViewTextBoxColumn";
            // 
            // phoneticDataGridViewTextBoxColumn
            // 
            this.phoneticDataGridViewTextBoxColumn.DataPropertyName = "Phonetic";
            this.phoneticDataGridViewTextBoxColumn.HeaderText = "Greek Phonetic";
            this.phoneticDataGridViewTextBoxColumn.Name = "phoneticDataGridViewTextBoxColumn";
            // 
            // englishWords_DataGridView
            // 
            this.englishWords_DataGridView.AutoGenerateColumns = false;
            this.englishWords_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.englishWords_DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.wordIDDataGridViewTextBoxColumn2,
            this.wordDataGridViewTextBoxColumn1,
            this.phoneticDataGridViewTextBoxColumn1});
            this.englishWords_DataGridView.DataSource = this.eNGLISHBindingSource;
            this.englishWords_DataGridView.Dock = System.Windows.Forms.DockStyle.Left;
            this.englishWords_DataGridView.Location = new System.Drawing.Point(480, 0);
            this.englishWords_DataGridView.Name = "englishWords_DataGridView";
            this.englishWords_DataGridView.Size = new System.Drawing.Size(240, 385);
            this.englishWords_DataGridView.TabIndex = 2;
            // 
            // wordIDDataGridViewTextBoxColumn2
            // 
            this.wordIDDataGridViewTextBoxColumn2.DataPropertyName = "Word_ID";
            this.wordIDDataGridViewTextBoxColumn2.HeaderText = "Word_ID";
            this.wordIDDataGridViewTextBoxColumn2.Name = "wordIDDataGridViewTextBoxColumn2";
            // 
            // wordDataGridViewTextBoxColumn1
            // 
            this.wordDataGridViewTextBoxColumn1.DataPropertyName = "Word";
            this.wordDataGridViewTextBoxColumn1.HeaderText = "English Word";
            this.wordDataGridViewTextBoxColumn1.Name = "wordDataGridViewTextBoxColumn1";
            // 
            // phoneticDataGridViewTextBoxColumn1
            // 
            this.phoneticDataGridViewTextBoxColumn1.DataPropertyName = "Phonetic";
            this.phoneticDataGridViewTextBoxColumn1.HeaderText = "English Phonetic";
            this.phoneticDataGridViewTextBoxColumn1.Name = "phoneticDataGridViewTextBoxColumn1";
            // 
            // spanishWords_DataGridView
            // 
            this.spanishWords_DataGridView.AutoGenerateColumns = false;
            this.spanishWords_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.spanishWords_DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.wordIDDataGridViewTextBoxColumn3,
            this.wordDataGridViewTextBoxColumn2,
            this.phoneticDataGridViewTextBoxColumn2});
            this.spanishWords_DataGridView.DataSource = this.sPANISHBindingSource;
            this.spanishWords_DataGridView.Dock = System.Windows.Forms.DockStyle.Left;
            this.spanishWords_DataGridView.Location = new System.Drawing.Point(720, 0);
            this.spanishWords_DataGridView.Name = "spanishWords_DataGridView";
            this.spanishWords_DataGridView.Size = new System.Drawing.Size(240, 385);
            this.spanishWords_DataGridView.TabIndex = 3;
            // 
            // sPANISHBindingSource
            // 
            this.sPANISHBindingSource.DataMember = "SPANISH";
            this.sPANISHBindingSource.DataSource = this.vocLearningDataSet;
            // 
            // sPANISHTableAdapter
            // 
            this.sPANISHTableAdapter.ClearBeforeFill = true;
            // 
            // wordIDDataGridViewTextBoxColumn3
            // 
            this.wordIDDataGridViewTextBoxColumn3.DataPropertyName = "Word_ID";
            this.wordIDDataGridViewTextBoxColumn3.HeaderText = "Word_ID";
            this.wordIDDataGridViewTextBoxColumn3.Name = "wordIDDataGridViewTextBoxColumn3";
            // 
            // wordDataGridViewTextBoxColumn2
            // 
            this.wordDataGridViewTextBoxColumn2.DataPropertyName = "Word";
            this.wordDataGridViewTextBoxColumn2.HeaderText = "Spanish Word";
            this.wordDataGridViewTextBoxColumn2.Name = "wordDataGridViewTextBoxColumn2";
            // 
            // phoneticDataGridViewTextBoxColumn2
            // 
            this.phoneticDataGridViewTextBoxColumn2.DataPropertyName = "Phonetic";
            this.phoneticDataGridViewTextBoxColumn2.HeaderText = "Spanish Phonetic";
            this.phoneticDataGridViewTextBoxColumn2.Name = "phoneticDataGridViewTextBoxColumn2";
            // 
            // AdminEdit_Word
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(991, 450);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminEdit_Word";
            this.Text = "AdminEdit_Word";
            this.Load += new System.EventHandler(this.AdminEdit_Word_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.vocLearningDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wORDINFOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eNGLISHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSERSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wordsInfo_DataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gREEKBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greekWords_DataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.englishWords_DataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spanishWords_DataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPANISHBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button CancelChanges_Button;
        private System.Windows.Forms.Button SaveChanges_button;
        private System.Windows.Forms.Button deleteSelected_Button;
        private VocLearningDataSet vocLearningDataSet;
        private System.Windows.Forms.BindingSource wORDINFOBindingSource;
        private VocLearningDataSetTableAdapters.WORD_INFOTableAdapter wORD_INFOTableAdapter;
        private System.Windows.Forms.BindingSource eNGLISHBindingSource;
        private VocLearningDataSetTableAdapters.ENGLISHTableAdapter eNGLISHTableAdapter;
        private System.Windows.Forms.BindingSource uSERSBindingSource;
        private VocLearningDataSetTableAdapters.USERSTableAdapter uSERSTableAdapter;
        private System.Windows.Forms.DataGridView wordsInfo_DataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn wordIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn levelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource gREEKBindingSource;
        private VocLearningDataSetTableAdapters.GREEKTableAdapter gREEKTableAdapter;
        private System.Windows.Forms.DataGridView spanishWords_DataGridView;
        private System.Windows.Forms.DataGridView englishWords_DataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn wordIDDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn wordDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneticDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridView greekWords_DataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn wordIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn wordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneticDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource sPANISHBindingSource;
        private VocLearningDataSetTableAdapters.SPANISHTableAdapter sPANISHTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn wordIDDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn wordDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneticDataGridViewTextBoxColumn2;
    }
}