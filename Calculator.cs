using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int num_1,num_2,op,result=0;
            
            Console.WriteLine("Enter the option");
            Console.Write("1.\"+\"\t2.\"-\"\t3.\"x\"\t4.\"/\"\n");
            op = Convert.ToInt32(Console.ReadLine());
            
            if (op > 4 || op < 1)
            {
                Console.WriteLine("Enter Valid Option!...");
                System.Environment.Exit(1);
            }
            
            Console.Write("Enter 1st Number: ");
            num_1 = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Enter 2nd Number: ");
            num_2 = Convert.ToInt32(Console.ReadLine());
            
            switch(op)
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
            
            Console.WriteLine("The result is {0}",result);
        }
    }
}