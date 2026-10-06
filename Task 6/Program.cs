namespace Task_6;

class Program
{
    static void Main(string[] args)
    {
        // Create a List<string> containing 3 favorite fruits
        List<string> fruits = new List<string>
        {
            "Apple",
            "Mango",
            "Banana"
        };

        // Add a new fruit to the list
        fruits.Add("Orange");

        // Remove one fruit from the list
        fruits.Remove("Banana");

        // Print all fruits using foreach
        foreach (string fruit in fruits)
        {
            Console.WriteLine(fruit);
        }

        // Create a Dictionary<int, string>
        // Keys are fruit IDs and values are fruit names
        Dictionary<int, string> fruitDictionary = new Dictionary<int, string>
        {
            { 1, "Apple" },
            { 2, "Mango" },
            { 3, "Banana" }
        };

        // Add a new entry to the dictionary
        fruitDictionary.Add(4, "Orange");

        // Print all key-value pairs
        foreach (KeyValuePair<int, string> item in fruitDictionary)
        {
            Console.WriteLine($"ID: {item.Key}, Fruit: {item.Value}");
        }
    }
}