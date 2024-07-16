// The for statement: executes its body while a specified Boolean expression (the 'condition') evaluates to true.
// The foreach statement: enumerates the elements of a collection and executes its body for each element of the collection.
// The do-while statement: conditionally executes its body one or more times.
// The while statement: conditionally executes its body zero or more times.


/*
Random random = new Random();
int current = 0;

do
{
    current = random.Next(1, 11);
    Console.WriteLine(current);
} while (current != 7);

///////////////////////////////////////////


//while greater than

Random random = new Random();
int current = random.Next(1, 11);


do
{
    current = random.Next(1, 11);
    Console.WriteLine(current);
} while (current != 7);


while (current >= 3)
{
    Console.WriteLine(current);
    current = random.Next(1, 11);
}
Console.WriteLine($"Last number: {current}");
*/
////////////////////////////////////////////



    // You must use either the do-while statement or the while statement as an outer game loop.
    // The hero and the monster start with 10 health points.
    // All attacks are a value between 1 and 10.
    // The hero attacks first.
    // Print the amount of health the monster lost and their remaining health.
    // If the monster's health is greater than 0, it can attack the hero.
    // Print the amount of health the hero lost and their remaining health.
    // Continue this sequence of attacking until either the monster's health or hero's health is zero or less.
    // Print the winner.

// int monster;
// int hero;


int heroHealth = 10;
int monsterHealth = 10;

Random random = new Random();
int heroAttack = random.Next(1, 5);

Random monsterRandom = new Random();
int monsterAttack = monsterRandom.Next(1, 5);
do 
{
    monsterHealth -= heroAttack; 
    Console.WriteLine($"Monster was damaged and lost {heroAttack} health and now has {monsterHealth} health");

    heroHealth -= monsterAttack;
    Console.WriteLine($"Hero was damaged and lost {monsterAttack} health and now has {heroHealth} health");
}
while (monsterHealth > 0 && heroHealth > 0);
Console.WriteLine(heroHealth > monsterHealth ? "Hero wins" : "Monster wins");


//version 2
int hero = 10;
int monster = 10;

Random dice = new Random();

do
{
    int roll = dice.Next(1, 11);
    monster -= roll;
    Console.WriteLine($"Monster was damaged and lost {roll} health and now has {monster} health.");

    if (monster <= 0) continue;

    roll = dice.Next(1, 11);
    hero -= roll;
    Console.WriteLine($"Hero was damaged and lost {roll} health and now has {hero} health.");

} while (hero > 0 && monster > 0);

Console.WriteLine(hero > monster ? "Hero wins!" : "Monster wins!");

