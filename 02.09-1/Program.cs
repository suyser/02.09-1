using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        _02._09_1.CustomConverter converter = new _02._09_1.CustomConverter();

        string numberString = "123";
        converter.ConvertToInt(numberString, out int intValue);
        Console.WriteLine($"Converted to int: {intValue}");

        string doubleString = "123.45";
        converter.ConvertToDouble(doubleString, out double doubleValue);
        Console.WriteLine($"Converted to double: {doubleValue}");

        string boolString = "true";
        converter.ConvertToBool(boolString, out bool boolValue);
        Console.WriteLine($"Converted to bool: {boolValue}");

        string dateString = "2023-10-01";
        converter.ConvertToDateTime(dateString, out DateTime dateValue);
        Console.WriteLine($"Converted to DateTime: {dateValue}");

        string longString = "1234567890123456789";
        converter.ConvertToLong(longString, out long longValue);
        Console.WriteLine($"Converted to long: {longValue}");
    }
}
