namespace inventory_system.Forms
{
    partial class Form_UpdateProduct
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
            this.textBoxUpdateProductID = new System.Windows.Forms.TextBox();
            this.textBoxUpdateProductName = new System.Windows.Forms.TextBox();
            this.textBoxUpdateProductPrice = new System.Windows.Forms.TextBox();
            this.textBoxUpdateProductInventory = new System.Windows.Forms.TextBox();
            this.textBoxUpdateProductMax = new System.Windows.Forms.TextBox();
            this.dgvProductAssociatedParts = new System.Windows.Forms.DataGridView();
            this.btnProductSave = new System.Windows.Forms.Button();
            this.btn_ProductCancel = new System.Windows.Forms.Button();
            this.textBoxUpdateProductMin = new System.Windows.Forms.TextBox();
            this.labelProductID = new System.Windows.Forms.Label();
            this.labelProductName = new System.Windows.Forms.Label();
            this.labelProductPrice = new System.Windows.Forms.Label();
            this.labelProductInventory = new System.Windows.Forms.Label();
            this.labelProductMax = new System.Windows.Forms.Label();
            this.labelProductMin = new System.Windows.Forms.Label();
            this.labelDGVProductsAssociatedParts = new System.Windows.Forms.Label();
            this.dgvProductAvailableParts = new System.Windows.Forms.DataGridView();
            this.textBoxSearchAvailableParts = new System.Windows.Forms.TextBox();
            this.btnSearchAvailableParts = new System.Windows.Forms.Button();
            this.labelDGVProductsAvailableParts = new System.Windows.Forms.Label();
            this.btnProductAddPart = new System.Windows.Forms.Button();
            this.btnProductRemovePart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductAssociatedParts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductAvailableParts)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxUpdateProductID
            // 
            this.textBoxUpdateProductID.Location = new System.Drawing.Point(36, 61);
            this.textBoxUpdateProductID.Name = "textBoxUpdateProductID";
            this.textBoxUpdateProductID.Size = new System.Drawing.Size(100, 20);
            this.textBoxUpdateProductID.TabIndex = 0;
            // 
            // textBoxUpdateProductName
            // 
            this.textBoxUpdateProductName.Location = new System.Drawing.Point(36, 110);
            this.textBoxUpdateProductName.Name = "textBoxUpdateProductName";
            this.textBoxUpdateProductName.Size = new System.Drawing.Size(100, 20);
            this.textBoxUpdateProductName.TabIndex = 1;
            // 
            // textBoxUpdateProductPrice
            // 
            this.textBoxUpdateProductPrice.Location = new System.Drawing.Point(36, 160);
            this.textBoxUpdateProductPrice.Name = "textBoxUpdateProductPrice";
            this.textBoxUpdateProductPrice.Size = new System.Drawing.Size(100, 20);
            this.textBoxUpdateProductPrice.TabIndex = 2;
            // 
            // textBoxUpdateProductInventory
            // 
            this.textBoxUpdateProductInventory.Location = new System.Drawing.Point(36, 206);
            this.textBoxUpdateProductInventory.Name = "textBoxUpdateProductInventory";
            this.textBoxUpdateProductInventory.Size = new System.Drawing.Size(100, 20);
            this.textBoxUpdateProductInventory.TabIndex = 3;
            // 
            // textBoxUpdateProductMax
            // 
            this.textBoxUpdateProductMax.Location = new System.Drawing.Point(36, 256);
            this.textBoxUpdateProductMax.Name = "textBoxUpdateProductMax";
            this.textBoxUpdateProductMax.Size = new System.Drawing.Size(100, 20);
            this.textBoxUpdateProductMax.TabIndex = 4;
            // 
            // dgvProductAssociatedParts
            // 
            this.dgvProductAssociatedParts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProductAssociatedParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductAssociatedParts.Location = new System.Drawing.Point(177, 61);
            this.dgvProductAssociatedParts.Name = "dgvProductAssociatedParts";
            this.dgvProductAssociatedParts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductAssociatedParts.Size = new System.Drawing.Size(382, 362);
            this.dgvProductAssociatedParts.TabIndex = 5;
            // 
            // btnProductSave
            // 
            this.btnProductSave.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductSave.Location = new System.Drawing.Point(36, 357);
            this.btnProductSave.Name = "btnProductSave";
            this.btnProductSave.Size = new System.Drawing.Size(100, 30);
            this.btnProductSave.TabIndex = 6;
            this.btnProductSave.Text = "Save";
            this.btnProductSave.UseVisualStyleBackColor = true;
            this.btnProductSave.Click += new System.EventHandler(this.btnProductSave_Click);
            // 
            // btn_ProductCancel
            // 
            this.btn_ProductCancel.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ProductCancel.Location = new System.Drawing.Point(36, 393);
            this.btn_ProductCancel.Name = "btn_ProductCancel";
            this.btn_ProductCancel.Size = new System.Drawing.Size(100, 30);
            this.btn_ProductCancel.TabIndex = 7;
            this.btn_ProductCancel.Text = "Cancel";
            this.btn_ProductCancel.UseVisualStyleBackColor = true;
            this.btn_ProductCancel.Click += new System.EventHandler(this.btn_ProductCancel_Click);
            // 
            // textBoxUpdateProductMin
            // 
            this.textBoxUpdateProductMin.Location = new System.Drawing.Point(36, 304);
            this.textBoxUpdateProductMin.Name = "textBoxUpdateProductMin";
            this.textBoxUpdateProductMin.Size = new System.Drawing.Size(100, 20);
            this.textBoxUpdateProductMin.TabIndex = 8;
            // 
            // labelProductID
            // 
            this.labelProductID.AutoSize = true;
            this.labelProductID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProductID.Location = new System.Drawing.Point(33, 45);
            this.labelProductID.Name = "labelProductID";
            this.labelProductID.Size = new System.Drawing.Size(64, 15);
            this.labelProductID.TabIndex = 9;
            this.labelProductID.Text = "Product ID";
            // 
            // labelProductName
            // 
            this.labelProductName.AutoSize = true;
            this.labelProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProductName.Location = new System.Drawing.Point(33, 94);
            this.labelProductName.Name = "labelProductName";
            this.labelProductName.Size = new System.Drawing.Size(41, 15);
            this.labelProductName.TabIndex = 10;
            this.labelProductName.Text = "Name";
            // 
            // labelProductPrice
            // 
            this.labelProductPrice.AutoSize = true;
            this.labelProductPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProductPrice.Location = new System.Drawing.Point(33, 144);
            this.labelProductPrice.Name = "labelProductPrice";
            this.labelProductPrice.Size = new System.Drawing.Size(35, 15);
            this.labelProductPrice.TabIndex = 11;
            this.labelProductPrice.Text = "Price";
            // 
            // labelProductInventory
            // 
            this.labelProductInventory.AutoSize = true;
            this.labelProductInventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProductInventory.Location = new System.Drawing.Point(33, 190);
            this.labelProductInventory.Name = "labelProductInventory";
            this.labelProductInventory.Size = new System.Drawing.Size(55, 15);
            this.labelProductInventory.TabIndex = 12;
            this.labelProductInventory.Text = "Inventory";
            // 
            // labelProductMax
            // 
            this.labelProductMax.AutoSize = true;
            this.labelProductMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProductMax.Location = new System.Drawing.Point(33, 240);
            this.labelProductMax.Name = "labelProductMax";
            this.labelProductMax.Size = new System.Drawing.Size(31, 15);
            this.labelProductMax.TabIndex = 13;
            this.labelProductMax.Text = "Max";
            // 
            // labelProductMin
            // 
            this.labelProductMin.AutoSize = true;
            this.labelProductMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProductMin.Location = new System.Drawing.Point(33, 288);
            this.labelProductMin.Name = "labelProductMin";
            this.labelProductMin.Size = new System.Drawing.Size(28, 15);
            this.labelProductMin.TabIndex = 14;
            this.labelProductMin.Text = "Min";
            // 
            // labelDGVProductsAssociatedParts
            // 
            this.labelDGVProductsAssociatedParts.AutoSize = true;
            this.labelDGVProductsAssociatedParts.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDGVProductsAssociatedParts.Location = new System.Drawing.Point(173, 38);
            this.labelDGVProductsAssociatedParts.Name = "labelDGVProductsAssociatedParts";
            this.labelDGVProductsAssociatedParts.Size = new System.Drawing.Size(146, 23);
            this.labelDGVProductsAssociatedParts.TabIndex = 15;
            this.labelDGVProductsAssociatedParts.Text = "Associated Parts";
            // 
            // dgvProductAvailableParts
            // 
            this.dgvProductAvailableParts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProductAvailableParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductAvailableParts.Location = new System.Drawing.Point(663, 61);
            this.dgvProductAvailableParts.Name = "dgvProductAvailableParts";
            this.dgvProductAvailableParts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductAvailableParts.Size = new System.Drawing.Size(387, 362);
            this.dgvProductAvailableParts.TabIndex = 16;
            // 
            // textBoxSearchAvailableParts
            // 
            this.textBoxSearchAvailableParts.Location = new System.Drawing.Point(790, 39);
            this.textBoxSearchAvailableParts.Name = "textBoxSearchAvailableParts";
            this.textBoxSearchAvailableParts.Size = new System.Drawing.Size(186, 20);
            this.textBoxSearchAvailableParts.TabIndex = 17;
            // 
            // btnSearchAvailableParts
            // 
            this.btnSearchAvailableParts.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchAvailableParts.Location = new System.Drawing.Point(975, 38);
            this.btnSearchAvailableParts.Name = "btnSearchAvailableParts";
            this.btnSearchAvailableParts.Size = new System.Drawing.Size(75, 22);
            this.btnSearchAvailableParts.TabIndex = 18;
            this.btnSearchAvailableParts.Text = "Search";
            this.btnSearchAvailableParts.UseVisualStyleBackColor = true;
            this.btnSearchAvailableParts.Click += new System.EventHandler(this.btnSearchAvailableParts_Click);
            // 
            // labelDGVProductsAvailableParts
            // 
            this.labelDGVProductsAvailableParts.AutoSize = true;
            this.labelDGVProductsAvailableParts.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDGVProductsAvailableParts.Location = new System.Drawing.Point(659, 37);
            this.labelDGVProductsAvailableParts.Name = "labelDGVProductsAvailableParts";
            this.labelDGVProductsAvailableParts.Size = new System.Drawing.Size(131, 23);
            this.labelDGVProductsAvailableParts.TabIndex = 19;
            this.labelDGVProductsAvailableParts.Text = "Available Parts";
            // 
            // btnProductAddPart
            // 
            this.btnProductAddPart.Location = new System.Drawing.Point(573, 132);
            this.btnProductAddPart.Name = "btnProductAddPart";
            this.btnProductAddPart.Size = new System.Drawing.Size(75, 40);
            this.btnProductAddPart.TabIndex = 20;
            this.btnProductAddPart.Text = "Add Part";
            this.btnProductAddPart.UseVisualStyleBackColor = true;
            this.btnProductAddPart.Click += new System.EventHandler(this.btnProductAddPart_Click);
            // 
            // btnProductRemovePart
            // 
            this.btnProductRemovePart.Location = new System.Drawing.Point(573, 276);
            this.btnProductRemovePart.Name = "btnProductRemovePart";
            this.btnProductRemovePart.Size = new System.Drawing.Size(75, 40);
            this.btnProductRemovePart.TabIndex = 21;
            this.btnProductRemovePart.Text = "Remove Part";
            this.btnProductRemovePart.UseVisualStyleBackColor = true;
            this.btnProductRemovePart.Click += new System.EventHandler(this.btnProductRemovePart_Click);
            // 
            // Form_UpdateProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 454);
            this.Controls.Add(this.btnProductRemovePart);
            this.Controls.Add(this.btnProductAddPart);
            this.Controls.Add(this.labelDGVProductsAvailableParts);
            this.Controls.Add(this.btnSearchAvailableParts);
            this.Controls.Add(this.textBoxSearchAvailableParts);
            this.Controls.Add(this.dgvProductAvailableParts);
            this.Controls.Add(this.labelDGVProductsAssociatedParts);
            this.Controls.Add(this.labelProductMin);
            this.Controls.Add(this.labelProductMax);
            this.Controls.Add(this.labelProductInventory);
            this.Controls.Add(this.labelProductPrice);
            this.Controls.Add(this.labelProductName);
            this.Controls.Add(this.labelProductID);
            this.Controls.Add(this.textBoxUpdateProductMin);
            this.Controls.Add(this.btn_ProductCancel);
            this.Controls.Add(this.btnProductSave);
            this.Controls.Add(this.dgvProductAssociatedParts);
            this.Controls.Add(this.textBoxUpdateProductMax);
            this.Controls.Add(this.textBoxUpdateProductInventory);
            this.Controls.Add(this.textBoxUpdateProductPrice);
            this.Controls.Add(this.textBoxUpdateProductName);
            this.Controls.Add(this.textBoxUpdateProductID);
            this.Name = "Form_UpdateProduct";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductAssociatedParts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductAvailableParts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxUpdateProductID;
        private System.Windows.Forms.TextBox textBoxUpdateProductName;
        private System.Windows.Forms.TextBox textBoxUpdateProductPrice;
        private System.Windows.Forms.TextBox textBoxUpdateProductInventory;
        private System.Windows.Forms.TextBox textBoxUpdateProductMax;
        private System.Windows.Forms.DataGridView dgvProductAssociatedParts;
        private System.Windows.Forms.Button btnProductSave;
        private System.Windows.Forms.Button btn_ProductCancel;
        private System.Windows.Forms.TextBox textBoxUpdateProductMin;
        private System.Windows.Forms.Label labelProductID;
        private System.Windows.Forms.Label labelProductName;
        private System.Windows.Forms.Label labelProductPrice;
        private System.Windows.Forms.Label labelProductInventory;
        private System.Windows.Forms.Label labelProductMax;
        private System.Windows.Forms.Label labelProductMin;
        private System.Windows.Forms.Label labelDGVProductsAssociatedParts;
        private System.Windows.Forms.DataGridView dgvProductAvailableParts;
        private System.Windows.Forms.TextBox textBoxSearchAvailableParts;
        private System.Windows.Forms.Button btnSearchAvailableParts;
        private System.Windows.Forms.Label labelDGVProductsAvailableParts;
        private System.Windows.Forms.Button btnProductAddPart;
        private System.Windows.Forms.Button btnProductRemovePart;
    }
}