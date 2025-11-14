using static Autotest_contr.Task1;
using static Autotest_contr.Task2;
using static Autotest_contr.Task3;
using static Autotest_contr.Task4;
using static Autotest_contr.Task5;
using static Autotest_contr.Task6;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ответ #1" + " " + ToFindMin([3, 15, 1, 14]));
        Console.WriteLine("Ответ #2" + " " + IsCountStr("BananaRama"));
        Console.WriteLine("Ответ #3" + " " + IsLast3Simb("ABCDEFG"));
        Console.WriteLine("Ответ #4" + " " + IsPalindrome(0));
        Console.WriteLine("Ответ #5"); 
        int[] a = {-151, -4, -16, -1, -636};
        RunningSum(a);
        Console.WriteLine("Ответ №6" + " " + TryParse("1211412",out int number));
    

    }
}