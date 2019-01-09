namespace KsenesGlosses
{
    partial class ImageTestForm
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
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.Next = new System.Windows.Forms.Button();
            this.Answer = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.doneButton = new System.Windows.Forms.Button();
            this.previousButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(146, 55);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.progressBar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.progressBar1.Location = new System.Drawing.Point(146, 377);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(446, 26);
            this.progressBar1.TabIndex = 2;
            // 
            // Next
            // 
            this.Next.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.Next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Next.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Next.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.Next.Location = new System.Drawing.Point(665, 289);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(100, 30);
            this.Next.TabIndex = 8;
            this.Next.Text = "Next";
            this.Next.UseVisualStyleBackColor = false;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // Answer
            // 
            this.Answer.Location = new System.Drawing.Point(146, 269);
            this.Answer.Multiline = true;
            this.Answer.Name = "Answer";
            this.Answer.Size = new System.Drawing.Size(214, 50);
            this.Answer.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.label2.Location = new System.Drawing.Point(116, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(485, 24);
            this.label2.TabIndex = 14;
            this.label2.Text = "Write The Word Corresponding to the Image below";
            // 
            // doneButton
            // 
            this.doneButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.doneButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.doneButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.doneButton.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.doneButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.doneButton.Location = new System.Drawing.Point(665, 351);
            this.doneButton.Name = "doneButton";
            this.doneButton.Size = new System.Drawing.Size(100, 30);
            this.doneButton.TabIndex = 15;
            this.doneButton.Text = "Done";
            this.doneButton.UseVisualStyleBackColor = false;
            // 
            // previousButton
            // 
            this.previousButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.previousButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.previousButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.previousButton.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.previousButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.previousButton.Location = new System.Drawing.Point(527, 289);
            this.previousButton.Name = "previousButton";
            this.previousButton.Size = new System.Drawing.Size(100, 30);
            this.previousButton.TabIndex = 16;
            this.previousButton.Text = "Previous";
            this.previousButton.UseVisualStyleBackColor = false;
            // 
            // ImageTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(840, 486);
            this.Controls.Add(this.previousButton);
            this.Controls.Add(this.doneButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Answer);
            this.Controls.Add(this.Next);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ImageTestForm";
            this.Text = "ImageTestForm";
            this.Load += new System.EventHandler(this.ImageTestForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button Next;
        private System.Windows.Forms.TextBox Answer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button doneButton;
        private System.Windows.Forms.Button previousButton;
    }
}