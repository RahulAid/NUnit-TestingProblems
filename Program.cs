namespace NUnit_TestingProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a value: ");
            double n = Convert.ToInt32(Console.ReadLine());

            double SquareRoot = Math.Sqrt(n);
            Console.WriteLine("\nThe Square Root of {0} is : {1}", n, SquareRoot);
        }
    }
}