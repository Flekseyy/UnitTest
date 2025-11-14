using static Tasks.Task1;
using static Tasks.Task2;
using static Tasks.Task3;
using static Tasks.Task4;
using static Tasks.Task5;
using static Tasks.Task6;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ответ #1" + " " + GetMin([3, 15, 1, 14]));
        Console.WriteLine("Ответ #2" + " " + IsCountStr("BananaRama"));
        Console.WriteLine("Ответ #3" + " " + IsLast3Simb("ABCDEFG"));
        Console.WriteLine("Ответ #4" + " " + IsPalindrome(0));
        Console.WriteLine("Ответ #5"); 
        int[] a = {-151, -4, -16, -1, -636};
        RunningSum(a);
        Console.WriteLine("Ответ №6" + " " + TryParse("1211412",out int number));
    

    }
}