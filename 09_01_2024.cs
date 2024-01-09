using System;

namespace Demo
{
    class Studnet2
    {
        public string Name { get; init; }
        public int Age { get; init; }
    }
    class Student
    {
        private string[] names;
        private int size;

        public Student(int size)
        {
            this.size = size;
            names = new string[size];

            for (int i = 0; i < names.Length; i++)
            {
                names[i] = "N/A";
            }
        }

        // get element of names
        public string this[int index]
        {
            get
            {
                return (index >= 0 && index < names.Length) ? names[index] : "";
            }
            set
            {
                if (index >= 0 && index < names.Length)
                {
                    names[index] = value;
                }
            }
        }

        // public static void Main(string[] args)
        // {
        //     Studnet2 stu = new() { Age = 20, Name = "Haha" };
        //     Studnet2 stu2 = new() { Name = "Hihi" };

        //     Console.WriteLine(stu.Name + " " + stu.Age);
        //     Console.WriteLine(stu2.Name + " " + stu2.Age);

        //     Student student = new(10);

        //     for (int i = 0; i < 10; i++)
        //     {
        //         student[i] = RandomString(10);
        //     }

        //     for (int i = 0; i < 10; i++)
        //     {
        //         Console.WriteLine(student[i]);
        //     }
        // }
        private static Random random = new Random();
        private static string RandomString(int length)
        {
            const string chars = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghjklmnopqrstuvwxyz";

            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}

namespace Demo2
{
    class Program
    {
        delegate int DelegagteDemo(string s);
        static int Convert(string stringValue)
        {
            return System.Convert.ToInt32(stringValue);
        }

        static int show(string value)
        {
            Console.WriteLine(value);
            return 0;
        }

        static void Main(string[] args)
        {
            DelegagteDemo delegagteDemo = new(Convert);
            DelegagteDemo delegagteDemo2 = new(show);
            DelegagteDemo delegagteDemo3 = delegagteDemo + delegagteDemo2;
            string intString = "20";

            Console.WriteLine("Parse string to int : ");
            delegagteDemo3(intString);

        }
    }
}
