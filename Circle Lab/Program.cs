using System;

namespace Circle_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Circle Calculator");
            int i = 0;
            while(true)
            {
                double circleRadius = ValidRadius();
                Circle myCircle = new Circle(circleRadius);

                myCircle.Circum = myCircle.CalculateCircumference();
                Console.WriteLine(myCircle.CalculateFormattedCircumference());
                
                myCircle.Area = myCircle.CalculateArea();
                Console.WriteLine(myCircle.CalculateFormattedArea());

                i++;


            if(!KeepGoin())
                {

                    break;
                }
            }

            Console.WriteLine($"Good bye! You created {i} Circle objects");
        }



        public static double ValidRadius()
        {
            
            double result = 0;
            while (true)
            {
                Console.WriteLine("Please enter a radius");
                string s = Console.ReadLine();
                bool isValid = double.TryParse(s, out result);

                if (isValid == true)
                {
                    
                    break;

                }

                else
                {
                    Console.WriteLine("Please enter a valid number");

                }

            }

            return result;


        }









        public static bool KeepGoin()
        {
            bool keepGoing = true;
            bool validInput = false;
            while(validInput == false)
            {   
                Console.WriteLine("Would you like to enter another radius? Y / N");
                string response = Console.ReadLine().ToLower();
                if(response == "y")
                {

                    keepGoing = true;
                    validInput = true;
                }

                else if(response == "n")
                {
                    
                   keepGoing = false;
                    validInput = true;
                }
                else
                {
                    Console.WriteLine("That was not a valid input. Please enter Y or N");
                }

            }
            return keepGoing;



        }
    }
}
