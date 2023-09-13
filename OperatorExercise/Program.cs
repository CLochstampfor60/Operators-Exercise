namespace OperatorExercise
{
    public class Program
    {
 
    static void Main(string[] args)
        {

            //Exercise 1 STARTS*****
            //Values
            int x = 23;
            int y = 4;
            int a = 17;
            int b = 4;
            int quotient = a / b;
            int remainder = a % b;

            //Functions
            Console.WriteLine($"Variable Value x = {x}");
            Console.WriteLine($"Variable Value y = {y}");
            Console.WriteLine($"Variable Value a = {a}");
            Console.WriteLine($"Variable Value b = {b}");
            Console.WriteLine($"Variable Value quotient = a / b");
            Console.WriteLine($"Variable Value remainder = a % b\n");

            Console.WriteLine($"Addition: x + y = {x + y}.");
            Console.WriteLine($"Subtraction: x - y = {x - y}.");
            Console.WriteLine($"Multiplication: x * y = {x * y}.");
            Console.WriteLine($"Division: x / y = {x / y}.");
            Console.WriteLine($"Modulus: x % y = {x % y}.\n");

            Console.WriteLine($"The division result for variable quotient of a and b = {quotient}");
            Console.WriteLine($"The modulus result for variable remainder of a and b = {remainder}\n \n");
            //Exercise 1 ENDS*****


            //Exercise 2 STARTS*****

            Console.WriteLine("What is the radius of your circle?");
            var radius = double.Parse(Console.ReadLine());

            double area = Math.PI * Math.Pow(radius, 2);

            Console.WriteLine($"The area of a circle with a radius of {radius} is {area}");
            //Exercise 2 ENDS*****
        }

    }
}

