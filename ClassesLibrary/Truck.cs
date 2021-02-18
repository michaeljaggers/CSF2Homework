using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary
{
    public class Truck : Vehicle
    {
        //Fields

        //Properties
        public float LoadCapacityLbs { get; set; }

        //Constructors
        public Truck() { }

        public Truck(string make, string model, int year, float weight, float loadCapacityLbs):base(make, model, year, weight)
        {
            LoadCapacityLbs = loadCapacityLbs;
        }

        //Methods
        public override string ToString()
        {
            return string.Format("{0}" +
                "Load Capacity: {1} lbs.", base.ToString(), LoadCapacityLbs);
        }//end ToString

    }//end class
}//end namespace
