namespace KsenesGlosses.AdminMenu
{
    partial class AdminAdd
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
            this.users_RadioButton = new System.Windows.Forms.RadioButton();
            this.words_RadioButton = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.words_RadioButton);
            this.splitContainer1.Panel1.Controls.Add(this.users_RadioButton);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 106;
            this.splitContainer1.TabIndex = 0;
            // 
            // users_RadioButton
            // 
            this.users_RadioButton.AutoSize = true;
            this.users_RadioButton.Location = new System.Drawing.Point(13, 13);
            this.users_RadioButton.Name = "users_RadioButton";
            this.users_RadioButton.Size = new System.Drawing.Size(52, 17);
            this.users_RadioButton.TabIndex = 0;
            this.users_RadioButton.Text = "Users";
            this.users_RadioButton.UseVisualStyleBackColor = true;
            this.users_RadioButton.CheckedChanged += new System.EventHandler(this.users_RadioButton_CheckedChanged);
            // 
            // words_RadioButton
            // 
            this.words_RadioButton.AutoSize = true;
            this.words_RadioButton.Location = new System.Drawing.Point(13, 36);
            this.words_RadioButton.Name = "words_RadioButton";
            this.words_RadioButton.Size = new System.Drawing.Size(56, 17);
            this.words_RadioButton.TabIndex = 1;
            this.words_RadioButton.Text = "Words";
            this.words_RadioButton.UseVisualStyleBackColor = true;
            this.words_RadioButton.CheckedChanged += new System.EventHandler(this.words_RadioButton_CheckedChanged);
            // 
            // AdminAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminAdd";
            this.Text = "AdminAdd";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.RadioButton words_RadioButton;
        private System.Windows.Forms.RadioButton users_RadioButton;
    }
}