namespace inventory_system
{
    partial class Main
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
            this.dgvParts = new System.Windows.Forms.DataGridView();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.labelDGVParts = new System.Windows.Forms.Label();
            this.labelDGVProducts = new System.Windows.Forms.Label();
            this.btnPartAdd = new System.Windows.Forms.Button();
            this.btnPartUpdate = new System.Windows.Forms.Button();
            this.btnPartRemove = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnProductAdd = new System.Windows.Forms.Button();
            this.btnProductUpdate = new System.Windows.Forms.Button();
            this.btnProductRemove = new System.Windows.Forms.Button();
            this.textboxMainPartSearch = new System.Windows.Forms.TextBox();
            this.textboxMainProductSearch = new System.Windows.Forms.TextBox();
            this.btnMainPartSearch = new System.Windows.Forms.Button();
            this.btnMainProductSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvParts
            // 
            this.dgvParts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvParts.Location = new System.Drawing.Point(137, 64);
            this.dgvParts.Name = "dgvParts";
            this.dgvParts.RowHeadersWidth = 30;
            this.dgvParts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvParts.Size = new System.Drawing.Size(456, 499);
            this.dgvParts.TabIndex = 0;
            // 
            // dgvProducts
            // 
            this.dgvProducts.AllowUserToAddRows = false;
            this.dgvProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Location = new System.Drawing.Point(724, 65);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProducts.Size = new System.Drawing.Size(456, 499);
            this.dgvProducts.TabIndex = 1;
            // 
            // labelDGVParts
            // 
            this.labelDGVParts.AutoSize = true;
            this.labelDGVParts.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDGVParts.Location = new System.Drawing.Point(133, 40);
            this.labelDGVParts.Name = "labelDGVParts";
            this.labelDGVParts.Size = new System.Drawing.Size(52, 23);
            this.labelDGVParts.TabIndex = 2;
            this.labelDGVParts.Text = "Parts";
            // 
            // labelDGVProducts
            // 
            this.labelDGVProducts.AutoSize = true;
            this.labelDGVProducts.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDGVProducts.Location = new System.Drawing.Point(720, 39);
            this.labelDGVProducts.Name = "labelDGVProducts";
            this.labelDGVProducts.Size = new System.Drawing.Size(84, 23);
            this.labelDGVProducts.TabIndex = 3;
            this.labelDGVProducts.Text = "Products";
            // 
            // btnPartAdd
            // 
            this.btnPartAdd.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPartAdd.Location = new System.Drawing.Point(31, 65);
            this.btnPartAdd.Name = "btnPartAdd";
            this.btnPartAdd.Size = new System.Drawing.Size(100, 30);
            this.btnPartAdd.TabIndex = 4;
            this.btnPartAdd.Text = "Add";
            this.btnPartAdd.UseVisualStyleBackColor = true;
            this.btnPartAdd.Click += new System.EventHandler(this.btnPartAdd_Click);
            // 
            // btnPartUpdate
            // 
            this.btnPartUpdate.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPartUpdate.Location = new System.Drawing.Point(31, 123);
            this.btnPartUpdate.Name = "btnPartUpdate";
            this.btnPartUpdate.Size = new System.Drawing.Size(100, 30);
            this.btnPartUpdate.TabIndex = 5;
            this.btnPartUpdate.Text = "Update";
            this.btnPartUpdate.UseVisualStyleBackColor = true;
            this.btnPartUpdate.Click += new System.EventHandler(this.btnPartUpdate_Clicked);
            // 
            // btnPartRemove
            // 
            this.btnPartRemove.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPartRemove.Location = new System.Drawing.Point(31, 186);
            this.btnPartRemove.Name = "btnPartRemove";
            this.btnPartRemove.Size = new System.Drawing.Size(100, 30);
            this.btnPartRemove.TabIndex = 6;
            this.btnPartRemove.Text = "Remove";
            this.btnPartRemove.UseVisualStyleBackColor = true;
            this.btnPartRemove.Click += new System.EventHandler(this.btnPartRemove_Clicked);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(12, 534);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 30);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Clicked);
            // 
            // btnProductAdd
            // 
            this.btnProductAdd.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductAdd.Location = new System.Drawing.Point(618, 65);
            this.btnProductAdd.Name = "btnProductAdd";
            this.btnProductAdd.Size = new System.Drawing.Size(100, 30);
            this.btnProductAdd.TabIndex = 8;
            this.btnProductAdd.Text = "Add";
            this.btnProductAdd.UseVisualStyleBackColor = true;
            this.btnProductAdd.Click += new System.EventHandler(this.btnProductAdd_Click);
            // 
            // btnProductUpdate
            // 
            this.btnProductUpdate.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductUpdate.Location = new System.Drawing.Point(618, 123);
            this.btnProductUpdate.Name = "btnProductUpdate";
            this.btnProductUpdate.Size = new System.Drawing.Size(100, 30);
            this.btnProductUpdate.TabIndex = 9;
            this.btnProductUpdate.Text = "Update";
            this.btnProductUpdate.UseVisualStyleBackColor = true;
            this.btnProductUpdate.Click += new System.EventHandler(this.btnProductUpdate_Click);
            // 
            // btnProductRemove
            // 
            this.btnProductRemove.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductRemove.Location = new System.Drawing.Point(618, 186);
            this.btnProductRemove.Name = "btnProductRemove";
            this.btnProductRemove.Size = new System.Drawing.Size(100, 30);
            this.btnProductRemove.TabIndex = 10;
            this.btnProductRemove.Text = "Remove";
            this.btnProductRemove.UseVisualStyleBackColor = true;
            this.btnProductRemove.Click += new System.EventHandler(this.btnProductRemove_Click);
            // 
            // textboxMainPartSearch
            // 
            this.textboxMainPartSearch.Location = new System.Drawing.Point(237, 43);
            this.textboxMainPartSearch.Name = "textboxMainPartSearch";
            this.textboxMainPartSearch.Size = new System.Drawing.Size(283, 20);
            this.textboxMainPartSearch.TabIndex = 11;
            // 
            // textboxMainProductSearch
            // 
            this.textboxMainProductSearch.Location = new System.Drawing.Point(824, 44);
            this.textboxMainProductSearch.Name = "textboxMainProductSearch";
            this.textboxMainProductSearch.Size = new System.Drawing.Size(283, 20);
            this.textboxMainProductSearch.TabIndex = 12;
            // 
            // btnMainPartSearch
            // 
            this.btnMainPartSearch.Location = new System.Drawing.Point(519, 42);
            this.btnMainPartSearch.Name = "btnMainPartSearch";
            this.btnMainPartSearch.Size = new System.Drawing.Size(75, 22);
            this.btnMainPartSearch.TabIndex = 13;
            this.btnMainPartSearch.Text = "Search";
            this.btnMainPartSearch.UseVisualStyleBackColor = true;
            this.btnMainPartSearch.Click += new System.EventHandler(this.btnMainPartSearch_Click);
            // 
            // btnMainProductSearch
            // 
            this.btnMainProductSearch.Location = new System.Drawing.Point(1106, 43);
            this.btnMainProductSearch.Name = "btnMainProductSearch";
            this.btnMainProductSearch.Size = new System.Drawing.Size(75, 22);
            this.btnMainProductSearch.TabIndex = 14;
            this.btnMainProductSearch.Text = "Search";
            this.btnMainProductSearch.UseVisualStyleBackColor = true;
            this.btnMainProductSearch.Click += new System.EventHandler(this.btnMainProductSearch_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1197, 593);
            this.Controls.Add(this.btnMainProductSearch);
            this.Controls.Add(this.btnMainPartSearch);
            this.Controls.Add(this.textboxMainProductSearch);
            this.Controls.Add(this.textboxMainPartSearch);
            this.Controls.Add(this.btnProductRemove);
            this.Controls.Add(this.btnProductUpdate);
            this.Controls.Add(this.btnProductAdd);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnPartRemove);
            this.Controls.Add(this.btnPartUpdate);
            this.Controls.Add(this.btnPartAdd);
            this.Controls.Add(this.labelDGVProducts);
            this.Controls.Add(this.labelDGVParts);
            this.Controls.Add(this.dgvProducts);
            this.Controls.Add(this.dgvParts);
            this.Name = "Main";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvParts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvParts;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.Label labelDGVParts;
        private System.Windows.Forms.Label labelDGVProducts;
        private System.Windows.Forms.Button btnPartAdd;
        private System.Windows.Forms.Button btnPartUpdate;
        private System.Windows.Forms.Button btnPartRemove;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnProductAdd;
        private System.Windows.Forms.Button btnProductUpdate;
        private System.Windows.Forms.Button btnProductRemove;
        private System.Windows.Forms.TextBox textboxMainPartSearch;
        private System.Windows.Forms.TextBox textboxMainProductSearch;
        private System.Windows.Forms.Button btnMainPartSearch;
        private System.Windows.Forms.Button btnMainProductSearch;
    }
}

