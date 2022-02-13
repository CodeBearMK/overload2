namespace inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            CalA res1 = new CalA();
            int n1 = 10, n2 = 15;
            res1.SetValue(n1, n2);
            Console.WriteLine("{0} + {1} = {2}", n1, n2, res1.GetSum());
            Console.WriteLine("------------------------------------");
            CalB res2 = new CalB();
            int n3 = 20, n4 = 25;
            res2.SetValue(n3, n4);
            Console.WriteLine("{0} + {1} = {2}", n3, n4, res2.GetSum());
            Console.WriteLine("{0} x {1} = {2}", n3, n4, res2.GetMult());
            Console.Read();
        }
    }
}