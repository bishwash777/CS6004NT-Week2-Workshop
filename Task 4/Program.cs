namespace Task_4;

class Program
{
    static void Main(string[] args)
    {
        // Create a single-dimensional integer array
        // containing 5 favorite numbers
        int[] numbers = { 7, 21, 5, 15, 10 };

        // Sort the array in ascending order
        Array.Sort(numbers);

        // Reverse the sorted array
        Array.Reverse(numbers);

        // Print each element of the array using a for loop
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine(numbers[i]);
        }

        // Find the position of a specific number in the array
        int position = Array.IndexOf(numbers, 15);

        // Print the position of the number
        Console.WriteLine($"Position of 15: {position}");
    }
}