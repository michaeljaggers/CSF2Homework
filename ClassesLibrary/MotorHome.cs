using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary
{
    public class MotorHome : Vehicle
    {
        //Fields

        //Properties
        public int NumberOfBeds { get; set; }

        //Constructors
        public MotorHome() { }

        public MotorHome(string make, string model, int year, float weight, int numberOfBeds):base(make, model, year, weight)
        {
            NumberOfBeds = numberOfBeds;
        }

        //Methods
        public override string ToString()
        {
            return string.Format("{0}" +
                "Number of Beds: {1}\n",
            base.ToString(), NumberOfBeds);
        }//end ToString

    }//end class
}//and namespace
