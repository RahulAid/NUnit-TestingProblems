namespace NUnit_TestingProblems
{
    internal class Program
    {       public static void Main()
         {
            Console.WriteLine("Choose the unit conversion to be performed : \n1.Celsius to Fahrenheit \n2.Fahrenheit-Celsius");
            int In = Convert.ToInt32(Console.ReadLine());

            if (In == 1)
            {
                Console.WriteLine("\nEnter a temperature value: ");
                double val1 = Convert.ToInt32(Console.ReadLine());

                double result1 = (val1 * 9 / 5) + 32;

                Console.WriteLine("\n{0} °C equals {1} °F", val1, result1);
                Console.ReadLine();
            }
            else if (In == 2)
            {
                Console.WriteLine("\nEnter a temperature value: ");
                double val2 = Convert.ToInt32(Console.ReadLine());

                double result2 = (val2 - 32) * 5 / 9;

                Console.WriteLine("\n{0} °F equals {1} °C", val2, result2);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("\nEnter a Valid Temperature Value");
                Console.ReadLine();
            }
        }
    }
}