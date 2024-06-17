for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
    if (i == 7) break;
}


string[] names = { "Alex", "Eddie", "David", "Michael" };
for (int i = names.Length - 1; i >= 0; i--)
{
    Console.WriteLine(names[i]);
}
Console.WriteLine("\n");


// Without curly braces
string[] names = { "Alex", "Eddie", "David", "Michael" };
for (int i = 0; i < names.Length; i++)
    if (names[i] == "David") 
        names[i] = "Sammy";

foreach (var name in names) 
    Console.WriteLine(name);