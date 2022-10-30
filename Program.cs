namespace NUnit_TestingProblems
{
    internal class Program
    {       public static void Main()
         {
            Console.WriteLine("Enter Day value: ");
            int d = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nEnter Month value: ");
            int m = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nEnter Year value: ");
            int y = Convert.ToInt32(Console.ReadLine());

            int y0 = y - (14 - m) / 12;
            int x = y0 + y0 / 4 - y0 / 100 + y0 / 400;
            int m0 = m + 12 * ((14 - m) / 12) - 2;
            int d0 = (d + x + (31 * m0) / 12) % 7;

            switch (d0)
            {
                case 0:
                    Console.WriteLine("\nIt is SUNDAY");
                    break;
                case 1:
                    Console.WriteLine("\nIt is MONDAY");
                    break;
                case 2:
                    Console.WriteLine("\nIt is TUESDAY");
                    break;
                case 3:
                    Console.WriteLine("\nIt is WEDNESDAY");
                    break;
                case 4:
                    Console.WriteLine("\nIt is THURSDAY");
                    break;
                case 5:
                    Console.WriteLine("\nIt is FRIDAY");
                    break;
                case 6:
                    Console.WriteLine("\nIt is SATURDAY");
                    break;
                default:
                    Console.WriteLine("Invalid Input");
                    break;
            }
            Console.ReadLine();
        }
        
    }
}