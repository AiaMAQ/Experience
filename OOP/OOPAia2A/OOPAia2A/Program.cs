 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPAia2A
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Console.WriteLine("Hello Mikkeli");
            ////Ask the needed information:
            //Console.Write("Enter your first name, please: ");
            //string receivedFiNa = Console.ReadLine();
            //Console.Write("Enter your family name, please: ");
            //string receivedFaNa = Console.ReadLine();
            //Console.Write("Enter your day of Birth, please: ");
            //string receivedDOB = Console.ReadLine();
            //DateTime nextDOB;
            //while(!DateTime.TryParse(receivedDOB, out nextDOB))
            //{
            //    Console.Write("Not a valid type, try again: ");
            //    receivedDOB = Console.ReadLine();
            //}
            ////Now all the info is at your disposal:
            ////Create your object:
            //Student nextStudent = new Student(receivedFiNa, receivedFaNa, nextDOB);
            ////Now that you have an overridden version of ToString():
            //Console.WriteLine(nextStudent);

            //nextStudent.CalculateAge();

            // Create an address object:
            Address adPer = new Address("Sammonkatu 10", "Mikkeli",
                "50100", "Finland");
            Address adComp = new Address("Porkkalankatu 4", "Helsinki", "00650", "Finland");
            //Create a person object:
            Person student1 = new Person("Reijo", "Vuohelainen", adPer);
            //Create a person object:
            company comp1 = new company("Advanced Software Solution", adComp);
            Console.WriteLine(student1);
            Console.WriteLine(comp1);

        }
    }
}
