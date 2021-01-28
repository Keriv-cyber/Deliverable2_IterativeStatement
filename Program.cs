using System;

namespace Deliverable2_IterativeStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            //int number;


            Console.WriteLine("Please enter an interger value between 1 and 100.");

            int number = Convert.ToInt32(Console.ReadLine());
            int count = 1;
            
            //this will be the interative statement for deliverable 2
            while (count <= number)
            {
                Console.WriteLine("You have entered " + number + ". "+ "This is the current interger value in the loop: " + number);
                count = count + 1;
            }
          
            
        }
    }
}
