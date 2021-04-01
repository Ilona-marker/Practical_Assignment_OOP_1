using System;
 
namespace Practical_Assignment_OOP
{
  class Ass_1_Program
  {
      static void Main(string[] args)
      {
          //Create three Officers as objects and print out information about them in the console.
          Officer officer1 = new Officer();
          Console.WriteLine($"The officer is {officer1}");
          Officer officer2 = new Officer("Stive", "Black", 3347, "West", 33 );
          Console.WriteLine($"The officer is {officer2}");
          Officer officer3 = new Officer("John", "Batler", 3348, "East", 44 );
          Console.WriteLine($"The officer is {officer3}");

          //Create a new array Distric99 with the type Officer and put all created objects of the +Officers in it
           Officer[] District99 = { officer1, officer2, officer3 };
           //Find out how many Officers are with level 1 in the Distric99
           int countOfLevelOnes = 0;
           foreach (Officer officer in District99)
           {
               if (officer.CalculateLevel() == 1)
               {
                  countOfLevelOnes++;
               }
           }
           Console.WriteLine($"Officers with level 1: {countOfLevelOnes}");
            //Find out how many Officers are with the level which is larger than 1 in the Distric99.
            int countOfHigherLevels = District99.Length - countOfLevelOnes;
            Console.WriteLine($"Officers with the level which is larger than 1: {countOfHigherLevels}");
            //Find out if there is any Officer with the name “John”.
            bool foundJohn = false;
            foreach (Officer officer in District99)
            {
              if (officer.GetName().Equals("John"))
               {
               foundJohn = true; 
               break;
               }
             }
             Console.WriteLine(foundJohn ? "Found John" : "Did not find John.");  
      }
  }
}