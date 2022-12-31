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
    public partial class Form_AddPart : Form
    {
        public Form_AddPart()
        {
            //Form properties
            InitializeComponent();
            this.Text = "Add Part";
            textBoxPartID.Text = (Part.BaseCount + Inventory.parts.Count + 1).ToString();
        }


        private void btnPartAddSave_Click(object sender, EventArgs e)
        {
            //Numeric Check Variable Declarations
            int min,
                max,
                inventory;
            decimal price;

            //Exception handling for numeric parsing and value comparisons
            try
            {
                min = int.Parse(textBoxPartMin.Text);
                max = int.Parse(textBoxPartMax.Text);
                inventory = int.Parse(textBoxPartInventory.Text);
                price = decimal.Parse(textBoxPartPrice.Text);
            }
            catch
            {
                MessageBox.Show("ERROR: Ensure that the Part minimum, maximum, inventory, and price fields contain numeric values.");
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

            //Part creation based on radio check
            if (radioBtnInHouse.Checked)
            {
                Part inHousePart = new InHouse(
                    Part.BaseCount + Inventory.parts.Count + 1,
                    textBoxPartName.Text,
                    int.Parse(textBoxPartInventory.Text),
                    decimal.Parse(textBoxPartPrice.Text),
                    int.Parse(textBoxPartMax.Text),
                    int.Parse(textBoxPartMin.Text),
                    int.Parse(textBoxPartInOut.Text)
                );
                Inventory.AddPart(inHousePart);
            }
            else if (radioBtnOutSourced.Checked)
            {
                Part outSourcedPart = new OutSourced(
                    Part.BaseCount + Inventory.parts.Count + 1,
                    textBoxPartName.Text,
                    int.Parse(textBoxPartInventory.Text),
                    decimal.Parse(textBoxPartPrice.Text),
                    int.Parse(textBoxPartMax.Text),
                    int.Parse(textBoxPartMin.Text),
                    textBoxPartInOut.Text
                );
                Inventory.AddPart(outSourcedPart);
            }
            else
            {
                this.Close();
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
