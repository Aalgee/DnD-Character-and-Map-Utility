namespace PresentationLayer
{
    partial class CharacterStatBlockForm
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
            this.picCharacterImage = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtStatBlock = new System.Windows.Forms.TextBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnDone = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picCharacterImage)).BeginInit();
            this.SuspendLayout();
            // 
            // picCharacterImage
            // 
            this.picCharacterImage.InitialImage = null;
            this.picCharacterImage.Location = new System.Drawing.Point(59, 94);
            this.picCharacterImage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picCharacterImage.Name = "picCharacterImage";
            this.picCharacterImage.Size = new System.Drawing.Size(232, 220);
            this.picCharacterImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCharacterImage.TabIndex = 0;
            this.picCharacterImage.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Black;
            this.lblTitle.Location = new System.Drawing.Point(59, 19);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(232, 55);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Whatever";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtStatBlock
            // 
            this.txtStatBlock.BackColor = System.Drawing.SystemColors.Control;
            this.txtStatBlock.Font = new System.Drawing.Font("Lucida Console", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStatBlock.Location = new System.Drawing.Point(329, 19);
            this.txtStatBlock.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtStatBlock.Multiline = true;
            this.txtStatBlock.Name = "txtStatBlock";
            this.txtStatBlock.ReadOnly = true;
            this.txtStatBlock.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtStatBlock.ShortcutsEnabled = false;
            this.txtStatBlock.Size = new System.Drawing.Size(416, 364);
            this.txtStatBlock.TabIndex = 2;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(61, 340);
            this.btnNext.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(96, 42);
            this.btnNext.TabIndex = 3;
            this.btnNext.Text = "Next Character";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnDone
            // 
            this.btnDone.Location = new System.Drawing.Point(195, 340);
            this.btnDone.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(96, 42);
            this.btnDone.TabIndex = 4;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // CharacterStatBlockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 401);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.txtStatBlock);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.picCharacterImage);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "CharacterStatBlockForm";
            this.Text = "CharacterStatBlockForm";
            this.Load += new System.EventHandler(this.CharacterStatBlockForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picCharacterImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picCharacterImage;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtStatBlock;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnDone;
    }
}