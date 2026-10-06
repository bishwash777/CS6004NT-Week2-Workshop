namespace Task_3;

class Program
{
    static void Main(string[] args)
    {
        // Declare and initialize a byte variable
        byte byteValue = 10;

        // Declare and initialize a short variable
        short shortValue = 20;

        // Declare and initialize an int variable
        int intValue = 42;

        // Declare and initialize a long variable
        long longValue = 100000L;

        // Declare and initialize a float variable
        float floatValue = 3.14f;

        // Declare and initialize a double variable
        double doubleValue = 6.28;

        // Declare and initialize a decimal variable
        decimal decimalValue = 99.99m;

        // Declare and initialize a char variable
        char charValue = 'A';

        // Declare and initialize a bool variable
        bool boolValue = true;

        // Convert the integer value 42 to a string
        string integerToString = intValue.ToString();

        // Convert the string "3.14" to a double
        double stringToDouble = Convert.ToDouble("3.14");

        // Print all variables with their types and values
        Console.WriteLine($"byte: {byteValue}");
        Console.WriteLine($"short: {shortValue}");
        Console.WriteLine($"int: {intValue}");
        Console.WriteLine($"long: {longValue}");
        Console.WriteLine($"float: {floatValue}");
        Console.WriteLine($"double: {doubleValue}");
        Console.WriteLine($"decimal: {decimalValue}");
        Console.WriteLine($"char: {charValue}");
        Console.WriteLine($"bool: {boolValue}");

        // Print the converted values
        Console.WriteLine($"Integer to String: {integerToString}");
        Console.WriteLine($"String to Double: {stringToDouble}");
    }
}