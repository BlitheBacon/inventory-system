using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inventory_system.Forms
{
    public partial class Form_UpdateProduct : Form
    {
        //Instantiating the associated part list loaded with Product supplied data
        BindingList<Part> associatedPartList = new BindingList<Part>();

        public Form_UpdateProduct(Product product)
        {
            //Form Properties
            InitializeComponent();
            this.Text = "Update Product";

            //Populate text fields with Products current values
            textBoxUpdateProductID.Text        = product.ProductID.ToString();
            textBoxUpdateProductName.Text      = product.Name;
            textBoxUpdateProductPrice.Text     = product.Price.Substring(1).ToString();
            textBoxUpdateProductInventory.Text = product.Inventory.ToString();
            textBoxUpdateProductMax.Text       = product.Max.ToString();
            textBoxUpdateProductMin.Text       = product.Min.ToString();

            //Creating the data sources for the form grids
            var availableParts = new BindingSource();
            availableParts.DataSource = Inventory.parts;
            dgvProductAvailableParts.DataSource = availableParts;

            foreach (Part associatedPart in product.AssociatedParts)
            {
                associatedPartList.Add(associatedPart);
            }

            var associatedParts = new BindingSource();
            associatedParts.DataSource = associatedPartList;
            dgvProductAssociatedParts.DataSource = associatedParts;
        }

        //Associated Part Functions
        private void btnProductAddPart_Click(object sender, EventArgs e)
        {
            //Checks for valid rows within the grid
            if (dgvProductAvailableParts.CurrentRow == null)
            {
                MessageBox.Show("Please select a row to update.");
                return;
            }
            else if (dgvProductAvailableParts.RowCount == 0)
            {
                MessageBox.Show("Part database is empty. Please add products before attempting to update them.");
                return;
            }
            else
            {
                bool exists = false;
                Part availablePart = (Part)dgvProductAvailableParts.CurrentRow.DataBoundItem;

                foreach (DataGridViewRow row in dgvProductAssociatedParts.Rows)
                {
                    if (row.DataBoundItem == availablePart)
                    {
                        exists = true;
                    }
                }

                if (!exists)
                {
                    associatedPartList.Add(availablePart);
                }
                else
                {
                    MessageBox.Show($"Part {availablePart.PartID} already associated with Product.");
                }
            }
        }

        private void btnProductRemovePart_Click(object sender, EventArgs e)
        {
            //Checks for valid rows within the grid
            if (dgvProductAssociatedParts.CurrentRow == null)
            {
                MessageBox.Show("Associated Part database is empty.");
                return;
            }
            else
            {
                DialogResult result = MessageBox.Show("Are you sure you want to remove the associated part?",
                                                      "Confirm", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in dgvProductAssociatedParts.SelectedRows)
                    {
                        dgvProductAssociatedParts.Rows.RemoveAt(row.Index);
                    }
                }
                else
                {
                    return;
                }
            }
        }

        //Product Functions
        private void btnSearchAvailableParts_Click(object sender, EventArgs e)
        {
            int partID = int.Parse(textBoxSearchAvailableParts.Text);
            Part partIDMatch = Inventory.LookupPart(partID);

            foreach (DataGridViewRow row in dgvProductAvailableParts.Rows)
            {
                Part part = (Part)row.DataBoundItem;
                if (part.PartID == partIDMatch.PartID)
                {
                    row.Selected = true;
                    dgvProductAvailableParts.CurrentCell = row.Cells[0];
                    break;
                }
                else
                {
                    row.Selected = false;
                }
            }
        }

        private void btnProductSave_Click(object sender, EventArgs e)
        {
            //Numeric Check Variable Declarations
            int min,
                max,
                inventory;
            decimal price;

            //Exception handling for numeric parsing and value comparisons
            try
            {
                min = int.Parse(textBoxUpdateProductMin.Text);
                max = int.Parse(textBoxUpdateProductMax.Text);
                inventory = int.Parse(textBoxUpdateProductInventory.Text);
                price = decimal.Parse(textBoxUpdateProductPrice.Text);
            }
            catch
            {
                MessageBox.Show("ERROR: Ensure that the Product minimum, maximum, inventory, and price fields contain numeric values.");
                return;
            }
            if (min > max)
            {
                MessageBox.Show("ERROR: Product minimum must be less than the part maximum.");
                return;
            }
            if (inventory > max || min > inventory)
            {
                MessageBox.Show("ERROR: Inventory must be between the minimum and maximum stock.");
                return;
            }
            int productID = int.Parse(textBoxUpdateProductID.Text);
            string productName = textBoxUpdateProductName.Text;
            Product product = new Product(
                productID,
                productName,
                inventory,
                price,
                max,
                min
            );
            Inventory.UpdateProduct(productID, product);
            this.Close();
        }

        private void btn_ProductCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
