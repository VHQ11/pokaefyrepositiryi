using System;

namespace STENN_Task_one
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 2008, y = 2012, z = 2014;
            Print(x, y, z);

            ChangeValue(ref x, ref y, ref z);
            Print(x, y, z);
        }

        private static void ChangeValue(ref int x, ref int y, ref int z)
        {
            x += z;
            z = x - z;
            x -= z;
            y += x;
            x = y - x;
            y -= x;
        }

        private static void Print(int x, int y, int z)
        {
            Console.WriteLine($"x={x}  y={y}  z={z}");
        }
    }
}
