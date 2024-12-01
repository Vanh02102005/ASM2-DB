namespace asm1_db
{
    partial class Product_Management
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
            this.tbProductManagement = new System.Windows.Forms.TabPage();
            this.txtImagePath = new System.Windows.Forms.TextBox();
            this.btnUploadImage = new System.Windows.Forms.Button();
            this.pbProductImage = new System.Windows.Forms.PictureBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtProductDescription = new System.Windows.Forms.TextBox();
            this.lbProductDescription = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtProductQuantity = new System.Windows.Forms.TextBox();
            this.txtProductPrice = new System.Windows.Forms.TextBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txtProductID = new System.Windows.Forms.TextBox();
            this.lbInventoryQuantity = new System.Windows.Forms.Label();
            this.lbSellingPrice = new System.Windows.Forms.Label();
            this.lbProductName = new System.Windows.Forms.Label();
            this.lbProductID = new System.Windows.Forms.Label();
            this.tbListofProducts = new System.Windows.Forms.TabPage();
            this.gvProduct = new System.Windows.Forms.DataGridView();
            this.lbImageLink = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tbProductManagement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProductImage)).BeginInit();
            this.tbListofProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbProductManagement);
            this.tabControl1.Controls.Add(this.tbListofProducts);
            this.tabControl1.Location = new System.Drawing.Point(-1, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1053, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // tbProductManagement
            // 
            this.tbProductManagement.Controls.Add(this.lbImageLink);
            this.tbProductManagement.Controls.Add(this.txtImagePath);
            this.tbProductManagement.Controls.Add(this.btnUploadImage);
            this.tbProductManagement.Controls.Add(this.pbProductImage);
            this.tbProductManagement.Controls.Add(this.btnSearch);
            this.tbProductManagement.Controls.Add(this.txtProductDescription);
            this.tbProductManagement.Controls.Add(this.lbProductDescription);
            this.tbProductManagement.Controls.Add(this.btnDelete);
            this.tbProductManagement.Controls.Add(this.btnEdit);
            this.tbProductManagement.Controls.Add(this.btnAdd);
            this.tbProductManagement.Controls.Add(this.txtProductQuantity);
            this.tbProductManagement.Controls.Add(this.txtProductPrice);
            this.tbProductManagement.Controls.Add(this.txtProductName);
            this.tbProductManagement.Controls.Add(this.txtProductID);
            this.tbProductManagement.Controls.Add(this.lbInventoryQuantity);
            this.tbProductManagement.Controls.Add(this.lbSellingPrice);
            this.tbProductManagement.Controls.Add(this.lbProductName);
            this.tbProductManagement.Controls.Add(this.lbProductID);
            this.tbProductManagement.Location = new System.Drawing.Point(4, 25);
            this.tbProductManagement.Name = "tbProductManagement";
            this.tbProductManagement.Padding = new System.Windows.Forms.Padding(3);
            this.tbProductManagement.Size = new System.Drawing.Size(1045, 421);
            this.tbProductManagement.TabIndex = 0;
            this.tbProductManagement.Text = "Product Management";
            this.tbProductManagement.UseVisualStyleBackColor = true;
            // 
            // txtImagePath
            // 
            this.txtImagePath.Location = new System.Drawing.Point(547, 199);
            this.txtImagePath.Name = "txtImagePath";
            this.txtImagePath.Size = new System.Drawing.Size(156, 22);
            this.txtImagePath.TabIndex = 19;
            // 
            // btnUploadImage
            // 
            this.btnUploadImage.Location = new System.Drawing.Point(386, 42);
            this.btnUploadImage.Name = "btnUploadImage";
            this.btnUploadImage.Size = new System.Drawing.Size(139, 36);
            this.btnUploadImage.TabIndex = 18;
            this.btnUploadImage.Text = "Upload Image";
            this.btnUploadImage.UseVisualStyleBackColor = true;
            this.btnUploadImage.Click += new System.EventHandler(this.btnUploadImage_Click);
            // 
            // pbProductImage
            // 
            this.pbProductImage.Location = new System.Drawing.Point(547, 42);
            this.pbProductImage.Name = "pbProductImage";
            this.pbProductImage.Size = new System.Drawing.Size(156, 126);
            this.pbProductImage.TabIndex = 17;
            this.pbProductImage.TabStop = false;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(628, 350);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 16;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtProductDescription
            // 
            this.txtProductDescription.Location = new System.Drawing.Point(161, 276);
            this.txtProductDescription.Name = "txtProductDescription";
            this.txtProductDescription.Size = new System.Drawing.Size(94, 22);
            this.txtProductDescription.TabIndex = 15;
            // 
            // lbProductDescription
            // 
            this.lbProductDescription.AutoSize = true;
            this.lbProductDescription.Location = new System.Drawing.Point(31, 276);
            this.lbProductDescription.Name = "lbProductDescription";
            this.lbProductDescription.Size = new System.Drawing.Size(124, 16);
            this.lbProductDescription.TabIndex = 14;
            this.lbProductDescription.Text = "Product Description";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(450, 351);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(82, 23);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(284, 351);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 12;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(124, 351);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtProductQuantity
            // 
            this.txtProductQuantity.Location = new System.Drawing.Point(161, 221);
            this.txtProductQuantity.Name = "txtProductQuantity";
            this.txtProductQuantity.Size = new System.Drawing.Size(94, 22);
            this.txtProductQuantity.TabIndex = 8;
            // 
            // txtProductPrice
            // 
            this.txtProductPrice.Location = new System.Drawing.Point(159, 162);
            this.txtProductPrice.Name = "txtProductPrice";
            this.txtProductPrice.Size = new System.Drawing.Size(96, 22);
            this.txtProductPrice.TabIndex = 7;
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(158, 97);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(97, 22);
            this.txtProductName.TabIndex = 6;
            // 
            // txtProductID
            // 
            this.txtProductID.Location = new System.Drawing.Point(156, 42);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.Size = new System.Drawing.Size(100, 22);
            this.txtProductID.TabIndex = 5;
            // 
            // lbInventoryQuantity
            // 
            this.lbInventoryQuantity.AutoSize = true;
            this.lbInventoryQuantity.Location = new System.Drawing.Point(31, 227);
            this.lbInventoryQuantity.Name = "lbInventoryQuantity";
            this.lbInventoryQuantity.Size = new System.Drawing.Size(115, 16);
            this.lbInventoryQuantity.TabIndex = 3;
            this.lbInventoryQuantity.Text = "Inventory  Quantity";
            // 
            // lbSellingPrice
            // 
            this.lbSellingPrice.AutoSize = true;
            this.lbSellingPrice.Location = new System.Drawing.Point(31, 165);
            this.lbSellingPrice.Name = "lbSellingPrice";
            this.lbSellingPrice.Size = new System.Drawing.Size(82, 16);
            this.lbSellingPrice.TabIndex = 2;
            this.lbSellingPrice.Text = "Selling Price";
            // 
            // lbProductName
            // 
            this.lbProductName.AutoSize = true;
            this.lbProductName.Location = new System.Drawing.Point(31, 103);
            this.lbProductName.Name = "lbProductName";
            this.lbProductName.Size = new System.Drawing.Size(93, 16);
            this.lbProductName.TabIndex = 1;
            this.lbProductName.Text = "Product Name";
            // 
            // lbProductID
            // 
            this.lbProductID.AutoSize = true;
            this.lbProductID.Location = new System.Drawing.Point(31, 42);
            this.lbProductID.Name = "lbProductID";
            this.lbProductID.Size = new System.Drawing.Size(69, 16);
            this.lbProductID.TabIndex = 0;
            this.lbProductID.Text = "Product ID";
            // 
            // tbListofProducts
            // 
            this.tbListofProducts.Controls.Add(this.gvProduct);
            this.tbListofProducts.Location = new System.Drawing.Point(4, 25);
            this.tbListofProducts.Name = "tbListofProducts";
            this.tbListofProducts.Padding = new System.Windows.Forms.Padding(3);
            this.tbListofProducts.Size = new System.Drawing.Size(1045, 421);
            this.tbListofProducts.TabIndex = 1;
            this.tbListofProducts.Text = "List of Products";
            this.tbListofProducts.UseVisualStyleBackColor = true;
            // 
            // gvProduct
            // 
            this.gvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvProduct.Location = new System.Drawing.Point(3, 3);
            this.gvProduct.Name = "gvProduct";
            this.gvProduct.RowHeadersWidth = 51;
            this.gvProduct.RowTemplate.Height = 24;
            this.gvProduct.Size = new System.Drawing.Size(1058, 466);
            this.gvProduct.TabIndex = 0;
            this.gvProduct.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvProduct_CellContentClick);
            // 
            // lbImageLink
            // 
            this.lbImageLink.AutoSize = true;
            this.lbImageLink.Location = new System.Drawing.Point(420, 205);
            this.lbImageLink.Name = "lbImageLink";
            this.lbImageLink.Size = new System.Drawing.Size(75, 16);
            this.lbImageLink.TabIndex = 20;
            this.lbImageLink.Text = "Image URL";
            // 
            // Product_Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 577);
            this.Controls.Add(this.tabControl1);
            this.Name = "Product_Management";
            this.Text = "Product";
            this.Load += new System.EventHandler(this.Product_Management_Load);
            this.tabControl1.ResumeLayout(false);
            this.tbProductManagement.ResumeLayout(false);
            this.tbProductManagement.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProductImage)).EndInit();
            this.tbListofProducts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvProduct)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbProductManagement;
        private System.Windows.Forms.TabPage tbListofProducts;
        private System.Windows.Forms.TextBox txtProductQuantity;
        private System.Windows.Forms.TextBox txtProductPrice;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.TextBox txtProductID;
        private System.Windows.Forms.Label lbInventoryQuantity;
        private System.Windows.Forms.Label lbSellingPrice;
        private System.Windows.Forms.Label lbProductName;
        private System.Windows.Forms.Label lbProductID;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView gvProduct;
        private System.Windows.Forms.TextBox txtProductDescription;
        private System.Windows.Forms.Label lbProductDescription;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnUploadImage;
        private System.Windows.Forms.PictureBox pbProductImage;
        private System.Windows.Forms.TextBox txtImagePath;
        private System.Windows.Forms.Label lbImageLink;
    }
}