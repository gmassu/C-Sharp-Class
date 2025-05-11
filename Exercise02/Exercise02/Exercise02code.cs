using System;

namespace Exercise02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Number Type Information:");
            Console.WriteLine("-----------------------");

            // sbyte
            Console.WriteLine($"sbyte: Size = {sizeof(sbyte)} bytes, " +
                $"Min = {sbyte.MinValue}, Max = {sbyte.MaxValue}");

            // byte
            Console.WriteLine($"byte: Size = {sizeof(byte)} bytes, " +
                $"Min = {byte.MinValue}, Max = {byte.MaxValue}");

            // short
            Console.WriteLine($"short: Size = {sizeof(short)} bytes, " +
                $"Min = {short.MinValue}, Max = {short.MaxValue}");

            // ushort
            Console.WriteLine($"ushort: Size = {sizeof(ushort)} bytes, " +
                $"Min = {ushort.MinValue}, Max = {ushort.MaxValue}");

            // int
            Console.WriteLine($"int: Size = {sizeof(int)} bytes, " +
                $"Min = {int.MinValue}, Max = {int.MaxValue}");

            // uint
            Console.WriteLine($"uint: Size = {sizeof(uint)} bytes, " +
                $"Min = {uint.MinValue}, Max = {uint.MaxValue}");

            // long
            Console.WriteLine($"long: Size = {sizeof(long)} bytes, " +
                $"Min = {long.MinValue}, Max = {long.MaxValue}");

            // ulong
            Console.WriteLine($"ulong: Size = {sizeof(ulong)} bytes, " +
                $"Min = {ulong.MinValue}, Max = {ulong.MaxValue}");

            // float
            Console.WriteLine($"float: Size = {sizeof(float)} bytes, " +
                $"Min = {float.MinValue}, Max = {float.MaxValue}");

            // double
            Console.WriteLine($"double: Size = {sizeof(double)} bytes, " +
                $"Min = {double.MinValue}, Max = {double.MaxValue}");

            // decimal
            Console.WriteLine($"decimal: Size = {sizeof(decimal)} bytes, " +
                $"Min = {decimal.MinValue}, Max = {decimal.MaxValue}");

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
