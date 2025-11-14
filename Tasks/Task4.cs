namespace Autotest_contr;

public class Task4
{
    public static bool IsPalindrome(int x)
    {
        string s = x.ToString();
        bool ist = true;
        int len = s.Length - 1; 
        if (x < 0) return ist = false;
        for (int i = 0; i <= len / 2; i++)
        {
            if (s[i] != s[len - i])
            {
                ist = false;
                break;
            }
        }

        return ist;
    }
}