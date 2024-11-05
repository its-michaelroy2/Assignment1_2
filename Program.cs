namespace Assignment1_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Assignment 1.2.1
            Console.Title = "Assignment 1.2.1";

            Console.WriteLine("##################\n Assignment 1.2.1\n##################\n");
            Console.WriteLine("This program is designed to ask you for two numbers that it will compare. Please follow the instructions");

            Console.WriteLine();

            Console.WriteLine("Input 1st number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Input 2nd number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();

            if (num1 == num2)
            {
                Console.WriteLine($"{num1} and {num2} are equal");
            }
            else
            {
                Console.WriteLine($"{num1} and {num2} are not equal");
            }
            Console.WriteLine();

            Console.WriteLine("Press any key to continue");
            
            Console.ReadKey(intercept: true);

            //Assignment 1.2.2
            Console.Title = "Assignment 1.2.2";

            Console.WriteLine();

            Console.WriteLine("##################\n Assignment 1.2.2\n##################\n");
            Console.WriteLine("This program will add the natural numbers from 1-10 using a For loop and provide the summation at the end.");
           
            Console.WriteLine();

            int sum = 0;
            for (int i = 1; i <= 10; i++) {
                sum += i;
                Console.WriteLine($"i is {i} and sum is currently {sum}");
            }

            Console.WriteLine();


            //Assignment 1.2.3
            bool isRunning = true;
            do
            {
                Console.Title = "Assignment 1.2.3";

                Console.WriteLine();

                Console.WriteLine("##################\n Assignment 1.2.3\n##################\n");
                Console.WriteLine("This program is designed to act as a calculator. Please select from the menu options below for the operator you desire to use. It will then ask for the two numbers you desire to use. Please follow the instructions");

                Console.WriteLine();

                Console.WriteLine("1. Addition");
                Console.WriteLine("2. Subtraction");
                Console.WriteLine("3. Multiplication");
                Console.WriteLine("4. Division");
                Console.WriteLine("5. EXIT");

                Console.WriteLine();

                Console.WriteLine("Please select a menu option above & press ENTER: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine();
                Console.WriteLine();

                switch (choice)
                {
                    //Addition
                    case 1:
                        Console.WriteLine("Input 1st number & press ENTER: ");
                        double num3 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine();
                        Console.WriteLine("Input 2nd number & press ENTER: ");
                        double num4 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine();
                        Console.WriteLine($"The sum of {num3} and {num4} is {num3 + num4}");
                        break;
                    //Subtraction
                    case 2:
                        Console.WriteLine("Input 1st number & press ENTER: ");
                        double num5 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine();
                        Console.WriteLine("Input 2nd number & press ENTER: ");
                        double num6 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine();
                        Console.WriteLine($"The difference of {num5} and {num6} is {num5 - num6}");
                        break;
                    //Multiplication
                    case 3:
                        Console.WriteLine("Input 1st number & press ENTER: ");
                        double num7 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine();
                        Console.WriteLine("Input 2nd number & press ENTER: ");
                        double num8 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine();
                        Console.WriteLine($"The product of {num7} and {num8} is {num7 * num8}");
                        break;
                    //Division
                    case 4:
                        Console.WriteLine("Input 1st number & press ENTER: ");
                        double num9 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine();
                        Console.WriteLine("Input 2nd number & press ENTER: ");
                        double num10 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine();
                        Console.WriteLine($"The quotient of {num9} and {num10} is {num9 / num10}");
                        break;
                    //Exit
                    case 5:
                        isRunning = false;
                        Console.WriteLine("Thank you for using the calculator. Goodbye!");
                        break;
                }
            }
            while (isRunning);
            }
    }
}
