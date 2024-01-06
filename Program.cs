using System;
using static Demo.EnumDemo.Status;

namespace HelloWorld
{
    internal class Program
    {
        // static void Main(String[] args)
        // {
        //     var rectangle = new Rectangle(8.1, 9.2);
        //     rectangle.Show();
        //     // Tham trị ? Đối tượng ( dynamic , String ) ? con trỏ
        //     // char, decimal , double , float , int , long , float
        //     // Console.WriteLine(sizeof(int));
        //     object obj;
        //     obj = 20;
        //     dynamic d = 1;
        //     d = "String";
        //     d = 1.1;
        //     d = new Rectangle();
        //     String str = "Hello \"HEHE\"";
        //     Console.WriteLine(str);
        //     // pointer
        //     int a = 2147483647;
        //     a++;
        //     Console.WriteLine(a);
        //     Int64 test = Convert.ToInt64(a);
        //     Console.WriteLine(test);
        //     // Toán tử số học : + , - , * , / , % , ++ , --
        //     // Toán tử quan hệ : == , !=, > , <  >= , <=
        //     // Toán tử logic : && , || , !
        //     // Toán tử bit : &, |, ^, <<, >>
        //     // Toán tử tính : +, -, *, /, %, ++, --
        //     // bit : AND - & , OR - | , XOR - ^ , đảo bit - ~ , dịch trái / phải
        //     int x = 18, y = 11;
        //     // Bảng chân trị
        //     Console.WriteLine("x | y : {0}", x | y);
        //     Console.WriteLine("x & y : {0}", x & y);
        //     Console.WriteLine("x ^ y : {0}", x ^ y);
        //     Console.WriteLine("x << 1 : {0}", x << 1);
        //     Console.WriteLine("x >> 1 : {0}", x >> 1);

        //     // toán tử khác
        //     int[] arr = new int[10];
        //     Console.WriteLine(sizeof(int));
        //     Console.WriteLine(typeof(Rectangle));
        // }
        class Rectangle
        {
            // attributes
            public double lenght;
            public double width;
            public Rectangle() { }
            public Rectangle(double lenght, double width)
            {
                this.lenght = lenght;
                this.width = width;
            }
            public double Area()
            {
                return lenght * width;
            }
            public double Perimeter()
            {
                return 2 * (lenght + width);
            }
            public void Show()
            {
                Console.WriteLine("Chieu dai: " + lenght);
                Console.WriteLine("Chieu cao: " + width);
                Console.WriteLine("Dien tich: " + Area());
                Console.WriteLine("Perimeter: " + Perimeter());
            }
        }
    }
}
