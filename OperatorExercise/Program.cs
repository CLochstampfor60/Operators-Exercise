namespace OperatorExercise
{
    public class Program
    {
 
    static void Main(string[] args)
        {

            //Exercise 1 STARTS

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

            Console.WriteLine($"The result of the quotient of a and b = {quotient}");
            Console.WriteLine($"The result of the remainder of a and b = {remainder}");

        }

 
    }
}

