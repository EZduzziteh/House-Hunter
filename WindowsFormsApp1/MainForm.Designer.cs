namespace WindowsFormsApp1
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("Id");
            this.btn_GetData = new System.Windows.Forms.Button();
            this.ListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btn_GetData
            // 
            this.btn_GetData.Location = new System.Drawing.Point(74, 69);
            this.btn_GetData.Name = "btn_GetData";
            this.btn_GetData.Size = new System.Drawing.Size(99, 55);
            this.btn_GetData.TabIndex = 0;
            this.btn_GetData.Text = "Get Information";
            this.btn_GetData.UseVisualStyleBackColor = true;
            this.btn_GetData.Click += new System.EventHandler(this.btn_GetData_Click);
            // 
            // ListView
            // 
            this.ListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.ListView.FullRowSelect = true;
            this.ListView.HideSelection = false;
            this.ListView.Location = new System.Drawing.Point(216, 48);
            this.ListView.Name = "ListView";
            this.ListView.Size = new System.Drawing.Size(561, 97);
            this.ListView.TabIndex = 3;
            this.ListView.UseCompatibleStateImageBehavior = false;
            this.ListView.View = System.Windows.Forms.View.Details;
            this.ListView.SelectedIndexChanged += new System.EventHandler(this.ListView_SelectedIndexChanged);
            this.ListView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ListView_MouseClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Address";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Postal Code";
            // 
            // listView1
            // 
            this.listView1.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader12,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader13,
            this.columnHeader14,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11});
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.listView1.Location = new System.Drawing.Point(18, 223);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(770, 195);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "ID";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Address";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Postal Code";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "List Date";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Listing Price";
            this.columnHeader8.Width = 77;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Bathrooms";
            this.columnHeader9.Width = 72;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Bedrooms";
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Square Feet";
            this.columnHeader11.Width = 77;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Description";
            this.columnHeader12.Width = 128;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "SellDate";
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "SellPrice";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.ListView);
            this.Controls.Add(this.btn_GetData);
            this.Name = "MainForm";
            this.Text = "House Hunter";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_GetData;
        private System.Windows.Forms.ListView ListView;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
    }
}

