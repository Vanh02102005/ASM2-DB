namespace asm1_db
{
    partial class Statistics
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbQuantity = new System.Windows.Forms.TabPage();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.lbDate = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lbPrice = new System.Windows.Forms.Label();
            this.lbQuantity = new System.Windows.Forms.Label();
            this.txtBookID = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lbBookID = new System.Windows.Forms.Label();
            this.lbOrderID = new System.Windows.Forms.Label();
            this.tbSales = new System.Windows.Forms.TabPage();
            this.gvSatistics = new System.Windows.Forms.DataGridView();
            this.btnRevenue = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tbQuantity.SuspendLayout();
            this.tbSales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvSatistics)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbQuantity);
            this.tabControl1.Controls.Add(this.tbSales);
            this.tabControl1.Location = new System.Drawing.Point(0, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(805, 433);
            this.tabControl1.TabIndex = 0;
            // 
            // tbQuantity
            // 
            this.tbQuantity.Controls.Add(this.btnRevenue);
            this.tbQuantity.Controls.Add(this.txtDate);
            this.tbQuantity.Controls.Add(this.lbDate);
            this.tbQuantity.Controls.Add(this.txtPrice);
            this.tbQuantity.Controls.Add(this.txtQuantity);
            this.tbQuantity.Controls.Add(this.btnSearch);
            this.tbQuantity.Controls.Add(this.btnDelete);
            this.tbQuantity.Controls.Add(this.btnEdit);
            this.tbQuantity.Controls.Add(this.btnAdd);
            this.tbQuantity.Controls.Add(this.lbPrice);
            this.tbQuantity.Controls.Add(this.lbQuantity);
            this.tbQuantity.Controls.Add(this.txtBookID);
            this.tbQuantity.Controls.Add(this.txtID);
            this.tbQuantity.Controls.Add(this.lbBookID);
            this.tbQuantity.Controls.Add(this.lbOrderID);
            this.tbQuantity.Location = new System.Drawing.Point(4, 25);
            this.tbQuantity.Name = "tbQuantity";
            this.tbQuantity.Padding = new System.Windows.Forms.Padding(3);
            this.tbQuantity.Size = new System.Drawing.Size(797, 404);
            this.tbQuantity.TabIndex = 0;
            this.tbQuantity.Text = "Statistics";
            this.tbQuantity.UseVisualStyleBackColor = true;
            this.tbQuantity.Click += new System.EventHandler(this.tbQuantity_Click);
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(461, 64);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(100, 22);
            this.txtDate.TabIndex = 20;
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Location = new System.Drawing.Point(372, 67);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(36, 16);
            this.lbDate.TabIndex = 19;
            this.lbDate.Text = "Date";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(461, 111);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 22);
            this.txtPrice.TabIndex = 18;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(148, 158);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(100, 22);
            this.txtQuantity.TabIndex = 17;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(543, 281);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 16;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(375, 281);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(218, 281);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 14;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(66, 281);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Location = new System.Drawing.Point(372, 111);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(38, 16);
            this.lbPrice.TabIndex = 12;
            this.lbPrice.Text = "Price";
            // 
            // lbQuantity
            // 
            this.lbQuantity.AutoSize = true;
            this.lbQuantity.Location = new System.Drawing.Point(63, 164);
            this.lbQuantity.Name = "lbQuantity";
            this.lbQuantity.Size = new System.Drawing.Size(55, 16);
            this.lbQuantity.TabIndex = 11;
            this.lbQuantity.Text = "Quantity";
            // 
            // txtBookID
            // 
            this.txtBookID.Location = new System.Drawing.Point(148, 111);
            this.txtBookID.Name = "txtBookID";
            this.txtBookID.Size = new System.Drawing.Size(100, 22);
            this.txtBookID.TabIndex = 10;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(148, 67);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 22);
            this.txtID.TabIndex = 9;
            // 
            // lbBookID
            // 
            this.lbBookID.AutoSize = true;
            this.lbBookID.Location = new System.Drawing.Point(63, 111);
            this.lbBookID.Name = "lbBookID";
            this.lbBookID.Size = new System.Drawing.Size(52, 16);
            this.lbBookID.TabIndex = 5;
            this.lbBookID.Text = "BookID";
            // 
            // lbOrderID
            // 
            this.lbOrderID.AutoSize = true;
            this.lbOrderID.Location = new System.Drawing.Point(63, 67);
            this.lbOrderID.Name = "lbOrderID";
            this.lbOrderID.Size = new System.Drawing.Size(54, 16);
            this.lbOrderID.TabIndex = 4;
            this.lbOrderID.Text = "OrderID";
            // 
            // tbSales
            // 
            this.tbSales.Controls.Add(this.gvSatistics);
            this.tbSales.Location = new System.Drawing.Point(4, 25);
            this.tbSales.Name = "tbSales";
            this.tbSales.Padding = new System.Windows.Forms.Padding(3);
            this.tbSales.Size = new System.Drawing.Size(797, 404);
            this.tbSales.TabIndex = 1;
            this.tbSales.Text = "Statistics list";
            this.tbSales.UseVisualStyleBackColor = true;
            this.tbSales.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // gvSatistics
            // 
            this.gvSatistics.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvSatistics.Location = new System.Drawing.Point(8, 6);
            this.gvSatistics.Name = "gvSatistics";
            this.gvSatistics.RowHeadersWidth = 51;
            this.gvSatistics.RowTemplate.Height = 24;
            this.gvSatistics.Size = new System.Drawing.Size(771, 392);
            this.gvSatistics.TabIndex = 0;
            // 
            // btnRevenue
            // 
            this.btnRevenue.Location = new System.Drawing.Point(290, 354);
            this.btnRevenue.Name = "btnRevenue";
            this.btnRevenue.Size = new System.Drawing.Size(75, 23);
            this.btnRevenue.TabIndex = 21;
            this.btnRevenue.Text = "Revenue";
            this.btnRevenue.UseVisualStyleBackColor = true;
            this.btnRevenue.Click += new System.EventHandler(this.button1_Click);
            // 
            // Statistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Statistics";
            this.Text = "Statistics";
            this.tabControl1.ResumeLayout(false);
            this.tbQuantity.ResumeLayout(false);
            this.tbQuantity.PerformLayout();
            this.tbSales.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvSatistics)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbQuantity;
        private System.Windows.Forms.TabPage tbSales;
        private System.Windows.Forms.Label lbBookID;
        private System.Windows.Forms.Label lbOrderID;
        private System.Windows.Forms.TextBox txtBookID;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.Label lbQuantity;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.DataGridView gvSatistics;
        private System.Windows.Forms.Button btnRevenue;
    }
}