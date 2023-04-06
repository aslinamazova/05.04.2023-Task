namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Method(3,2);
        }
        static void Method(int a)
        {
            Console.WriteLine(Math.Pow(a,a));
        }
        static void Method(int a,int b)
        {
            Console.WriteLine(Math.Pow(a,b));
        }
    }
}

