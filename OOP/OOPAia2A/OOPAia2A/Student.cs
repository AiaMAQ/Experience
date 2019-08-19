using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPAia2A
{
    class Student
    {
        //Auto-implement properties:
        public string FirstName { get; set; }
        public string FamilyName { get; set; }
        public DateTime DateOfBirth { get; set; }

        //Consturctor:
        public Student(string nextFiNa, string nextFaNa, DateTime nextDOF)
        {
            FirstName = nextFiNa;
            FamilyName = nextFaNa;
            DateOfBirth = nextDOF;
        }
        //Overriden version of ToString():
        public override string ToString()
        {
            CultureInfo nextCulture = new CultureInfo("en-US");
            //return base.ToString();
            return "Fristname is "+ FirstName + ",Familyname is " + FamilyName +
                ",Day of Birth is " + String.Format(nextCulture, "{0:D}", DateOfBirth);
        }
        //Calculate the age
        public void CalculateAge()
        {
            //Where are you now:
            DateTime endDate = DateTime.Now;
            int Years = 0;
            //How many years?
            //Repeat until...
            while(endDate.CompareTo(DateOfBirth.AddYears(++Years))>=0)
            { }
            Years = Years - 1;
            //How many months? Exactly with the same technique as previously
            int Months = 0;
            while(endDate.CompareTo(DateOfBirth.AddYears(Years).
                AddMonths(++Months))>=0)
            { }
            Months = Months - 1;
            //Day, well eith the same way...
            int Days = 0;
            while(endDate.CompareTo(DateOfBirth.AddYears(Years).AddMonths(Months).AddDays(++Days))>=0)
            { }
            Days = Days - 1;
                        
            Console.WriteLine("OK, you are {0} years and {1} months and {2} days old!", 
                Years, Months, Days); 
        }
    }
}
