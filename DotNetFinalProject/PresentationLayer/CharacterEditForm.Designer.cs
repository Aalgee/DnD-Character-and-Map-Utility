namespace PresentationLayer
{
    partial class CharacterEditForm
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
            this.txtStatBlock = new System.Windows.Forms.TextBox();
            this.txtCharacterName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCharacterSize = new System.Windows.Forms.TextBox();
            this.txtCharacterType = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCharacterAffiliation = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCharacterAllignment = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.picCharacter = new System.Windows.Forms.PictureBox();
            this.btnChooseImage = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txtStatBlockFilename = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picCharacter)).BeginInit();
            this.SuspendLayout();
            // 
            // txtStatBlock
            // 
            this.txtStatBlock.BackColor = System.Drawing.SystemColors.Window;
            this.txtStatBlock.CausesValidation = false;
            this.txtStatBlock.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStatBlock.Location = new System.Drawing.Point(474, 87);
            this.txtStatBlock.Multiline = true;
            this.txtStatBlock.Name = "txtStatBlock";
            this.txtStatBlock.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtStatBlock.Size = new System.Drawing.Size(490, 341);
            this.txtStatBlock.TabIndex = 0;
            this.txtStatBlock.TabStop = false;
            // 
            // txtCharacterName
            // 
            this.txtCharacterName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCharacterName.Location = new System.Drawing.Point(41, 87);
            this.txtCharacterName.Name = "txtCharacterName";
            this.txtCharacterName.Size = new System.Drawing.Size(379, 24);
            this.txtCharacterName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(379, 46);
            this.label1.TabIndex = 3;
            this.label1.Text = "Character Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Size";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCharacterSize
            // 
            this.txtCharacterSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCharacterSize.Location = new System.Drawing.Point(41, 151);
            this.txtCharacterSize.Name = "txtCharacterSize";
            this.txtCharacterSize.Size = new System.Drawing.Size(189, 24);
            this.txtCharacterSize.TabIndex = 4;
            // 
            // txtCharacterType
            // 
            this.txtCharacterType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCharacterType.Location = new System.Drawing.Point(41, 208);
            this.txtCharacterType.Name = "txtCharacterType";
            this.txtCharacterType.Size = new System.Drawing.Size(189, 24);
            this.txtCharacterType.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(41, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(189, 23);
            this.label4.TabIndex = 9;
            this.label4.Text = "Allignment";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCharacterAffiliation
            // 
            this.txtCharacterAffiliation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCharacterAffiliation.Location = new System.Drawing.Point(41, 324);
            this.txtCharacterAffiliation.Name = "txtCharacterAffiliation";
            this.txtCharacterAffiliation.Size = new System.Drawing.Size(189, 24);
            this.txtCharacterAffiliation.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(42, 294);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(189, 23);
            this.label5.TabIndex = 11;
            this.label5.Text = "Affiliation";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCharacterAllignment
            // 
            this.txtCharacterAllignment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCharacterAllignment.Location = new System.Drawing.Point(41, 265);
            this.txtCharacterAllignment.Name = "txtCharacterAllignment";
            this.txtCharacterAllignment.Size = new System.Drawing.Size(189, 24);
            this.txtCharacterAllignment.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(467, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(494, 23);
            this.label6.TabIndex = 12;
            this.label6.Text = "Stat Block";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picCharacter
            // 
            this.picCharacter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picCharacter.Location = new System.Drawing.Point(253, 152);
            this.picCharacter.Name = "picCharacter";
            this.picCharacter.Size = new System.Drawing.Size(158, 139);
            this.picCharacter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCharacter.TabIndex = 13;
            this.picCharacter.TabStop = false;
            // 
            // btnChooseImage
            // 
            this.btnChooseImage.Location = new System.Drawing.Point(253, 310);
            this.btnChooseImage.Name = "btnChooseImage";
            this.btnChooseImage.Size = new System.Drawing.Size(158, 54);
            this.btnChooseImage.TabIndex = 18;
            this.btnChooseImage.Text = "Choose Image";
            this.btnChooseImage.UseVisualStyleBackColor = true;
            this.btnChooseImage.Click += new System.EventHandler(this.btnChooseImage_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(29, 438);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(169, 47);
            this.btnSave.TabIndex = 19;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(251, 438);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(169, 47);
            this.btnCancel.TabIndex = 21;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(41, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "Type";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // txtStatBlockFilename
            // 
            this.txtStatBlockFilename.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStatBlockFilename.Location = new System.Drawing.Point(471, 461);
            this.txtStatBlockFilename.Name = "txtStatBlockFilename";
            this.txtStatBlockFilename.Size = new System.Drawing.Size(490, 24);
            this.txtStatBlockFilename.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(471, 435);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(238, 23);
            this.label7.TabIndex = 23;
            this.label7.Text = "Stat Block Filename";
            // 
            // CharacterEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 514);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtStatBlockFilename);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnChooseImage);
            this.Controls.Add(this.picCharacter);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCharacterAllignment);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCharacterAffiliation);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCharacterType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCharacterSize);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCharacterName);
            this.Controls.Add(this.txtStatBlock);
            this.Name = "CharacterEditForm";
            this.Text = "Create or Edit Characters Here";
            this.Load += new System.EventHandler(this.CharacterEditForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picCharacter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtStatBlock;
        private System.Windows.Forms.TextBox txtCharacterName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCharacterSize;
        private System.Windows.Forms.TextBox txtCharacterType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCharacterAffiliation;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCharacterAllignment;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox picCharacter;
        private System.Windows.Forms.Button btnChooseImage;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox txtStatBlockFilename;
        private System.Windows.Forms.Label label7;
    }
}