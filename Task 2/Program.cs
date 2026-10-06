namespace Task_2;

class Circle
{
    // Declare a constant variable named PI
    public const double PI = 3.14;

    // Calculate the area of the circle
    public static double CalculateArea(double radius)
    {
        return PI * radius * radius;
    }

    // Calculate the perimeter of the circle
    public static double CalculatePerimeter(double radius)
    {
        return 2 * PI * radius;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Display the value of PI
        Console.WriteLine($"Value of PI: {Circle.PI}");

        // Trying to modify the constant value:
        // Circle.PI = 3.15;
        // This gives a compilation error because PI is a constant
        // and constant values cannot be modified after declaration.

        double radius = 5;

        Console.WriteLine($"Area of Circle: {Circle.CalculateArea(radius)}");
        Console.WriteLine($"Perimeter of Circle: {Circle.CalculatePerimeter(radius)}");
    }
}
