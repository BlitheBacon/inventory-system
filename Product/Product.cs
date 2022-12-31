using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using inventory_system;

namespace inventory_system
{
    public class Product
    {
        //Constructors: Default | Base Product
        public Product() { }
        public Product(int productID, string name, int inventory, decimal price, int max, int min)
        {
            ProductID = productID;
            Name = name;
            Inventory = inventory;
            Price = price.ToString();
            Max = max;
            Min = min;
        }

        //Constants
        private static readonly int _baseCount = 4000;
        public static int BaseCount
        {
            get { return _baseCount; }
        }

        //Lists
        public BindingList<Part> AssociatedParts = new BindingList<Part>();

        //Fields
        //Private
        private int _productID,
                    _inventory,
                    _max,
                    _min;
        private string _name;
        private decimal _price;

        //Public
        public int ProductID { get; set; }
        public int Inventory { get; set; }
        public string Name { get; set; }
        public string Price 
        { 
            get { return _price.ToString("C"); } 
            set
            {
                if (value.StartsWith("$"))
                {
                    _price = decimal.Parse(value.Substring(1));
                }
                else
                {
                    _price = decimal.Parse(value);
                }
            }
        }
        public int Max { get; set; }
        public int Min { get; set; }
        
        //Functions
        public void AddAssociatedPart(Part part)
        {
            AssociatedParts.Add(part);
        }
        public bool RemoveAssociatedPart(int partID)
        {
            bool removed = false;

            foreach (Part partToRemove in AssociatedParts)
            {
                if (partToRemove.PartID == partID)
                {
                    AssociatedParts.Remove(partToRemove);
                    return removed = true;
                }
            }
            return removed;
        }
        public Part LookupAssociatedPart(int partID)
        {
            foreach(Part selected in AssociatedParts)
            {
                if (selected.PartID == partID)
                {
                    return selected;
                }
            }
            //Defaults to first party manufacturer
            InHouse empty = new InHouse();
            return empty;
        }
    }
}
