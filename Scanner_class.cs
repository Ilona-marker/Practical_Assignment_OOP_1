/*
using System;

namespace SPractical_Assignment_OOP
{
    class Ass_1_1_Program
    {
        static void Main(string[] args)
        {     
   // Using Scanner class, ask for input of all Officer values in the console 
   //and create the new Officer in the system. Add it in the Distric99 array.
   // a. Create three Officers as objects and print out information about them in the console.
   // b. Create a new array Distric99 with the type Officer and put all created objects of the +Officers in it
  
        Officer[] District99 = new Officer[3];
        for (int i = 0; i < District99.Length; i++)
          {
            Console.Write("Enter name: ");
            string name = Console.ReadLine();
            Console.Write("Enter surname: ");
            string surname = Console.ReadLine();
            Console.Write("Enter officer ID: ");
            int officerID = Int32.Parse(Console.ReadLine());
            Console.Write("Enter working district: ");
            string workingDistrict = Console.ReadLine();
            Console.Write("Enter crimes solved: ");
            int crimesSolved = Int32.Parse(Console.ReadLine());
              if (crimesSolved < 0)
               {
                Console.WriteLine("Try again!");
                i--;
                continue;
               }
                 District99[i] = new Officer(name, surname, officerID, workingDistrict, crimesSolved);
            }
        }
    }
}   
*/