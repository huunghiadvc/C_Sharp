using System;

namespace Demo1
{
    class C1
    {
        public void Function()
        {
            Console.WriteLine("Function 1 in Demo 1");
        }
    }
}

namespace Demo2
{
    class C1
    {
        public void Function()
        {
            Console.WriteLine("Function in Demo 2");
        }
    }
}

namespace Program
{
    class Program
    {
        public static void Main(string[] args)
        {
            Demo1.C1 c1 = new Demo1.C1();
            c1.Function();
            Demo2.C1 c2 = new Demo2.C1();
            c2.Function();
        }
    }
}
