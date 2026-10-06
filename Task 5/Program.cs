namespace Task_5;

class Program
{
    static void Main(string[] args)
    {
        // Create a DateTime variable representing your birthdate
        DateTime birthDate = new DateTime(2004, 5, 15);

        // Create another DateTime variable representing
        // the current date and time
        DateTime currentDate = DateTime.Now;

        // Calculate the difference between the two DateTime values
        TimeSpan ageDifference = currentDate - birthDate;

        // Calculate age in years
        int age = (int)(ageDifference.TotalDays / 365.25);

        // Print the birthdate
        Console.WriteLine($"Birthdate: {birthDate}");

        // Print the current date and time
        Console.WriteLine($"Current Date: {currentDate}");

        // Print the age in years
        Console.WriteLine($"Age: {age} years");

        // Add 10 days to the birthdate
        DateTime newDate = birthDate.AddDays(10);

        // Print the resulting date
        Console.WriteLine($"Birthdate after 10 days: {newDate}");
    }
}