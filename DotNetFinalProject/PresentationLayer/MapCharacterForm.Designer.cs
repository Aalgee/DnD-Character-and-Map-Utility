namespace PresentationLayer
{
    partial class MapCharacterForm
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
            this.lstCharacterSelect = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAddCharacter = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstCharacterSelect
            // 
            this.lstCharacterSelect.AllowColumnReorder = true;
            this.lstCharacterSelect.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lstCharacterSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstCharacterSelect.FullRowSelect = true;
            this.lstCharacterSelect.GridLines = true;
            this.lstCharacterSelect.Location = new System.Drawing.Point(47, 36);
            this.lstCharacterSelect.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstCharacterSelect.Name = "lstCharacterSelect";
            this.lstCharacterSelect.Size = new System.Drawing.Size(460, 395);
            this.lstCharacterSelect.TabIndex = 0;
            this.lstCharacterSelect.UseCompatibleStateImageBehavior = false;
            this.lstCharacterSelect.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Character Name";
            this.columnHeader1.Width = 188;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Affiliation";
            this.columnHeader2.Width = 244;
            // 
            // btnAddCharacter
            // 
            this.btnAddCharacter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCharacter.Location = new System.Drawing.Point(47, 470);
            this.btnAddCharacter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddCharacter.Name = "btnAddCharacter";
            this.btnAddCharacter.Size = new System.Drawing.Size(207, 70);
            this.btnAddCharacter.TabIndex = 1;
            this.btnAddCharacter.Text = "Add Character";
            this.btnAddCharacter.UseVisualStyleBackColor = true;
            this.btnAddCharacter.Click += new System.EventHandler(this.btnAddCharacter_Click);
            // 
            // btnBack
            // 
            this.btnBack.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(301, 470);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(207, 70);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // MapCharacterForm
            // 
            this.AcceptButton = this.btnAddCharacter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnBack;
            this.ClientSize = new System.Drawing.Size(548, 571);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnAddCharacter);
            this.Controls.Add(this.lstCharacterSelect);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MapCharacterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Choose a character to add to the map";
            this.Load += new System.EventHandler(this.MapCharacterForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lstCharacterSelect;
        private System.Windows.Forms.Button btnAddCharacter;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}