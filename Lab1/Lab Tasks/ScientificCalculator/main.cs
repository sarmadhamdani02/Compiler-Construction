using System;

class ScientificCalculator
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("\nScientific Calculator");
            Console.WriteLine("Choose an operation:");
            Console.WriteLine("1. Sine");
            Console.WriteLine("2. Cosine");
            Console.WriteLine("3. Tangent");
            Console.WriteLine("4. Logarithm (Base 10)");
            Console.WriteLine("5. Natural Logarithm (Base e)");
            Console.WriteLine("6. Exit");
            
            string choice = Console.ReadLine();

            if (choice == "6")
                break;

            Console.WriteLine("Enter the number:");
            double number = Convert.ToDouble(Console.ReadLine());

            switch (choice)
            {
                case "1":
                    Console.WriteLine($"Sine({number}) = {Math.Sin(number)}");
                    break;
                case "2":
                    Console.WriteLine($"Cosine({number}) = {Math.Cos(number)}");
                    break;
                case "3":
                    Console.WriteLine($"Tangent({number}) = {Math.Tan(number)}");
                    break;
                case "4":
                    if (number > 0)
                        Console.WriteLine($"Log10({number}) = {Math.Log10(number)}");
                    else
                        Console.WriteLine("Logarithm is undefined for non-positive numbers.");
                    break;
                case "5":
                    if (number > 0)
                        Console.WriteLine($"Natural Log({number}) = {Math.Log(number)}");
                    else
                        Console.WriteLine("Natural logarithm is undefined for non-positive numbers.");
                    break;
                default:
                    Console.WriteLine("Invalid option. Please choose again.");
                    break;
            }
        }
    }
}
