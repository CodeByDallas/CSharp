//using Internal;

//the System namespace without requiring you to specify System. For example, your code can use the Console.WriteLine() method without having to specify System.Console.WriteLine()
using System;

internal class Program
{
    private static void Main(string[] args)
    {
        // initialize variables - graded assignments 
        int currentAssignments = 5;

        int[] sophiaScores = new int[] { 90, 86, 87, 98, 100 };
        int[] andrewScores = new int[] { 92, 89, 81, 96, 90 };
        int[] emmaScores = new int[] { 90, 85, 87, 98, 68 };
        int[] loganScores = new int[] { 90, 95, 87, 88, 96 };

       
        int sophiaSum = 0;
        decimal sophiaScore;
        
        foreach (int score in sophiaScores)
        {
            sophiaSum += score;
        }
            
        sophiaScore = (decimal)sophiaSum / currentAssignments;
        Console.WriteLine(sophiaScore);

        Console.WriteLine("Student\t\tGrade\n");
        Console.WriteLine("Sophia:\t\t" + sophiaScore + "\tA-");

        Console.WriteLine("Press the Enter key to continue");
        Console.ReadLine();
    }
}





/*


int sophiaSum = 0;
int andrewSum = 0;
int emmaSum = 0;
int loganSum = 0;

decimal sophiaScore;
decimal andrewScore;
decimal emmaScore;
decimal loganScore;


andrewSum = andrew1 + andrew2 + andrew3 + andrew4 + andrew5;
emmaSum = emma1 + emma2 + emma3 + emma4 + emma5;
loganSum = logan1 + logan2 + logan3 + logan4 + logan5;


andrewScore = (decimal)andrewSum / currentAssignments;
emmaScore = (decimal)emmaSum / currentAssignments;
loganScore = (decimal)loganSum / currentAssignments;

Console.WriteLine("Student\t\tGrade\n");
Console.WriteLine("Sophia:\t\t" + sophiaScore + "\tA-");
Console.WriteLine("Andrew:\t\t" + andrewScore + "\tB+");
Console.WriteLine("Emma:\t\t" + emmaScore + "\tB");
Console.WriteLine("Logan:\t\t" + loganScore + "\tA-");

Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();

*/