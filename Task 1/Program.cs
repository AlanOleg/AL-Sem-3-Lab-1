using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Min and max values of predefined data types in C#:");
        Console.WriteLine($"int: [{int.MinValue}, {int.MaxValue}]");
        Console.WriteLine($"uint: [0, {uint.MaxValue}]");
        Console.WriteLine($"short: [{short.MinValue}, {short.MaxValue}]");
        Console.WriteLine($"ushort: [0, {ushort.MaxValue}]");
        Console.WriteLine($"long: [{long.MinValue}, {long.MaxValue}]");
        Console.WriteLine($"ulong: [0, {ulong.MaxValue}]");
        Console.WriteLine($"byte: [{byte.MinValue}, {byte.MaxValue}]");
        Console.WriteLine($"sbyte: [{sbyte.MinValue}, {sbyte.MaxValue}]");
        Console.WriteLine($"float: [{float.MinValue}, {float.MaxValue}]");
        Console.WriteLine($"double: [{double.MinValue}, {double.MaxValue}]");
        Console.WriteLine($"decimal: [{decimal.MinValue}, {decimal.MaxValue}]");
    }
}
