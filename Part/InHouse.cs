using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inventory_system
{
    public class InHouse : Part
    {
        //Constructors: Default | Base Part | InHouse
        public InHouse() { }
        public InHouse(int partID, string name, int inventory, decimal price, int max, int min)
        {
            PartID = partID;
            Name = name;
            Inventory = inventory;
            Price = price.ToString();
            Max = max;
            Min = min;
        }
        public InHouse(int partID, string name, int inventory, decimal price, int max, int min, int machineID)
        {
            PartID = partID;
            Name = name;
            Inventory = inventory;
            Price = price.ToString();
            Max = max;
            Min = min;
            MachineID = machineID;
        }
        
        //Fields
        private int _machineID;
        public int MachineID
        {
            get { return _machineID; }
            set { _machineID = value; }
        }
    }
}
