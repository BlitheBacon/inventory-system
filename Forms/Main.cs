using inventory_system.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inventory_system
{
    internal partial class Main : Form
    {
        public Main()
        {
            //Form Properties
            InitializeComponent();
            this.Text = "Inventory System";

            //Mock Data Initialization
            Inventory.PopulateMockData();

            //Table Source Assingments
            var partsTable = new BindingSource();
            partsTable.DataSource = Inventory.parts;
            dgvParts.DataSource = partsTable;

            var productsTable = new BindingSource();
            productsTable.DataSource = Inventory.products;
            dgvProducts.DataSource = productsTable;
        }

        //Part Fuctions
        private void btnPartAdd_Click(object sender, EventArgs e)
        {
            new Form_AddPart().ShowDialog();
        }
        private void btnPartUpdate_Clicked(object sender, EventArgs e)
        {
            if (dgvParts.CurrentRow == null)
            {
                MessageBox.Show("Please select a row to update.",
                                "Confirm", MessageBoxButtons.OKCancel);
                return;
            }
            else if (dgvParts.RowCount == 0)
            {
                MessageBox.Show("Part database is empty. Please add products before attempting to update them.", 
                                "Confirm", MessageBoxButtons.OKCancel);
                return;
            }
            else
            {
                if (dgvParts.CurrentRow.DataBoundItem.GetType() == typeof(InHouse))
                {
                    InHouse selectedInHouse = (InHouse)dgvParts.CurrentRow.DataBoundItem;
                    new Form_UpdatePart(selectedInHouse).ShowDialog();
                }
                else if (dgvParts.CurrentRow.DataBoundItem.GetType() == typeof(OutSourced))
                {
                    OutSourced selectedOutSourced = (OutSourced)dgvParts.CurrentRow.DataBoundItem;
                    new Form_UpdatePart(selectedOutSourced).ShowDialog();
                }
            }
            dgvParts.Update();
            dgvParts.Refresh();
        }
        private void btnPartRemove_Clicked(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete the selected rows?",
                                                  "Confirm", MessageBoxButtons.YesNo);
            if (dgvParts.CurrentRow == null)
            {
                MessageBox.Show("Part database is empty.",
                                "Confirm", MessageBoxButtons.OKCancel);
                return;
            }
            else if (result == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in dgvParts.SelectedRows)
                {
                    dgvParts.Rows.RemoveAt(row.Index);
                }
            }
            else
            {
                return;
            }
        }
        private void btnMainPartSearch_Click(object sender, EventArgs e)
        {
            if (textboxMainPartSearch.TextLength > 0)
            {
                Part partIDMatch = Inventory.LookupPart(int.Parse(textboxMainPartSearch.Text));
                foreach (DataGridViewRow row in dgvParts.Rows)
                {
                    Part part = (Part)row.DataBoundItem;
                    if (part.PartID == partIDMatch.PartID)
                    {
                        row.Selected = true;
                        dgvParts.CurrentCell = row.Cells[0];
                        break;
                    }
                    else
                    {
                        row.Selected = false;
                    }
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid Part ID.",
                                "Confirm", MessageBoxButtons.OKCancel);
            }
        }

        //Product Functions
        private void btnProductAdd_Click(object sender, EventArgs e)
        {
            new Form_AddProduct().ShowDialog();
        }
        private void btnProductUpdate_Click(object sender, EventArgs e)
        {
            if (dgvProducts.CurrentRow == null)
            {
                MessageBox.Show("Please select a row to update.", 
                                "Confirm", MessageBoxButtons.OKCancel);
                return;
            }
            else if (dgvProducts.RowCount == 0)
            {
                MessageBox.Show("Product database is empty. Please add products before attempting to update them.", 
                                "Confirm", MessageBoxButtons.OKCancel);
                return;
            }
            else
            {
                Product selectedProduct = (Product)dgvProducts.CurrentRow.DataBoundItem;
                new Form_UpdateProduct(selectedProduct).ShowDialog();
            }
        }
        private void btnProductRemove_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete the selected products?",
                                                  "Confirm", MessageBoxButtons.YesNo);
            if (dgvProducts.CurrentRow == null)
            {
                MessageBox.Show("Product database is empty.",
                                "Confirm", MessageBoxButtons.OKCancel);
                return;
            }
            else if (result == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in dgvProducts.SelectedRows)
                {
                    Product selectedProduct = (Product)row.DataBoundItem;
                    if (selectedProduct.AssociatedParts.Count == 0)
                    {
                        dgvProducts.Rows.RemoveAt(row.Index);
                    }
                    else
                    {
                        MessageBox.Show("Products cannot be deleted until all associated parts are disassociated." +
                                        "\nPlease remove the associated parts from the product and try again.",
                                        "Confirm", MessageBoxButtons.OKCancel);
                    }
                }
            }
            else
            {
                return;
            }
        }
        private void btnMainProductSearch_Click(object sender, EventArgs e)
        {
            if (textboxMainProductSearch.TextLength > 0)
            {
                Product productIDMatch = Inventory.LookupProduct(int.Parse(textboxMainProductSearch.Text));
                foreach (DataGridViewRow row in dgvProducts.Rows)
                {
                    Product product = (Product)row.DataBoundItem;
                    if (product == null || productIDMatch == null)
                    {
                        row.Selected = false;
                        break;
                    }
                    else if (product.ProductID == productIDMatch.ProductID)
                    {
                        row.Selected = true;
                        dgvProducts.CurrentCell = row.Cells[0];
                        break;
                    }
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid Product ID.", 
                                "Confirm", MessageBoxButtons.OKCancel);
            }
        }
        private void btnExit_Clicked(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
