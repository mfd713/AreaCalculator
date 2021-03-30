using System;

namespace Area_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput;
            decimal length, width, overagePercent, area;

            //Get user input & set vars
            Console.Write("Enter the length of the room: ");
            userInput = Console.ReadLine();
            length = decimal.Parse(userInput);

            Console.Write("Enter the width of the room: ");
            userInput = Console.ReadLine();
            width = decimal.Parse(userInput);

            Console.Write("Enter the overage percent: ");
            userInput = Console.ReadLine();
            overagePercent = decimal.Parse(userInput) / 100; //set overage to a %

            //multiply vars
            area = length * width * (overagePercent + 1);

            //output answer
            Console.WriteLine("The total area, including overage, is " + area.ToString("F0"));
        }
    }
}
