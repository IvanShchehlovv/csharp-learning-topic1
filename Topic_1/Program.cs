namespace Topic_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var name = "Ivan";
            int age = 20;
            double hight = 191.5;
            float weight = 83.5f;
            bool isStudent = true;
            char firstLetterName = 'I';

            Console.WriteLine($"Name: {name}, age: {age}, hight: {hight}, weight: {weight}," +
                $" is a Student? : {isStudent}, the first letter of my name: {firstLetterName}");

            int a = 10;
            int b = 3;

            Console.Write($"Summ = {a + b}, difference = {a - b} or {b - a}," +
                $" quotient = {(a / b)}, remainder = {a % b}");

        
        }
    }
}
