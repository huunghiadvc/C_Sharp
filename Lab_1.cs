using System;
using System.Runtime.InteropServices;
using System.Text;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "11-12-1998";

            string[] strArr = Utils.SplitString(str);

            if (strArr.Length != 3)
            {
                Console.WriteLine("Invalid date");
                return;
            }

            if (!Utils.DateValid(strArr))
            {
                return;
            }

            string dateOfBirth = string.Join("", strArr);

            int sum = Utils.GetSumOfBirthDay(dateOfBirth);

            Result.ShowResult(sum);
        }
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
            int DateInt, MonthInt, YearInt;

            MonthInt = Convert.ToInt32(strArr[1]);
            if (strArr[0].Length == 2)
            {
                DateInt = Convert.ToInt32(strArr[0]);
                YearInt = Convert.ToInt32(strArr[2]);
            }
            else
            {
                DateInt = Convert.ToInt32(strArr[2]);
                YearInt = Convert.ToInt32(strArr[0]);
            }

            if (YearInt > DateTime.Now.Year || YearInt < 0)
            {
                Console.WriteLine("Invalid year: " + YearInt);
                return false;
            }

            int DayOfFeb;
            if (DateTime.IsLeapYear(YearInt))
            {
                DayOfFeb = 29;
            }
            else
            {
                DayOfFeb = 28;
            }

            switch (MonthInt)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    if (DateInt < 1 || DateInt > 31)
                    {
                        Console.WriteLine("Invalid date: " + DateInt + "of month " + MonthInt);
                        return false;
                    }
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    if (DateInt < 1 || DateInt > 30)
                    {
                        Console.WriteLine("Invalid date: " + DateInt + "of month " + MonthInt);
                        return false;
                    }
                    break;
                case 2:
                    if (DateInt < 1 || DateInt > DayOfFeb)
                    {
                        Console.WriteLine("Invalid date: " + DateInt + "of month " + MonthInt);
                        return false;
                    }
                    break;
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
            string result = "";
            if (sum == 22)
            {
                Console.WriteLine("Tổng : " + sum);
                Console.WriteLine("Tổng cuối : " + 4);
                Console.WriteLine("Vô địch thiên hạ");
                return;
            }
            int finalSum = Utils.TotalDigit(sum);
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
            Console.WriteLine("Tổng : " + sum);
            Console.WriteLine("Tổng cuối : " + finalSum);
            Console.WriteLine("Kết quả : " + result);
        }
    }
}