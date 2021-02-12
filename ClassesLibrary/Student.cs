using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary
{
    public class Student
    {
        //Fields
        private string _firstName;
        private string _lastName;
        private string _id;
        private float _gpa;

        //Properties
        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public float Gpa
        {
            get { return _gpa; }
            set { _gpa = value; }
        }

        //Constructors
        public Student() { }

        public Student(string firstName, string lastName, string id, float gpa)
        {
            FirstName = firstName;
            LastName = lastName;
            Id = id;
            Gpa = gpa;
        }

        //Methods
        public override string ToString()
        {
            //return base.ToString();
            return string.Format("{0}, {1}\n" +
                "Student ID: {2}\n" +
                "Current GPA: {3}\n",
                LastName, FirstName, Id, Gpa);
        }//end ToString()
    }//end class
}//end namespace
