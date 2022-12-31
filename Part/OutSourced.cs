using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inventory_system
{
    public class OutSourced : Part
    {
        //Constructors: Default | Base Part | OutSourced
        public OutSourced() { }
        public OutSourced(int partID, string name, int inventory, decimal price, int max, int min)
        {
            PartID = partID;
            Name = name;
            Inventory = inventory;
            Price = price.ToString();
            Max = max;
            Min = min;
        }
        public OutSourced(int partID, string name, int inventory, decimal price, int max, int min, string companyName)
        {
            PartID = partID;
            Name = name;
            Inventory = inventory;
            Price = price.ToString();
            Max = max;
            Min = min;
            CompanyName = companyName;
        }
        
        //Fields
        private string _companyName;
        public string CompanyName
        {
            get { return _companyName; }
            set { _companyName = value; }
        }
    }
}
