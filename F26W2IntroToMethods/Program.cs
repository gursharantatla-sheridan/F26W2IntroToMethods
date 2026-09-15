namespace F26W2IntroToMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 5;

            Console.WriteLine("Before changes:");
            Console.WriteLine("n = " + n);

            ChangeValues(n);

            Console.WriteLine("\nAfter changes:");
            Console.WriteLine("n = " + n);
        }

        static void ChangeValues(int num)
        {
            num = num + 100;
        }
    }
}
