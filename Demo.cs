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
    namespace Demo3
    {
        class C1
        {
            public void Function()
            {
                Console.WriteLine("Function in Demo 2");
            }
        }
    }
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
        // public static void Main(string[] args)
        // {
        //     Demo1.C1 c1 = new Demo1.C1();
        //     c1.Function();
        //     Demo2.C1 c2 = new Demo2.C1();
        //     c2.Function();
        //     Demo2.Demo3.C1 c3 = new Demo2.Demo3.C1();
        //     c3.Function();
        // }
        // public static void Main(string[] args)
        // {
        //     Rectangle rec = new Rectangle(5.8, 9.3);
        //     Console.WriteLine(rec.Area());
        // }
    }

    class Rectangle
    {
        public double width, height;
        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }
        public double Area()
        {
            return width * height;
        }
    }
}

namespace EceptionHandler
{
    class Program
    {
        public static int Devide(int num1, int num2)
        {
            if (num2 == 0)
            {
                throw new MyException("Number cannot be zero");
            }
            return num1 / num2;
        }
        // public static void Main(string[] args)
        // {
        //     int result = 1;
        //     int result1 = 0;
        //     Console.WriteLine(Devide(result, result1));
        // }
    }

    class MyException : ApplicationException
    {
        public MyException(string message) : base(message) { }
    }

}
