namespace PresentationLayer
{
    partial class MapListForm
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("Default");
            this.lstMaps = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnChooseMap = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstMaps
            // 
            this.lstMaps.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.lstMaps.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstMaps.FullRowSelect = true;
            this.lstMaps.GridLines = true;
            this.lstMaps.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lstMaps.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lstMaps.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.lstMaps.Location = new System.Drawing.Point(33, 28);
            this.lstMaps.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstMaps.Name = "lstMaps";
            this.lstMaps.Size = new System.Drawing.Size(468, 291);
            this.lstMaps.TabIndex = 0;
            this.lstMaps.UseCompatibleStateImageBehavior = false;
            this.lstMaps.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Map Name";
            this.columnHeader1.Width = 324;
            // 
            // btnChooseMap
            // 
            this.btnChooseMap.Location = new System.Drawing.Point(33, 346);
            this.btnChooseMap.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnChooseMap.Name = "btnChooseMap";
            this.btnChooseMap.Size = new System.Drawing.Size(204, 68);
            this.btnChooseMap.TabIndex = 1;
            this.btnChooseMap.Text = "Choose Map";
            this.btnChooseMap.UseVisualStyleBackColor = true;
            this.btnChooseMap.Click += new System.EventHandler(this.btnChooseMap_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(292, 346);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(211, 68);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // MapListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 442);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnChooseMap);
            this.Controls.Add(this.lstMaps);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MapListForm";
            this.Text = "Choose a Map";
            this.Load += new System.EventHandler(this.MapListForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lstMaps;
        private System.Windows.Forms.Button btnChooseMap;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}