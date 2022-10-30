namespace NUnit_TestingProblems
{
    internal class Program
    {
        static int swapNibbles(int x)
        {
            return ((x & 0x0F) << 4 | (x & 0xF0) >> 4);
        }

        public static void Main()
        {
            Console.WriteLine("Enter a Value to Swap: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nSwapped Number is: {0}", swapNibbles(n));
        }
    }
}