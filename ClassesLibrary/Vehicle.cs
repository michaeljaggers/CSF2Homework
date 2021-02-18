using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary
{
    public class Vehicle
    {
        //Fields
        private string _make;
        private string _model;
        private int _year;
        private float _weight;

        //Properties
        public string Make
        {
            get { return _make; }
            set { _make = value; }
        }

        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }

        public int Year
        {
            get { return _year; }
            set { _year = value; }
        }

        public float Weight
        {
            get { return _weight; }
            set { _weight = value; }
        }

        //Constructors
        public Vehicle() { }

        public Vehicle(string make, string model, int year, float weight)
        {
            Make = make;
            Model = model;
            Year = year;
            Weight = weight;
        }

        //Methods
        public override string ToString()
        {
            return string.Format("Year: {0}\n" +
                "Make: {1}\n" +
                "Model: {2}\n" +
                "Weight: {3} lbs.\n",
                Year, Make, Model, Weight);
        }//end ToString
    }//end class
}//end namespace
