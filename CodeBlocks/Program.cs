// Code sample 2
int value = 5;
Console.WriteLine($"Outside the code block: {value}");
if (true)
{
    value = 10;
    Console.WriteLine($"Inside the code block: {value}");
}
Console.WriteLine($"Outside the code block: {value}\n");


bool flag = true;
if (flag)
    Console.WriteLine($"{flag} \n");


string name = "steve";
if (name == "bob") 
    Console.WriteLine("Found Bob\n");

else if (name == "steve") 
    Console.WriteLine("Found Steve\n");

else 
    Console.WriteLine("Found Chuck\n");




int[] numbers = { 4, 8, 15, 16, 23, 42 };
int total = 0;
bool found = true;

foreach (int number in numbers)
{
    total += number;
    if (number == 42)
        found = true;
}


if (found) 
{
    Console.WriteLine("Set contains 42");
}

Console.WriteLine($"Total: {total}\n");