namespace F26W2IntroToMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 5;
            string s = "hello";
            Circle c = new Circle();
            c.radius = 5;
            int[] a = { 3, 4, 5 };

            Console.WriteLine("Before changes:");
            Console.WriteLine("n = " + n);
            Console.WriteLine("s = " + s);
            Console.WriteLine("c.radius = " + c.radius);
            Console.WriteLine("a[0] = " + a[0]);

            ChangeValues(n, s, c, a);

            Console.WriteLine("\nAfter changes:");
            Console.WriteLine("n = " + n);
            Console.WriteLine("s = " + s);
            Console.WriteLine("c.radius = " + c.radius);
            Console.WriteLine("a[0] = " + a[0]);
        }

        static void ChangeValues(int num, string str, Circle cir, int[] arr)
        {
            num = num + 100;
            str = "bye";
            cir.radius = 100;
            arr[0] = 100;
        }
    }

    class Circle
    {
        public int radius;
    }
}
