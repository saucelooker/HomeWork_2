using System;

namespace ListOfWorkingDays
{
    class Program
    {
        [Flags]

        public enum daysOfWeek
        {
            monday = 0b_0000001,
            tuesday = 0b_0000010,
            wednesday = 0b_0000100,
            thursday = 0b_0001000,
            friday = 0b_0010000,
            saturday = 0b_0100000,
            sunday = 0b_1000000,
        }
        static void Main(string[] args)
        {
            Console.WriteLine($"Working days of the office №1 are: {(daysOfWeek)0b1111000}");

            Console.WriteLine($"Working days of the office №2 are: {(daysOfWeek)0b0011111}");
        }
    }
}

