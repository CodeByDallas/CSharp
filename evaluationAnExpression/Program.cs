Console.WriteLine("a" != "a");
Console.WriteLine("a" != "A");
Console.WriteLine(1 != 2);

string pangram = "The quick brown fox jumps over the lazy dog.";
Console.WriteLine(pangram.Contains("fox"));
Console.WriteLine(pangram.Contains("cow"));

// These two lines of code will create the same output
Console.WriteLine(pangram.Contains("fox") == false);
Console.WriteLine(!pangram.Contains("fox"));

int a = 7;
int b = 6;
Console.WriteLine(a != b); // output: True
string s1 = "Hello";
string s2 = "Hello";
Console.WriteLine(s1 != s2); // output: False
Console.WriteLine("\n");

int saleAmount = 1001;
int discount = saleAmount > 1000 ? 100 : 50;
Console.WriteLine($"Discount: {discount}\n");

int saleAmounts = 1001;
Console.WriteLine($"Discount: {(saleAmounts > 1000 ? 100 : 50)}\n");

Random number = new Random();
int randomNumber = number.Next(1, 50);
Console.WriteLine((randomNumber < 25) ? "heads" : "Tales");
Console.WriteLine("\n");

//Logic Challenge
string permission = "A";
int level = 55;

if(permission.Contains("Admin"))
{
    if (level >= 55)
    {
    Console.WriteLine("Welcome, Super Admin user");
    }
    else
    {
        Console.WriteLine("Welcome, Admin user");
    }
}
else if(permission.Contains("Manager"))
{
    if (level >= 20 )
    {
        Console.WriteLine("Contact an Admin for access");
    }
    else
    {
        Console.WriteLine("You do not have sufficient privileges");
    }
}
  
else
    {
        Console.WriteLine("Sorry");
    }
   



