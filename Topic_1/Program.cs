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

            Console.Write("\n\t Enter the temperature in Celsius: ");

            if (!double.TryParse(Console.ReadLine(), out double celsius))
            {
                Console.Write("\tYou have entered an incorrect value");
            }
            else
            {
                Console.WriteLine($"\t Your temperature in Fahrenheit: {TemperatureConverter(celsius)}");
            }


        }
    }
}
