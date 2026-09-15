namespace F26W2IntroToMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 5;
            string s = "hello";

            Console.WriteLine("Before changes:");
            Console.WriteLine("n = " + n);
            Console.WriteLine("s = " + s);

            ChangeValues(n, s);

            Console.WriteLine("\nAfter changes:");
            Console.WriteLine("n = " + n);
            Console.WriteLine("s = " + s);
        }

        static void ChangeValues(int num, string str)
        {
            num = num + 100;
            str = "bye";
        }
    }
}
