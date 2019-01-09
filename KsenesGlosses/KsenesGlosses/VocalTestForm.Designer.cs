namespace KsenesGlosses
{
    partial class VocalTestForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VocalTestForm));
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.listenWord = new System.Windows.Forms.PictureBox();
            this.answerTextBox = new System.Windows.Forms.TextBox();
            this.previousButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.doneButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.listenWord)).BeginInit();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.progressBar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.progressBar1.Location = new System.Drawing.Point(177, 347);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(446, 26);
            this.progressBar1.Step = 1;
            this.progressBar1.TabIndex = 2;
            // 
            // listenWord
            // 
            this.listenWord.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("listenWord.BackgroundImage")));
            this.listenWord.Location = new System.Drawing.Point(402, 149);
            this.listenWord.Name = "listenWord";
            this.listenWord.Size = new System.Drawing.Size(64, 64);
            this.listenWord.TabIndex = 2;
            this.listenWord.TabStop = false;
            this.listenWord.Click += new System.EventHandler(this.listenWord_Click);
            // 
            // answerTextBox
            // 
            this.answerTextBox.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.answerTextBox.Location = new System.Drawing.Point(177, 169);
            this.answerTextBox.Multiline = true;
            this.answerTextBox.Name = "answerTextBox";
            this.answerTextBox.Size = new System.Drawing.Size(202, 44);
            this.answerTextBox.TabIndex = 3;
            this.answerTextBox.TextChanged += new System.EventHandler(this.answerTextBox_TextChanged);
            // 
            // previousButton
            // 
            this.previousButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.previousButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.previousButton.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.previousButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.previousButton.Location = new System.Drawing.Point(563, 281);
            this.previousButton.Name = "previousButton";
            this.previousButton.Size = new System.Drawing.Size(100, 30);
            this.previousButton.TabIndex = 5;
            this.previousButton.Text = "Previous";
            this.previousButton.UseVisualStyleBackColor = false;
            this.previousButton.Click += new System.EventHandler(this.previousButton_Click);
            // 
            // nextButton
            // 
            this.nextButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.nextButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nextButton.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.nextButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.nextButton.Location = new System.Drawing.Point(688, 281);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(100, 30);
            this.nextButton.TabIndex = 6;
            this.nextButton.Text = "Next";
            this.nextButton.UseVisualStyleBackColor = false;
            this.nextButton.Click += new System.EventHandler(this.answerButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.label1.Location = new System.Drawing.Point(177, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Write The Word";
            // 
            // doneButton
            // 
            this.doneButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.doneButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.doneButton.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.doneButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.doneButton.Location = new System.Drawing.Point(688, 347);
            this.doneButton.Name = "doneButton";
            this.doneButton.Size = new System.Drawing.Size(100, 30);
            this.doneButton.TabIndex = 12;
            this.doneButton.Text = "Done";
            this.doneButton.UseVisualStyleBackColor = false;
            this.doneButton.Click += new System.EventHandler(this.doneButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.label2.Location = new System.Drawing.Point(393, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(395, 24);
            this.label2.TabIndex = 13;
            this.label2.Text = " Press the Listen Button To hear the word";
            // 
            // VocalTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.doneButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.previousButton);
            this.Controls.Add(this.answerTextBox);
            this.Controls.Add(this.listenWord);
            this.Controls.Add(this.progressBar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VocalTestForm";
            this.Text = "VocalTestForm";
            this.Load += new System.EventHandler(this.VocalTestForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listenWord)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.PictureBox listenWord;
        private System.Windows.Forms.TextBox answerTextBox;
        private System.Windows.Forms.Button previousButton;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button doneButton;
        private System.Windows.Forms.Label label2;
    }
}