using System;

namespace WhileLoops
{
    class Program
    {
        //While loop, loops around code while a condition is true 
        static void Main(string[] args)
        {

            int index = 1; 

            while (index <=5) //<condition is true it will move to the code below 
            {
                Console.WriteLine(index); //print out index 
                index++; //increment by 1, then will check the condition and run the code again  

            }
            //BE CAREFUL for infinite loops 


            int index1 = 6;
            do
            {

                Console.WriteLine(index1);
                index1++;

            } while (index <= 5);

            // do while loop will look at code then condition so will print number 6
            Console.ReadLine();
           
        }
    }
}
