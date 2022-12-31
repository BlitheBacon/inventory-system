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
    public partial class Form_UpdatePart : Form
    {
        //Populates data for InHouse or OutSourced Parts, depending on context
        public Form_UpdatePart(InHouse inHousePart)
        {
            //Form properties
            InitializeComponent();
            this.Text = "Update In-house Part";
            textBoxPartID.Text        = inHousePart.PartID.ToString();
            textBoxPartName.Text      = inHousePart.Name;
            textBoxPartInventory.Text = inHousePart.Inventory.ToString();
            textBoxPartPrice.Text     = inHousePart.Price.Substring(1).ToString();
            textBoxPartMax.Text       = inHousePart.Max.ToString();
            textBoxPartMin.Text       = inHousePart.Min.ToString();
            textBoxPartInOut.Text     = inHousePart.MachineID.ToString();
            radioBtnInHouse.Checked = true;
        }

        public Form_UpdatePart(OutSourced outSourcedPart)
        {
            //Form properties
            InitializeComponent();
            this.Text = "Update Outsourced Part";
            textBoxPartID.Text        = outSourcedPart.PartID.ToString();
            textBoxPartName.Text      = outSourcedPart.Name;
            textBoxPartInventory.Text = outSourcedPart.Inventory.ToString();
            textBoxPartPrice.Text     = outSourcedPart.Price.Substring(1).ToString();
            textBoxPartMax.Text       = outSourcedPart.Max.ToString();
            textBoxPartMin.Text       = outSourcedPart.Min.ToString();
            textBoxPartInOut.Text     = outSourcedPart.CompanyName;
            radioBtnOutSourced.Checked = true;
        }

        private void btnPartUpdateSave_Click(object sender, EventArgs e)
        {
            //Numeric Check Variable Declarations
            int partID = int.Parse(textBoxPartID.Text);
            int min,
                max,
                inventory;
            decimal price;
            string name = textBoxPartName.Text;

            //Exception handling for numeric parsing and value comparisons
            try
            {
                min       = int.Parse(textBoxPartMin.Text);
                max       = int.Parse(textBoxPartMax.Text);
                inventory = int.Parse(textBoxPartInventory.Text);
                price     = decimal.Parse(textBoxPartPrice.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"ERROR: Ensure that the Part minimum, maximum, inventory, and price fields contain numeric values. Check {ex}.");
                return;
            }
            if (min > max)
            {
                MessageBox.Show("ERROR: Part minimum must be less than the part maximum.");
                return;
            }
            if (inventory > max || min > inventory)
            {
                MessageBox.Show("ERROR: Inventory must be between the minimum and maximum stock.");
                return;
            }

            //Part creation determined by radio button context
            if (radioBtnInHouse.Checked)
            {
                InHouse inHousePart = new InHouse(
                    int.Parse(textBoxPartID.Text),
                    textBoxPartName.Text,
                    int.Parse(textBoxPartInventory.Text),
                    decimal.Parse(textBoxPartPrice.Text),
                    int.Parse(textBoxPartMax.Text),
                    int.Parse(textBoxPartMin.Text),
                    int.Parse(textBoxPartInOut.Text)
                );
                Inventory.UpdatePart(partID, inHousePart);
            }
            else if (radioBtnOutSourced.Checked)
            {
                OutSourced outSourcedPart = new OutSourced(
                    int.Parse(textBoxPartID.Text),
                    textBoxPartName.Text,
                    int.Parse(textBoxPartInventory.Text),
                    decimal.Parse(textBoxPartPrice.Text),
                    int.Parse(textBoxPartMax.Text),
                    int.Parse(textBoxPartMin.Text),
                    textBoxPartInOut.Text
                );
                Inventory.UpdatePart(partID, outSourcedPart);
            }
            this.Close();
        }

        //Changing the label of the InOut textbox determined by radio button context
        private void radioBtnPartAddIn_Changed(object sender, EventArgs e)
        {
            labelPartInOut.Text = "Machine ID";
        }

        private void radioBtnPartAddOut_Changed(object sender, EventArgs e)
        {
            labelPartInOut.Text = "Company Name";
        }

        private void btnPartAddCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
