using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaration of all variables
            int num_1,num_2,option,result=0;
            
            //Choice to proceed for operations
            Console.WriteLine("Enter the option");
            Console.Write("1.\"+\"\t2.\"-\"\t3.\"x\"\t4.\"/\"\n");
            
            //Input the option to perform corresponding operation
            option = Convert.ToInt32(Console.ReadLine());
            
            //Exits if given any value else than options with a message
            if (option > 4 || option < 1)
            {
                Console.WriteLine("Invalid Option.\nPlease Enter Valid Option!...");
                System.Environment.Exit(1);
            }
            
            //Input of 1st number
            Console.Write("Enter 1st Number: ");
            num_1 = Convert.ToInt32(Console.ReadLine());
            
            //Input of 2nd number
            Console.Write("Enter 2nd Number: ");
            num_2 = Convert.ToInt32(Console.ReadLine());
            
            switch(option)
            {
                case 1 : result = num_1 + num_2;
                         break;
                
                case 2 : result = num_1 - num_2;
                         break;
                
                case 3 : result = num_1 * num_2;
                         break;
                
                case 4 : result = num_1 / num_2;
                         break;
            }
            
            //Prints the result
            Console.WriteLine($"The result is {result}");
            
            //Waits for any input before exitting console
            Console.WriteLine("Enter any key to exit console");
            Console.ReadKey();
        }
    }
}
