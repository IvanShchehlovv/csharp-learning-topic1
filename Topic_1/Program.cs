namespace Topic_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // The first-kevek tasks //

            // Task 1
            var name = "Ivan";
            int age = 20;
            double hight = 191.5;
            float weight = 83.5f;
            bool isStudent = true;
            char firstLetterName = 'I';

            Console.WriteLine($"Name: {name}, age: {age}, hight: {hight}, weight: {weight}," +
                $" is a Student? : {isStudent}, the first letter of my name: {firstLetterName}");

            // Task 2
            int a = 10;
            int b = 3;

            Console.Write($"\nSumm = {a + b}, difference = {a - b} or {b - a}," +
                $" quotient = {(a / b)}, remainder = {a % b}\n");

            // Task 3
            double price = 19.99;
            int quantity = 3;

            Console.WriteLine($"\nTotal cost = {price * quantity}");

            // Task 4

            string city = "Lublin";

            Console.WriteLine($"\nMy name is {name}, I am {age} years old and I live in {city}.");


            // The second-kevek tasks //

            // Task 5
            double TemperatureConverter(double c)
            {
                return c * 9 / 5 + 32;
            }

            Console.Write("\n\tEnter the temperature in Celsius: ");

            if (!double.TryParse(Console.ReadLine(), out double celsius))
            {
                Console.WriteLine("\tYou have entered an incorrect value");
            }
            else
            {
                Console.WriteLine($"\tYour temperature in Fahrenheit: {TemperatureConverter(celsius)}");
            }

            // Task 6

            Console.Write("\n\tPlease enter your age: ");
            if (int.TryParse(Console.ReadLine(), out int userAge))
            {
                Console.WriteLine($"\tYou are {userAge} years old  ^^");
            }
            else
            {
                Console.WriteLine("\tInvalid age");
            }


            // Task 7

            Console.Write("\n\tPlease enter your hourly rate: ");
            if (decimal.TryParse(Console.ReadLine(), out decimal hourlyRate))
            {
                Console.Write("\tPlease enter the number of hours worked: ");
                if (decimal.TryParse(Console.ReadLine(), out decimal hoursWorked))
                {
                    Console.WriteLine($"\tYour salary = {hourlyRate * hoursWorked}   >:) ");
                }
                else
                {
                    Console.WriteLine("\tInvalid number");
                }
            }
            else
            {
                Console.WriteLine("\tInvalid number");
            }




            
        }
    }
}
