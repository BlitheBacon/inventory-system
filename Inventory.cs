using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inventory_system
{
    internal class Inventory
    {
        //Part and product database lists
        public static BindingList<Part> parts = new BindingList<Part>();
        public static BindingList<Product> products = new BindingList<Product>();

        //Mock Data
        public static void PopulateMockData()
        {
            Part p1001 = new InHouse(1001, "p1001", 4, 18.99M, 15, 0, 7000);
            Part p1002 = new OutSourced(1002, "p1002", 6, 59.49M, 25, 1, "Dell");

            Product pr4001 = new Product(4001, "pr4001", 15, 150.99M, 100, 10);
            pr4001.AssociatedParts.Add(p1001);

            parts.Add(p1001);
            parts.Add(p1002);
            products.Add(pr4001);
        }

        //Product Functions
        public static void AddProduct(Product product)
        {
            products.Add(product);
        }
        public static bool RemoveProduct(int productToRemove)
        {
            bool removed = false;

            foreach (Product product in products)
            {
                if (product.ProductID == productToRemove)
                {
                    products.Remove(product);
                    return removed = true;
                }
                else
                {
                    MessageBox.Show($"ERROR: Failed to remove ITEM-{productToRemove} from list.");
                    return removed = false;
                }
            }
            return removed;
        }
        public static Product LookupProduct (int productIDToLookup)
        {
            foreach (Product product in products)
            {
                if (product.ProductID == productIDToLookup)
                {
                    return product;
                }
            }
            Product nullProduct = new Product();
            return nullProduct;
        }
        public static void UpdateProduct (int productIDToUpdate, Product updatedProduct)
        {
            foreach (Product selected in products)
            {
                if (selected.ProductID == productIDToUpdate)
                {
                    selected.ProductID       = updatedProduct.ProductID;
                    selected.Name            = updatedProduct.Name;
                    selected.Inventory       = updatedProduct.Inventory;
                    selected.Price           = updatedProduct.Price;
                    selected.Max             = updatedProduct.Max;
                    selected.Min             = updatedProduct.Min;
                    selected.AssociatedParts = updatedProduct.AssociatedParts;
                }
            }
        }

        //Part Functions
        public static void AddPart(Part part)
        {
            parts.Add(part);
        }
        public static bool RemovePart(int part)
        {
            Part partToRemove = LookupPart(part);
            if (partToRemove != null)
            {
                parts.Remove(partToRemove);
                return true;
            }
            else
            {
                MessageBox.Show($"ERROR: Failed to remove ITEM-{partToRemove} from list.");
                return false;
            }
        }
        public static Part LookupPart(int partID)
        {
            foreach (Part partToFind in parts)
            {
                if (partToFind.PartID == partID)
                {
                    return partToFind;
                }
            }
            //Defaults to 1st party manufacterer
            Part nullPart = new InHouse();
            return nullPart;
        }
        public static void UpdatePart(int partIDToUpdate, Part updatedPart)
        {
            /*The old part is removed after being used to update a new part
              Ensuring no duplicates. */
            RemovePart(partIDToUpdate);
            AddPart(updatedPart);
        }
    }
}
