

// 3 items in array
string[] fraudulentOrders = new string[4]; 

fraudulentOrders[0] = "A123";
fraudulentOrders[1] = "B456";
fraudulentOrders[2] = "C789";
fraudulentOrders[3] = "D000";

Console.WriteLine($"{fraudulentOrders[0]}");
fraudulentOrders[0] = "111";

Console.WriteLine($"Reassign first: {fraudulentOrders[0]}");

//////////

string[] fraudulentOrdersIDS = {"111", "222", "333"};
Console.WriteLine(fraudulentOrdersIDS[0]);

Console.WriteLine($"Length: {fraudulentOrdersIDS.Length}");

////

string[] names = { "Rowena", "Robin", "Bao" };
foreach (string name in names)
{
    Console.WriteLine($"{name}");
}
Console.WriteLine($"\n");


/// Add previous run time to next 
int[] inventory = {200, 450, 700, 175, 250};
int sum = 0;
int position = 0;

foreach (int num in inventory)
{
    sum += num;
    position++;

    Console.WriteLine($"Position {position}: {num} items = (running total: {sum})");
}
Console.WriteLine($"\n");

////

string[] arrayWords = { "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" };

string startLetter = "B";
int counter = 0;
foreach (string word in arrayWords) 
{
    if(word.StartsWith(startLetter)) {
    Console.WriteLine(word);
    }
}

bool containsSearchResult = arrayWords.Contains("B123");
Console.WriteLine($"{containsSearchResult}");


