List<int> numbers1 = new List<int> { 123 };
List<int> numbers2 = new List<int> { 32, 59, 1384, 14 };

if (numbers1 is [var singleItem])
{
    Console.WriteLine($"The single item is: {singleItem}");
}
else Console.WriteLine("The list doesn't have exactly one item");

if (numbers2 is [var singleItem2])
{
    Console.WriteLine($"The single item is: {singleItem2}");
}
else Console.WriteLine("The list doesn't have exactly one item");
