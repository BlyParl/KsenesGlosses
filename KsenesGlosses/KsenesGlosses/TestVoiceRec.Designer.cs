namespace KsenesGlosses
{
    partial class TestVoiceRec
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
            this.enableVoiceButton = new System.Windows.Forms.Button();
            this.disableVoiceButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.wordLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // enableVoiceButton
            // 
            this.enableVoiceButton.Location = new System.Drawing.Point(237, 241);
            this.enableVoiceButton.Name = "enableVoiceButton";
            this.enableVoiceButton.Size = new System.Drawing.Size(75, 23);
            this.enableVoiceButton.TabIndex = 0;
            this.enableVoiceButton.Text = "Enable";
            this.enableVoiceButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.enableVoiceButton.UseVisualStyleBackColor = true;
            this.enableVoiceButton.Click += new System.EventHandler(this.enableVoiceButton_Click);
            // 
            // disableVoiceButton
            // 
            this.disableVoiceButton.Enabled = false;
            this.disableVoiceButton.Location = new System.Drawing.Point(237, 270);
            this.disableVoiceButton.Name = "disableVoiceButton";
            this.disableVoiceButton.Size = new System.Drawing.Size(75, 23);
            this.disableVoiceButton.TabIndex = 1;
            this.disableVoiceButton.Text = "Disable";
            this.disableVoiceButton.UseVisualStyleBackColor = true;
            this.disableVoiceButton.Click += new System.EventHandler(this.disableVoiceButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = " press enable and then say it to see if it is correct";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(246, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mic on/of";
            // 
            // wordLabel
            // 
            this.wordLabel.AutoSize = true;
            this.wordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wordLabel.Location = new System.Drawing.Point(62, 160);
            this.wordLabel.Name = "wordLabel";
            this.wordLabel.Size = new System.Drawing.Size(63, 25);
            this.wordLabel.TabIndex = 6;
            this.wordLabel.Text = "hello";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(208, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "say How are you after you pressed enable ";
            // 
            // TestVoiceRec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 332);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.wordLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.disableVoiceButton);
            this.Controls.Add(this.enableVoiceButton);
            this.Name = "TestVoiceRec";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TestVoiceRec";
            this.Load += new System.EventHandler(this.TestVoiceRec_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button enableVoiceButton;
        private System.Windows.Forms.Button disableVoiceButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label wordLabel;
        private System.Windows.Forms.Label label3;
    }
}