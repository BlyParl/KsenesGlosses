namespace KsenesGlosses.AdminMenu
{
    partial class AdminMenu
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
            this.Edit_RadioButton = new System.Windows.Forms.RadioButton();
            this.Add_RadioButton = new System.Windows.Forms.RadioButton();
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
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.Add_RadioButton);
            this.splitContainer1.Panel1.Controls.Add(this.Edit_RadioButton);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 45;
            this.splitContainer1.TabIndex = 0;
            // 
            // Edit_RadioButton
            // 
            this.Edit_RadioButton.AutoSize = true;
            this.Edit_RadioButton.Checked = true;
            this.Edit_RadioButton.Location = new System.Drawing.Point(13, 13);
            this.Edit_RadioButton.Name = "Edit_RadioButton";
            this.Edit_RadioButton.Size = new System.Drawing.Size(43, 17);
            this.Edit_RadioButton.TabIndex = 0;
            this.Edit_RadioButton.TabStop = true;
            this.Edit_RadioButton.Text = "Edit";
            this.Edit_RadioButton.UseVisualStyleBackColor = true;
            this.Edit_RadioButton.CheckedChanged += new System.EventHandler(this.Edit_RadioButton_CheckedChanged);
            // 
            // Add_RadioButton
            // 
            this.Add_RadioButton.AutoSize = true;
            this.Add_RadioButton.Location = new System.Drawing.Point(62, 13);
            this.Add_RadioButton.Name = "Add_RadioButton";
            this.Add_RadioButton.Size = new System.Drawing.Size(44, 17);
            this.Add_RadioButton.TabIndex = 1;
            this.Add_RadioButton.TabStop = true;
            this.Add_RadioButton.Text = "Add";
            this.Add_RadioButton.UseVisualStyleBackColor = true;
            // 
            // AdminMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminMenu";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.RadioButton Add_RadioButton;
        private System.Windows.Forms.RadioButton Edit_RadioButton;
    }
}