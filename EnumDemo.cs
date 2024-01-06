using System;
using System.ComponentModel;

namespace Demo
{
    class EnumDemo
    {
        public enum Status
        {
            [Description("Trạng thái hoạt động bình thường")]
            ACTIVE = 1, // 0
            [Description("Trạng thái xóa mềm")]
            INACTIVE = 0, // 1
            [Description("Trạng thái bị block")]
            PENDING = 2 // 2
        }
        // static void Main(string[] args)
        // {
        //     int num = (int)Status.ACTIVE;
        //     Console.WriteLine(num);
        //     Status status = Status.ACTIVE;
        //     switch (status) {
        //         case Status.ACTIVE:
        //             Console.WriteLine("Trạng thái hoạt động bình thường");
        //             break;
        //         case Status.INACTIVE:
        //             Console.WriteLine("Trạng thái xóa mềm");
        //             break;
        //         case Status.PENDING:
        //             Console.WriteLine("Trạng thái bị block");
        //             break;
        //         default:
        //             break;
        //     }
        // }
    }
}