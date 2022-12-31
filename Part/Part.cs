using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inventory_system
{
    public abstract class Part
    {
        //Constants
        private static readonly int _baseCount = 1000;
        public static int BaseCount 
        { 
            get { return _baseCount; }
        }

        //Fields
        //Private
        private int _partID,
                    _inventory,
                    _max,
                    _min;
        private string _name;
        private decimal _price;

        //Public
        public int PartID { get; set; }
        public int Inventory { get; set; }
        public string Name
        { 
            get { return _name; } 
            set { _name = value; } 
        }
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
    }
}
