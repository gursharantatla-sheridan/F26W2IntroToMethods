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

            ChangeValues(ref n, ref s, c, a);

            Console.WriteLine("\nAfter changes:");
            Console.WriteLine("n = " + n);
            Console.WriteLine("s = " + s);
            Console.WriteLine("c.radius = " + c.radius);
            Console.WriteLine("a[0] = " + a[0]);

            Console.WriteLine("\n\n");


            // output parameters example
            int r = 5;
            //double circum, area;

            GetCircumAndArea(r, out double circum, out double area);

            Console.WriteLine("Circumference = " + circum.ToString("F"));
            Console.WriteLine("Area = " + area.ToString("F"));




            //Console.Write("\n\nEnter a number: ");

            //if (int.TryParse(Console.ReadLine(), out int num))
            //    Console.WriteLine("\nnum = " + num);
            //else
            //    Console.WriteLine("Invalid input. Please try again");


            Console.WriteLine("\n\n");


            // parameter array example

            int i = 2, j = 5, k = 9;

            Console.WriteLine("i = " + i + " j = " + j + " k = " + k);
            Console.WriteLine($"i = {i} j = {j} k = {k}");
            Console.WriteLine("i = {0} j = {1} k = {2}", i, j, k);


            int[] arr = { 5, 3, 4, 7, 6, 2 };

            PrintArray(arr);
            PrintArray(3, 5, 6, 7, 8, 9, 87, 6, 5, 4, 3, 3, 4, 5, 5, 6, 7, 8);


            string str = "hello, ";
            str = str.TrimEnd(' ', ',');
            Console.WriteLine(str + "world");
        }


        static void PrintArray(params int[] a)
        {
            Console.WriteLine("\n\nTotal items = " + a.Length);

            foreach (int i in a)
                Console.Write(i + " ");
            Console.WriteLine();
        }


        static void GetCircumAndArea(int r, out double circum, out double area)
        {
            circum = 2 * Math.PI * r;
            area = Math.PI * r * r;
        }



        static void ChangeValues(ref int num, ref string str, Circle cir, int[] arr)
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
