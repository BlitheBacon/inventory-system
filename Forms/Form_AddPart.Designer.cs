namespace inventory_system
{
    partial class Form_AddPart
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
            this.radioBtnInHouse = new System.Windows.Forms.RadioButton();
            this.radioBtnOutSourced = new System.Windows.Forms.RadioButton();
            this.textBoxPartID = new System.Windows.Forms.TextBox();
            this.textBoxPartName = new System.Windows.Forms.TextBox();
            this.textBoxPartPrice = new System.Windows.Forms.TextBox();
            this.textBoxPartMax = new System.Windows.Forms.TextBox();
            this.textBoxPartMin = new System.Windows.Forms.TextBox();
            this.textBoxPartInOut = new System.Windows.Forms.TextBox();
            this.textBoxPartInventory = new System.Windows.Forms.TextBox();
            this.labelPartID = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelPartPrice = new System.Windows.Forms.Label();
            this.labelPartMax = new System.Windows.Forms.Label();
            this.labelPartMin = new System.Windows.Forms.Label();
            this.labelPartInOut = new System.Windows.Forms.Label();
            this.labelPartInventory = new System.Windows.Forms.Label();
            this.btnPartAddSave = new System.Windows.Forms.Button();
            this.btnPartAddCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // radioBtnInHouse
            // 
            this.radioBtnInHouse.AutoSize = true;
            this.radioBtnInHouse.Location = new System.Drawing.Point(177, 40);
            this.radioBtnInHouse.Name = "radioBtnInHouse";
            this.radioBtnInHouse.Size = new System.Drawing.Size(68, 17);
            this.radioBtnInHouse.TabIndex = 0;
            this.radioBtnInHouse.TabStop = true;
            this.radioBtnInHouse.Text = "In-House";
            this.radioBtnInHouse.UseVisualStyleBackColor = true;
            this.radioBtnInHouse.CheckedChanged += new System.EventHandler(this.radioBtnPartAddIn_Changed);
            // 
            // radioBtnOutSourced
            // 
            this.radioBtnOutSourced.AutoSize = true;
            this.radioBtnOutSourced.Location = new System.Drawing.Point(177, 75);
            this.radioBtnOutSourced.Name = "radioBtnOutSourced";
            this.radioBtnOutSourced.Size = new System.Drawing.Size(85, 17);
            this.radioBtnOutSourced.TabIndex = 1;
            this.radioBtnOutSourced.TabStop = true;
            this.radioBtnOutSourced.Text = "Out-Sourced";
            this.radioBtnOutSourced.UseVisualStyleBackColor = true;
            this.radioBtnOutSourced.CheckedChanged += new System.EventHandler(this.radioBtnPartAddOut_Changed);
            // 
            // textBoxPartID
            // 
            this.textBoxPartID.Enabled = false;
            this.textBoxPartID.Location = new System.Drawing.Point(30, 40);
            this.textBoxPartID.Name = "textBoxPartID";
            this.textBoxPartID.ReadOnly = true;
            this.textBoxPartID.Size = new System.Drawing.Size(100, 20);
            this.textBoxPartID.TabIndex = 2;
            // 
            // textBoxPartName
            // 
            this.textBoxPartName.Location = new System.Drawing.Point(30, 85);
            this.textBoxPartName.Name = "textBoxPartName";
            this.textBoxPartName.Size = new System.Drawing.Size(100, 20);
            this.textBoxPartName.TabIndex = 3;
            // 
            // textBoxPartPrice
            // 
            this.textBoxPartPrice.Location = new System.Drawing.Point(30, 130);
            this.textBoxPartPrice.Name = "textBoxPartPrice";
            this.textBoxPartPrice.Size = new System.Drawing.Size(100, 20);
            this.textBoxPartPrice.TabIndex = 4;
            // 
            // textBoxPartMax
            // 
            this.textBoxPartMax.Location = new System.Drawing.Point(30, 173);
            this.textBoxPartMax.Name = "textBoxPartMax";
            this.textBoxPartMax.Size = new System.Drawing.Size(100, 20);
            this.textBoxPartMax.TabIndex = 5;
            // 
            // textBoxPartMin
            // 
            this.textBoxPartMin.Location = new System.Drawing.Point(30, 218);
            this.textBoxPartMin.Name = "textBoxPartMin";
            this.textBoxPartMin.Size = new System.Drawing.Size(100, 20);
            this.textBoxPartMin.TabIndex = 6;
            // 
            // textBoxPartInOut
            // 
            this.textBoxPartInOut.Location = new System.Drawing.Point(177, 130);
            this.textBoxPartInOut.Name = "textBoxPartInOut";
            this.textBoxPartInOut.Size = new System.Drawing.Size(100, 20);
            this.textBoxPartInOut.TabIndex = 7;
            // 
            // textBoxPartInventory
            // 
            this.textBoxPartInventory.Location = new System.Drawing.Point(177, 175);
            this.textBoxPartInventory.Name = "textBoxPartInventory";
            this.textBoxPartInventory.Size = new System.Drawing.Size(100, 20);
            this.textBoxPartInventory.TabIndex = 8;
            // 
            // labelPartID
            // 
            this.labelPartID.AutoSize = true;
            this.labelPartID.Location = new System.Drawing.Point(27, 24);
            this.labelPartID.Name = "labelPartID";
            this.labelPartID.Size = new System.Drawing.Size(40, 13);
            this.labelPartID.TabIndex = 9;
            this.labelPartID.Text = "Part ID";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(30, 69);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 13);
            this.labelName.TabIndex = 10;
            this.labelName.Text = "Name";
            // 
            // labelPartPrice
            // 
            this.labelPartPrice.AutoSize = true;
            this.labelPartPrice.Location = new System.Drawing.Point(30, 112);
            this.labelPartPrice.Name = "labelPartPrice";
            this.labelPartPrice.Size = new System.Drawing.Size(31, 13);
            this.labelPartPrice.TabIndex = 11;
            this.labelPartPrice.Text = "Price";
            // 
            // labelPartMax
            // 
            this.labelPartMax.AutoSize = true;
            this.labelPartMax.Location = new System.Drawing.Point(30, 157);
            this.labelPartMax.Name = "labelPartMax";
            this.labelPartMax.Size = new System.Drawing.Size(27, 13);
            this.labelPartMax.TabIndex = 12;
            this.labelPartMax.Text = "Max";
            // 
            // labelPartMin
            // 
            this.labelPartMin.AutoSize = true;
            this.labelPartMin.Location = new System.Drawing.Point(30, 200);
            this.labelPartMin.Name = "labelPartMin";
            this.labelPartMin.Size = new System.Drawing.Size(24, 13);
            this.labelPartMin.TabIndex = 13;
            this.labelPartMin.Text = "Min";
            // 
            // labelPartInOut
            // 
            this.labelPartInOut.AutoSize = true;
            this.labelPartInOut.Location = new System.Drawing.Point(177, 112);
            this.labelPartInOut.Name = "labelPartInOut";
            this.labelPartInOut.Size = new System.Drawing.Size(0, 13);
            this.labelPartInOut.TabIndex = 14;
            // 
            // labelPartInventory
            // 
            this.labelPartInventory.AutoSize = true;
            this.labelPartInventory.Location = new System.Drawing.Point(177, 157);
            this.labelPartInventory.Name = "labelPartInventory";
            this.labelPartInventory.Size = new System.Drawing.Size(51, 13);
            this.labelPartInventory.TabIndex = 15;
            this.labelPartInventory.Text = "Inventory";
            // 
            // btnPartAddSave
            // 
            this.btnPartAddSave.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPartAddSave.Location = new System.Drawing.Point(30, 270);
            this.btnPartAddSave.Name = "btnPartAddSave";
            this.btnPartAddSave.Size = new System.Drawing.Size(100, 30);
            this.btnPartAddSave.TabIndex = 16;
            this.btnPartAddSave.Text = "Save";
            this.btnPartAddSave.UseVisualStyleBackColor = true;
            this.btnPartAddSave.Click += new System.EventHandler(this.btnPartAddSave_Click);
            // 
            // btnPartAddCancel
            // 
            this.btnPartAddCancel.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPartAddCancel.Location = new System.Drawing.Point(177, 270);
            this.btnPartAddCancel.Name = "btnPartAddCancel";
            this.btnPartAddCancel.Size = new System.Drawing.Size(100, 30);
            this.btnPartAddCancel.TabIndex = 17;
            this.btnPartAddCancel.Text = "Cancel";
            this.btnPartAddCancel.UseVisualStyleBackColor = true;
            this.btnPartAddCancel.Click += new System.EventHandler(this.btnPartAddCancel_Click);
            // 
            // Form_AddPart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 323);
            this.Controls.Add(this.btnPartAddCancel);
            this.Controls.Add(this.btnPartAddSave);
            this.Controls.Add(this.labelPartInventory);
            this.Controls.Add(this.labelPartInOut);
            this.Controls.Add(this.labelPartMin);
            this.Controls.Add(this.labelPartMax);
            this.Controls.Add(this.labelPartPrice);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelPartID);
            this.Controls.Add(this.textBoxPartInventory);
            this.Controls.Add(this.textBoxPartInOut);
            this.Controls.Add(this.textBoxPartMin);
            this.Controls.Add(this.textBoxPartMax);
            this.Controls.Add(this.textBoxPartPrice);
            this.Controls.Add(this.textBoxPartName);
            this.Controls.Add(this.textBoxPartID);
            this.Controls.Add(this.radioBtnOutSourced);
            this.Controls.Add(this.radioBtnInHouse);
            this.Name = "Form_AddPart";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioBtnInHouse;
        private System.Windows.Forms.RadioButton radioBtnOutSourced;
        private System.Windows.Forms.TextBox textBoxPartID;
        private System.Windows.Forms.TextBox textBoxPartName;
        private System.Windows.Forms.TextBox textBoxPartPrice;
        private System.Windows.Forms.TextBox textBoxPartMax;
        private System.Windows.Forms.TextBox textBoxPartMin;
        private System.Windows.Forms.TextBox textBoxPartInOut;
        private System.Windows.Forms.TextBox textBoxPartInventory;
        private System.Windows.Forms.Label labelPartID;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelPartPrice;
        private System.Windows.Forms.Label labelPartMax;
        private System.Windows.Forms.Label labelPartMin;
        private System.Windows.Forms.Label labelPartInOut;
        private System.Windows.Forms.Label labelPartInventory;
        private System.Windows.Forms.Button btnPartAddSave;
        private System.Windows.Forms.Button btnPartAddCancel;
    }
}