object[] items = { "item1"};

if (items is [var item])
{
    Console.WriteLine($"Single item found: {item}");
}
else Console.WriteLine("Multiple or no items found");

