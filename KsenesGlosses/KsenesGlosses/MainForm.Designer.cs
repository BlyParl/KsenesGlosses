namespace KsenesGlosses
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.Logout_button = new System.Windows.Forms.Button();
            this.Music = new System.Windows.Forms.Button();
            this.admin_Button = new System.Windows.Forms.Button();
            this.User_Settings = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.testErrors_label = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.chooseDifficulty_radioButton = new System.Windows.Forms.RadioButton();
            this.anyDifficulty_radioButton = new System.Windows.Forms.RadioButton();
            this.panel5 = new System.Windows.Forms.Panel();
            this.categories_ComboBox = new System.Windows.Forms.ComboBox();
            this.cATEGORIESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vocLearningDataSet = new KsenesGlosses.VocLearningDataSet();
            this.categoryAny_radioButton = new System.Windows.Forms.RadioButton();
            this.categoryChoose_RadioButton = new System.Windows.Forms.RadioButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.knowEnglish_RadioButton = new System.Windows.Forms.RadioButton();
            this.knowGreek_radioButton = new System.Windows.Forms.RadioButton();
            this.knowSpanish_radioButton = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.learnEnglish_radioButton = new System.Windows.Forms.RadioButton();
            this.learnSpanish_radioButton = new System.Windows.Forms.RadioButton();
            this.learnGreek_radioButton = new System.Windows.Forms.RadioButton();
            this.numberOfQuestions_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.difficultyTo_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.difficultyFrom_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.typeOfTest_comboBox = new System.Windows.Forms.ComboBox();
            this.takeTest_Button = new System.Windows.Forms.Button();
            this.Border = new System.Windows.Forms.Panel();
            this.Minimize = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.Close = new System.Windows.Forms.PictureBox();
            this.cATEGORIESTableAdapter = new KsenesGlosses.VocLearningDataSetTableAdapters.CATEGORIESTableAdapter();
            this.panel1.SuspendLayout();
            this.MainPanel.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cATEGORIESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vocLearningDataSet)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfQuestions_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.difficultyTo_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.difficultyFrom_numericUpDown)).BeginInit();
            this.Border.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Close)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.Logout_button);
            this.panel1.Controls.Add(this.Music);
            this.panel1.Controls.Add(this.admin_Button);
            this.panel1.Controls.Add(this.User_Settings);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(166, 633);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::KsenesGlosses.Properties.Resources.search;
            this.button1.Location = new System.Drawing.Point(3, 185);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 79);
            this.button1.TabIndex = 4;
            this.button1.Text = "Search";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Logout_button
            // 
            this.Logout_button.FlatAppearance.BorderSize = 0;
            this.Logout_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Logout_button.Font = new System.Drawing.Font("Century Gothic", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Logout_button.ForeColor = System.Drawing.Color.Red;
            this.Logout_button.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Logout_button.Location = new System.Drawing.Point(0, 556);
            this.Logout_button.Name = "Logout_button";
            this.Logout_button.Size = new System.Drawing.Size(166, 74);
            this.Logout_button.TabIndex = 3;
            this.Logout_button.Text = "Logout";
            this.Logout_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Logout_button.UseVisualStyleBackColor = true;
            this.Logout_button.Click += new System.EventHandler(this.Logout_button_Click);
            // 
            // Music
            // 
            this.Music.FlatAppearance.BorderSize = 0;
            this.Music.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Music.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Music.ForeColor = System.Drawing.Color.White;
            this.Music.Image = global::KsenesGlosses.Properties.Resources.volume_off_indicator;
            this.Music.Location = new System.Drawing.Point(0, 481);
            this.Music.Name = "Music";
            this.Music.Size = new System.Drawing.Size(166, 79);
            this.Music.TabIndex = 3;
            this.Music.Text = "Mute";
            this.Music.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Music.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Music.UseVisualStyleBackColor = true;
            this.Music.Click += new System.EventHandler(this.Music_Click);
            // 
            // admin_Button
            // 
            this.admin_Button.FlatAppearance.BorderSize = 0;
            this.admin_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.admin_Button.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_Button.ForeColor = System.Drawing.Color.White;
            this.admin_Button.Image = ((System.Drawing.Image)(resources.GetObject("admin_Button.Image")));
            this.admin_Button.Location = new System.Drawing.Point(3, 260);
            this.admin_Button.Name = "admin_Button";
            this.admin_Button.Size = new System.Drawing.Size(163, 79);
            this.admin_Button.TabIndex = 3;
            this.admin_Button.Text = "Admin";
            this.admin_Button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.admin_Button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.admin_Button.UseVisualStyleBackColor = true;
            this.admin_Button.Click += new System.EventHandler(this.button3_Click);
            // 
            // User_Settings
            // 
            this.User_Settings.FlatAppearance.BorderSize = 0;
            this.User_Settings.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.User_Settings.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.User_Settings.ForeColor = System.Drawing.Color.White;
            this.User_Settings.Image = ((System.Drawing.Image)(resources.GetObject("User_Settings.Image")));
            this.User_Settings.Location = new System.Drawing.Point(3, 107);
            this.User_Settings.Name = "User_Settings";
            this.User_Settings.Size = new System.Drawing.Size(163, 79);
            this.User_Settings.TabIndex = 3;
            this.User_Settings.Text = "Profile";
            this.User_Settings.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.User_Settings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.User_Settings.UseVisualStyleBackColor = true;
            this.User_Settings.Click += new System.EventHandler(this.User_Settings_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(3, 31);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(163, 79);
            this.button2.TabIndex = 2;
            this.button2.Text = "Home";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // MainPanel
            // 
            this.MainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MainPanel.Controls.Add(this.testErrors_label);
            this.MainPanel.Controls.Add(this.panel6);
            this.MainPanel.Controls.Add(this.panel5);
            this.MainPanel.Controls.Add(this.panel4);
            this.MainPanel.Controls.Add(this.panel2);
            this.MainPanel.Controls.Add(this.numberOfQuestions_numericUpDown);
            this.MainPanel.Controls.Add(this.label9);
            this.MainPanel.Controls.Add(this.difficultyTo_numericUpDown);
            this.MainPanel.Controls.Add(this.label8);
            this.MainPanel.Controls.Add(this.label7);
            this.MainPanel.Controls.Add(this.difficultyFrom_numericUpDown);
            this.MainPanel.Controls.Add(this.label6);
            this.MainPanel.Controls.Add(this.label5);
            this.MainPanel.Controls.Add(this.label4);
            this.MainPanel.Controls.Add(this.label3);
            this.MainPanel.Controls.Add(this.label1);
            this.MainPanel.Controls.Add(this.typeOfTest_comboBox);
            this.MainPanel.Controls.Add(this.takeTest_Button);
            this.MainPanel.ForeColor = System.Drawing.Color.Black;
            this.MainPanel.Location = new System.Drawing.Point(169, 31);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1030, 602);
            this.MainPanel.TabIndex = 5;
            // 
            // testErrors_label
            // 
            this.testErrors_label.AutoSize = true;
            this.testErrors_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.testErrors_label.ForeColor = System.Drawing.Color.Firebrick;
            this.testErrors_label.Location = new System.Drawing.Point(219, 302);
            this.testErrors_label.Name = "testErrors_label";
            this.testErrors_label.Size = new System.Drawing.Size(92, 15);
            this.testErrors_label.TabIndex = 40;
            this.testErrors_label.Text = "Choose options";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.chooseDifficulty_radioButton);
            this.panel6.Controls.Add(this.anyDifficulty_radioButton);
            this.panel6.Location = new System.Drawing.Point(413, 169);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(203, 16);
            this.panel6.TabIndex = 39;
            // 
            // chooseDifficulty_radioButton
            // 
            this.chooseDifficulty_radioButton.AutoSize = true;
            this.chooseDifficulty_radioButton.Font = new System.Drawing.Font("Century Gothic", 8.2F);
            this.chooseDifficulty_radioButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.chooseDifficulty_radioButton.Location = new System.Drawing.Point(51, -4);
            this.chooseDifficulty_radioButton.Name = "chooseDifficulty_radioButton";
            this.chooseDifficulty_radioButton.Size = new System.Drawing.Size(114, 20);
            this.chooseDifficulty_radioButton.TabIndex = 30;
            this.chooseDifficulty_radioButton.TabStop = true;
            this.chooseDifficulty_radioButton.Text = "Choose Difficulty";
            this.chooseDifficulty_radioButton.UseVisualStyleBackColor = true;
            this.chooseDifficulty_radioButton.CheckedChanged += new System.EventHandler(this.chooseDifficulty_CheckedChanged);
            // 
            // anyDifficulty_radioButton
            // 
            this.anyDifficulty_radioButton.AutoSize = true;
            this.anyDifficulty_radioButton.Font = new System.Drawing.Font("Century Gothic", 8.2F);
            this.anyDifficulty_radioButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.anyDifficulty_radioButton.Location = new System.Drawing.Point(1, -4);
            this.anyDifficulty_radioButton.Name = "anyDifficulty_radioButton";
            this.anyDifficulty_radioButton.Size = new System.Drawing.Size(46, 20);
            this.anyDifficulty_radioButton.TabIndex = 28;
            this.anyDifficulty_radioButton.TabStop = true;
            this.anyDifficulty_radioButton.Text = "Any";
            this.anyDifficulty_radioButton.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.categories_ComboBox);
            this.panel5.Controls.Add(this.categoryAny_radioButton);
            this.panel5.Controls.Add(this.categoryChoose_RadioButton);
            this.panel5.Location = new System.Drawing.Point(413, 85);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(309, 61);
            this.panel5.TabIndex = 38;
            // 
            // categories_ComboBox
            // 
            this.categories_ComboBox.DataSource = this.cATEGORIESBindingSource;
            this.categories_ComboBox.DisplayMember = "Category";
            this.categories_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categories_ComboBox.Enabled = false;
            this.categories_ComboBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.categories_ComboBox.Font = new System.Drawing.Font("Century Gothic", 8.2F);
            this.categories_ComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.categories_ComboBox.FormattingEnabled = true;
            this.categories_ComboBox.Location = new System.Drawing.Point(0, 21);
            this.categories_ComboBox.Name = "categories_ComboBox";
            this.categories_ComboBox.Size = new System.Drawing.Size(309, 24);
            this.categories_ComboBox.TabIndex = 26;
            this.categories_ComboBox.Tag = "";
            // 
            // cATEGORIESBindingSource
            // 
            this.cATEGORIESBindingSource.DataMember = "CATEGORIES";
            this.cATEGORIESBindingSource.DataSource = this.vocLearningDataSet;
            // 
            // vocLearningDataSet
            // 
            this.vocLearningDataSet.DataSetName = "VocLearningDataSet";
            this.vocLearningDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // categoryAny_radioButton
            // 
            this.categoryAny_radioButton.AutoSize = true;
            this.categoryAny_radioButton.Font = new System.Drawing.Font("Century Gothic", 8.2F);
            this.categoryAny_radioButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.categoryAny_radioButton.Location = new System.Drawing.Point(0, -2);
            this.categoryAny_radioButton.Name = "categoryAny_radioButton";
            this.categoryAny_radioButton.Size = new System.Drawing.Size(46, 20);
            this.categoryAny_radioButton.TabIndex = 24;
            this.categoryAny_radioButton.TabStop = true;
            this.categoryAny_radioButton.Text = "Any";
            this.categoryAny_radioButton.UseVisualStyleBackColor = true;
            // 
            // categoryChoose_RadioButton
            // 
            this.categoryChoose_RadioButton.AutoSize = true;
            this.categoryChoose_RadioButton.Font = new System.Drawing.Font("Century Gothic", 8.2F);
            this.categoryChoose_RadioButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.categoryChoose_RadioButton.Location = new System.Drawing.Point(49, -2);
            this.categoryChoose_RadioButton.Name = "categoryChoose_RadioButton";
            this.categoryChoose_RadioButton.Size = new System.Drawing.Size(124, 20);
            this.categoryChoose_RadioButton.TabIndex = 25;
            this.categoryChoose_RadioButton.TabStop = true;
            this.categoryChoose_RadioButton.Text = "Choose Category:";
            this.categoryChoose_RadioButton.UseVisualStyleBackColor = true;
            this.categoryChoose_RadioButton.CheckedChanged += new System.EventHandler(this.categoryChoose_RadioButton_CheckedChanged);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.knowEnglish_RadioButton);
            this.panel4.Controls.Add(this.knowGreek_radioButton);
            this.panel4.Controls.Add(this.knowSpanish_radioButton);
            this.panel4.Location = new System.Drawing.Point(10, 141);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(391, 93);
            this.panel4.TabIndex = 37;
            // 
            // knowEnglish_RadioButton
            // 
            this.knowEnglish_RadioButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.knowEnglish_RadioButton.AutoSize = true;
            this.knowEnglish_RadioButton.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.knowEnglish_RadioButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.knowEnglish_RadioButton.FlatAppearance.BorderSize = 2;
            this.knowEnglish_RadioButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(220)))), ((int)(((byte)(0)))));
            this.knowEnglish_RadioButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.knowEnglish_RadioButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.knowEnglish_RadioButton.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.knowEnglish_RadioButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.knowEnglish_RadioButton.Image = global::KsenesGlosses.Properties.Resources.rsz_united_kingdom_120px;
            this.knowEnglish_RadioButton.Location = new System.Drawing.Point(129, 3);
            this.knowEnglish_RadioButton.Name = "knowEnglish_RadioButton";
            this.knowEnglish_RadioButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.knowEnglish_RadioButton.Size = new System.Drawing.Size(130, 87);
            this.knowEnglish_RadioButton.TabIndex = 20;
            this.knowEnglish_RadioButton.TabStop = true;
            this.knowEnglish_RadioButton.Text = "English";
            this.knowEnglish_RadioButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.knowEnglish_RadioButton.UseVisualStyleBackColor = true;
            // 
            // knowGreek_radioButton
            // 
            this.knowGreek_radioButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.knowGreek_radioButton.AutoSize = true;
            this.knowGreek_radioButton.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.knowGreek_radioButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.knowGreek_radioButton.FlatAppearance.BorderSize = 2;
            this.knowGreek_radioButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(220)))), ((int)(((byte)(0)))));
            this.knowGreek_radioButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.knowGreek_radioButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.knowGreek_radioButton.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.knowGreek_radioButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.knowGreek_radioButton.Image = global::KsenesGlosses.Properties.Resources.rsz_greece_120px;
            this.knowGreek_radioButton.Location = new System.Drawing.Point(-3, 3);
            this.knowGreek_radioButton.Name = "knowGreek_radioButton";
            this.knowGreek_radioButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.knowGreek_radioButton.Size = new System.Drawing.Size(130, 88);
            this.knowGreek_radioButton.TabIndex = 19;
            this.knowGreek_radioButton.TabStop = true;
            this.knowGreek_radioButton.Text = "Greek";
            this.knowGreek_radioButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.knowGreek_radioButton.UseVisualStyleBackColor = true;
            // 
            // knowSpanish_radioButton
            // 
            this.knowSpanish_radioButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.knowSpanish_radioButton.AutoSize = true;
            this.knowSpanish_radioButton.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.knowSpanish_radioButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.knowSpanish_radioButton.FlatAppearance.BorderSize = 2;
            this.knowSpanish_radioButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(220)))), ((int)(((byte)(0)))));
            this.knowSpanish_radioButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.knowSpanish_radioButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.knowSpanish_radioButton.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.knowSpanish_radioButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.knowSpanish_radioButton.Image = global::KsenesGlosses.Properties.Resources.rsz_spain;
            this.knowSpanish_radioButton.Location = new System.Drawing.Point(261, 2);
            this.knowSpanish_radioButton.Name = "knowSpanish_radioButton";
            this.knowSpanish_radioButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.knowSpanish_radioButton.Size = new System.Drawing.Size(130, 86);
            this.knowSpanish_radioButton.TabIndex = 21;
            this.knowSpanish_radioButton.TabStop = true;
            this.knowSpanish_radioButton.Text = "Spanish";
            this.knowSpanish_radioButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.knowSpanish_radioButton.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.learnEnglish_radioButton);
            this.panel2.Controls.Add(this.learnSpanish_radioButton);
            this.panel2.Controls.Add(this.learnGreek_radioButton);
            this.panel2.Location = new System.Drawing.Point(3, 22);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(401, 90);
            this.panel2.TabIndex = 36;
            // 
            // learnEnglish_radioButton
            // 
            this.learnEnglish_radioButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.learnEnglish_radioButton.AutoSize = true;
            this.learnEnglish_radioButton.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.learnEnglish_radioButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.learnEnglish_radioButton.FlatAppearance.BorderSize = 2;
            this.learnEnglish_radioButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(220)))), ((int)(((byte)(0)))));
            this.learnEnglish_radioButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.learnEnglish_radioButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.learnEnglish_radioButton.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.learnEnglish_radioButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.learnEnglish_radioButton.Image = global::KsenesGlosses.Properties.Resources.rsz_united_kingdom_120px;
            this.learnEnglish_radioButton.Location = new System.Drawing.Point(136, 3);
            this.learnEnglish_radioButton.Name = "learnEnglish_radioButton";
            this.learnEnglish_radioButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.learnEnglish_radioButton.Size = new System.Drawing.Size(130, 87);
            this.learnEnglish_radioButton.TabIndex = 17;
            this.learnEnglish_radioButton.TabStop = true;
            this.learnEnglish_radioButton.Text = "English";
            this.learnEnglish_radioButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.learnEnglish_radioButton.UseVisualStyleBackColor = true;
            // 
            // learnSpanish_radioButton
            // 
            this.learnSpanish_radioButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.learnSpanish_radioButton.AutoSize = true;
            this.learnSpanish_radioButton.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.learnSpanish_radioButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.learnSpanish_radioButton.FlatAppearance.BorderSize = 2;
            this.learnSpanish_radioButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(220)))), ((int)(((byte)(0)))));
            this.learnSpanish_radioButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.learnSpanish_radioButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.learnSpanish_radioButton.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.learnSpanish_radioButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.learnSpanish_radioButton.Image = global::KsenesGlosses.Properties.Resources.rsz_spain;
            this.learnSpanish_radioButton.Location = new System.Drawing.Point(268, 2);
            this.learnSpanish_radioButton.Name = "learnSpanish_radioButton";
            this.learnSpanish_radioButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.learnSpanish_radioButton.Size = new System.Drawing.Size(130, 86);
            this.learnSpanish_radioButton.TabIndex = 18;
            this.learnSpanish_radioButton.TabStop = true;
            this.learnSpanish_radioButton.Text = "Spanish";
            this.learnSpanish_radioButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.learnSpanish_radioButton.UseVisualStyleBackColor = true;
            // 
            // learnGreek_radioButton
            // 
            this.learnGreek_radioButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.learnGreek_radioButton.AutoSize = true;
            this.learnGreek_radioButton.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.learnGreek_radioButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.learnGreek_radioButton.FlatAppearance.BorderSize = 2;
            this.learnGreek_radioButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(220)))), ((int)(((byte)(0)))));
            this.learnGreek_radioButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.learnGreek_radioButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.learnGreek_radioButton.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.learnGreek_radioButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.learnGreek_radioButton.Image = global::KsenesGlosses.Properties.Resources.rsz_greece_120px;
            this.learnGreek_radioButton.Location = new System.Drawing.Point(4, 3);
            this.learnGreek_radioButton.Name = "learnGreek_radioButton";
            this.learnGreek_radioButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.learnGreek_radioButton.Size = new System.Drawing.Size(130, 88);
            this.learnGreek_radioButton.TabIndex = 16;
            this.learnGreek_radioButton.TabStop = true;
            this.learnGreek_radioButton.Text = "Greek";
            this.learnGreek_radioButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.learnGreek_radioButton.UseVisualStyleBackColor = true;
            // 
            // numberOfQuestions_numericUpDown
            // 
            this.numberOfQuestions_numericUpDown.Font = new System.Drawing.Font("Century Gothic", 8.2F);
            this.numberOfQuestions_numericUpDown.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.numberOfQuestions_numericUpDown.Location = new System.Drawing.Point(535, 213);
            this.numberOfQuestions_numericUpDown.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numberOfQuestions_numericUpDown.Name = "numberOfQuestions_numericUpDown";
            this.numberOfQuestions_numericUpDown.Size = new System.Drawing.Size(43, 21);
            this.numberOfQuestions_numericUpDown.TabIndex = 35;
            this.numberOfQuestions_numericUpDown.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 8.2F);
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(410, 215);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 16);
            this.label9.TabIndex = 34;
            this.label9.Text = "Number of Questions";
            // 
            // difficultyTo_numericUpDown
            // 
            this.difficultyTo_numericUpDown.Enabled = false;
            this.difficultyTo_numericUpDown.Font = new System.Drawing.Font("Century Gothic", 8.2F);
            this.difficultyTo_numericUpDown.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.difficultyTo_numericUpDown.Location = new System.Drawing.Point(524, 186);
            this.difficultyTo_numericUpDown.Name = "difficultyTo_numericUpDown";
            this.difficultyTo_numericUpDown.Size = new System.Drawing.Size(43, 21);
            this.difficultyTo_numericUpDown.TabIndex = 33;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 8.2F);
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(498, 188);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 16);
            this.label8.TabIndex = 32;
            this.label8.Text = "To";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 8.2F);
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(413, 188);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 16);
            this.label7.TabIndex = 31;
            this.label7.Text = "From";
            // 
            // difficultyFrom_numericUpDown
            // 
            this.difficultyFrom_numericUpDown.Enabled = false;
            this.difficultyFrom_numericUpDown.Font = new System.Drawing.Font("Century Gothic", 8.2F);
            this.difficultyFrom_numericUpDown.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.difficultyFrom_numericUpDown.Location = new System.Drawing.Point(449, 186);
            this.difficultyFrom_numericUpDown.Name = "difficultyFrom_numericUpDown";
            this.difficultyFrom_numericUpDown.Size = new System.Drawing.Size(43, 21);
            this.difficultyFrom_numericUpDown.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 8.2F);
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(409, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 16);
            this.label6.TabIndex = 27;
            this.label6.Text = "Difficulty";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 8.2F);
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(410, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 16);
            this.label5.TabIndex = 23;
            this.label5.Text = "Category";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 8.2F);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(410, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 16);
            this.label4.TabIndex = 22;
            this.label4.Text = "Type Of Test";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 7.25F);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(7, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 15);
            this.label3.TabIndex = 15;
            this.label3.Text = "Language You Know:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 7.25F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 15);
            this.label1.TabIndex = 14;
            this.label1.Text = "Language To Learn:";
            // 
            // typeOfTest_comboBox
            // 
            this.typeOfTest_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeOfTest_comboBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.typeOfTest_comboBox.Font = new System.Drawing.Font("Century Gothic", 8.2F);
            this.typeOfTest_comboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.typeOfTest_comboBox.FormattingEnabled = true;
            this.typeOfTest_comboBox.Items.AddRange(new object[] {
            "Text Translation",
            "Reverse Text Translation",
            "Listening Translation",
            "Image Test",
            "Image Listening"});
            this.typeOfTest_comboBox.Location = new System.Drawing.Point(413, 22);
            this.typeOfTest_comboBox.Name = "typeOfTest_comboBox";
            this.typeOfTest_comboBox.Size = new System.Drawing.Size(309, 24);
            this.typeOfTest_comboBox.TabIndex = 12;
            this.typeOfTest_comboBox.Tag = "";
            // 
            // takeTest_Button
            // 
            this.takeTest_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.takeTest_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.takeTest_Button.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.takeTest_Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.takeTest_Button.Location = new System.Drawing.Point(222, 270);
            this.takeTest_Button.Name = "takeTest_Button";
            this.takeTest_Button.Size = new System.Drawing.Size(403, 29);
            this.takeTest_Button.TabIndex = 13;
            this.takeTest_Button.Text = "Take Test";
            this.takeTest_Button.UseVisualStyleBackColor = false;
            this.takeTest_Button.Click += new System.EventHandler(this.button4_Click);
            // 
            // Border
            // 
            this.Border.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(36)))), ((int)(((byte)(60)))));
            this.Border.Controls.Add(this.Minimize);
            this.Border.Controls.Add(this.pictureBox4);
            this.Border.Controls.Add(this.Close);
            this.Border.Location = new System.Drawing.Point(0, 0);
            this.Border.Name = "Border";
            this.Border.Size = new System.Drawing.Size(1199, 32);
            this.Border.TabIndex = 6;
            this.Border.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Border_MouseDown);
            this.Border.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Border_MouseMove);
            // 
            // Minimize
            // 
            this.Minimize.Image = global::KsenesGlosses.Properties.Resources.minimize;
            this.Minimize.Location = new System.Drawing.Point(1135, 0);
            this.Minimize.Name = "Minimize";
            this.Minimize.Size = new System.Drawing.Size(32, 32);
            this.Minimize.TabIndex = 0;
            this.Minimize.TabStop = false;
            this.Minimize.Click += new System.EventHandler(this.Minimize_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::KsenesGlosses.Properties.Resources.logo;
            this.pictureBox4.Location = new System.Drawing.Point(0, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(32, 32);
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;
            // 
            // Close
            // 
            this.Close.Image = global::KsenesGlosses.Properties.Resources.close;
            this.Close.Location = new System.Drawing.Point(1167, 0);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(32, 32);
            this.Close.TabIndex = 0;
            this.Close.TabStop = false;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // cATEGORIESTableAdapter
            // 
            this.cATEGORIESTableAdapter.ClearBeforeFill = true;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(1200, 633);
            this.Controls.Add(this.Border);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cATEGORIESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vocLearningDataSet)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfQuestions_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.difficultyTo_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.difficultyFrom_numericUpDown)).EndInit();
            this.Border.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Close)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button User_Settings;
        private System.Windows.Forms.Button admin_Button;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.ComboBox typeOfTest_comboBox;
        private System.Windows.Forms.Button takeTest_Button;
        private System.Windows.Forms.Panel Border;
        private System.Windows.Forms.PictureBox Minimize;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox Close;
        private System.Windows.Forms.Button Logout_button;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton learnGreek_radioButton;
        private System.Windows.Forms.NumericUpDown numberOfQuestions_numericUpDown;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown difficultyTo_numericUpDown;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton chooseDifficulty_radioButton;
        private System.Windows.Forms.NumericUpDown difficultyFrom_numericUpDown;
        private System.Windows.Forms.RadioButton anyDifficulty_radioButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox categories_ComboBox;
        private System.Windows.Forms.RadioButton categoryChoose_RadioButton;
        private System.Windows.Forms.RadioButton categoryAny_radioButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton knowSpanish_radioButton;
        private System.Windows.Forms.RadioButton knowEnglish_RadioButton;
        private System.Windows.Forms.RadioButton knowGreek_radioButton;
        private System.Windows.Forms.RadioButton learnSpanish_radioButton;
        private System.Windows.Forms.RadioButton learnEnglish_radioButton;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private VocLearningDataSet vocLearningDataSet;
        private System.Windows.Forms.BindingSource cATEGORIESBindingSource;
        private VocLearningDataSetTableAdapters.CATEGORIESTableAdapter cATEGORIESTableAdapter;
        private System.Windows.Forms.Label testErrors_label;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Music;
    }
}