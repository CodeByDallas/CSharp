Random random = new Random();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;

Console.WriteLine("Enter Log in name as (name)");
string login = Console.ReadLine();

if(login == "name")
{
    if(daysUntilExpiration > 1 && daysUntilExpiration < 5)
    {
        Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days");
        discountPercentage = 10;
    }
    if(daysUntilExpiration == 1)
    {
        Console.WriteLine($"Your subscription expires within {daysUntilExpiration} day");
        discountPercentage = 20;
    }
    if(daysUntilExpiration == 0)
    {
        Console.WriteLine("Your subscription has expired");
    }
    if(daysUntilExpiration > 0)
    {
        Console.WriteLine($"Renew now and save {discountPercentage}%");
    }
}