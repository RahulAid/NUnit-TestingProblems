namespace NUnit_TestingProblems
{
    internal class Program
    {
        public static void Main()
        {
            Console.WriteLine("Enter a Principal Amount ");
            double P = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nEnter Years required for Repayment ");
            double Y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nEnter Monthly Rate of interest ");
            double R = Convert.ToInt32(Console.ReadLine());

            double n = 12 * Y;
            double r = R / (12 * 100);

            double payment = (P * r) / (1 - Math.Pow(1 + r, -n));

            Console.WriteLine("The Repayment amount is "+payment);
            Console.ReadLine();
        }
        
    }
}