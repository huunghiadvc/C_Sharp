using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;

namespace Lab1
{
    class Program
    {
        static string[] CloneData()
        {
            string[] strArr = new string[10000];
            for (int i = 0; i < 10000; i++)
            {
                strArr[i] = "2024/02/29";
            }
            return strArr;
        }
        // static void Main(string[] args)
        // {
        //     Stopwatch stopwatch = Stopwatch.StartNew();
        //     string[] str = CloneData();

        //     for (int i = 0; i < 10000; i++)
        //     {
        //         string[] strArr = Utils.SplitString(str[i]);

        //         // Trường hợp sai format ngày, tháng, năm
        //         if (strArr.Length != 3)
        //         {
        //             Console.WriteLine("Invalid date");
        //             return;
        //         }

        //         // validate ngày tháng năm
        //         if (!Utils.DateValid(strArr))
        //         {
        //             return;
        //         }

        //         string dateOfBirth = string.Join("", strArr);

        //         int sum = Utils.GetSumOfBirthDay(dateOfBirth);

        //         Result.ShowResult(sum);
        //     }

        //     stopwatch.Stop();
        //     TimeSpan elapsedTime = stopwatch.Elapsed;
        // }
    }
    class Utils
    {
        public static string[] SplitString(String str)
        {
            string[] strArr = str.Split("/");
            if (strArr.First().Equals(str))
            {
                strArr = str.Split("-");
            }
            return strArr;
        }

        public static Boolean DateValid(string[] strArr)
        {

            int year, date;
            int month = Convert.ToInt32(strArr[1]);

            if (strArr[0].Length == 4)
            {
                year = Convert.ToInt32(strArr[0]);
                date = Convert.ToInt32(strArr[2]);
            }
            else
            {
                year = Convert.ToInt32(strArr[2]);
                date = Convert.ToInt32(strArr[0]);
            }

            int daysInMonth;
            if (month == 2 && DateTime.IsLeapYear(year))
            {
                daysInMonth = 29;
            }
            else
            {
                daysInMonth = DateTime.DaysInMonth(year, month);
            }


            if (year < 0)
            {
                Console.WriteLine("Invalid year: " + year);
                return false;
            }

            if (month < 1 || month > 12)
            {
                Console.WriteLine("Invalid month: " + month);
                return false;
            }

            if (date < 1 || date > daysInMonth)
            {
                Console.WriteLine($"Invalid date: {date} of month {month}");
                return false;
            }

            return true;
        }

        public static int GetSumOfBirthDay(string dateOfBirth)
        {
            int dateOfBirthInt = Convert.ToInt32(dateOfBirth);
            return TotalDigit(dateOfBirthInt);
        }

        public static int TotalDigit(int number)
        {
            int result = 0, temp;
            while (number != 0)
            {
                temp = number % 10;
                result += temp;
                number /= 10;
            }
            return result;
        }

    }
    class Result
    {
        public static void ShowResult(int sum)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            string result = "";
            int finalSum;
            if (sum == 22)
            {
                finalSum = 4;
                result = "Vô địch thiên hạ!";
            }
            else
            {
                finalSum = Utils.TotalDigit(sum);
                switch (finalSum)
                {
                    case 2:
                        result = "Kết quả 2";
                        break;
                    case 3:
                        result = "Kết quả 3";
                        break;
                    case 4:
                        result = "Kết quả 4";
                        break;
                    case 5:
                        result = "Kết quả 5";
                        break;
                    case 6:
                        result = "Kết quả 6";
                        break;
                    case 7:
                        result = "Kết quả 7";
                        break;
                    case 8:
                        result = "Kết quả 8";
                        break;
                    case 9:
                        result = "Kết quả 9";
                        break;
                    case 10:
                        result = "Kết quả 10";
                        break;
                    case 11:
                        result = "Kết quả 11";
                        break;
                }
            }
            Console.WriteLine("Tổng : " + sum);
            Console.WriteLine("Tổng cuối : " + finalSum);
            Console.WriteLine("Kết quả : " + result);
        }
    }
}