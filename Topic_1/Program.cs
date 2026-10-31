using System.Xml.Linq;

namespace Topic_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //           Level 1 ///////////////


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


            //           Level 3 ///////////////


            // Task 8

            decimal totalCost, numberOfPeople;

            Console.Write("\n\t\tPlease enter the total cost: ");
            decimal.TryParse(Console.ReadLine(), out totalCost);
            if ( totalCost == 0 )
                Console.WriteLine("\t\tInvalid number");
            
            Console.Write("\t\tPlease enter the number of people: ");
            decimal.TryParse(Console.ReadLine(), out numberOfPeople);
            if (numberOfPeople == 0)
                Console.WriteLine("\t\tInvalid number");
            else
                Console.WriteLine($"\t\tEach person pays: {totalCost / Math.Abs(numberOfPeople)}");


            // Task 9

            const decimal rate = 3.60m;
            decimal amountOfEuros;

            Console.Write("\n\t\tPlease enter the amount in euros: ");
            decimal.TryParse(Console.ReadLine(), out amountOfEuros);
            if (amountOfEuros == 0)
                Console.WriteLine("\t\tInvalid number");
            Console.WriteLine($"\t\tResult: {amountOfEuros * rate} pln");

            // Task 10

            string studentName, studentUniversity;
            int studentAge;
            double studentAverageGrade;

            Console.Write("\n\t\tPlease enter your name: ");
            studentName = Console.ReadLine();
            Console.Write("\t\tPlease enter your university: ");
            studentUniversity = Console.ReadLine();
            Console.Write("\t\tPlease enter your age: ");
            int.TryParse(Console.ReadLine(), out studentAge);
            if (studentAge == 0)
                Console.WriteLine("\t\tInvalid number");
            Console.Write("\t\tPlease enter your average grade : ");
            double.TryParse(Console.ReadLine(), out studentAverageGrade);
            if (studentAge == 0)
                Console.WriteLine("\t\tInvalid number");

            Console.WriteLine($"\t\t -----------------" +
                $"\n\t\t Student Information" +
                $"\n\t\t -----------------" +
                $"\n\t\t Name: {studentName}" +
                $"\n\t\t Age: {studentAge}" +
                $"\n\t\t University: {studentUniversity}" +
                $"\n\t\t Averega grade: {studentAverageGrade}" +
                $"\n\t\t -----------------");



            //           Level 4 ///////////////


            // Task 11

            a = 10;
            b = 3;

            double result = a / b;

            Console.WriteLine($"\n\n\t\t\t{result}");
            
            // Task 12

            double number = 10.99;
            result = (int)number;

            Console.WriteLine($"\n\n\t\t\t{result}");
        }
    }
}
