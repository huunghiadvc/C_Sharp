using System;

namespace HelloWorld
{
    internal class Program
    {
        static void Main(String[] args)
        {
            var rectangle = new Rectangle(8.1, 9.2);
            rectangle.Show();
            // Tham trị ? Đối tượng ( dynamic , String ) ? con trỏ
            // char, decimal , double , float , int , long , float
            // Console.WriteLine(sizeof(int));
            object obj;
            obj = 20;
            dynamic d = 1;
            d = "String";
            d = 1.1;
            d = new Rectangle();
            String str = "Hello \"HEHE\"";
            Console.WriteLine(str);
            // pointer
            long a = 2147483648;
            int b = (int)a;
            Console.WriteLine(b);
            
        }
        class Rectangle
        {
            // attributes
            public double lenght;
            public double width;
            public Rectangle()
            {

            }
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
