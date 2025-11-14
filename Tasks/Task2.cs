namespace Tasks;

public class Task2
{
    public static int IsCountStr(string str)
    {
        if (str == null)
        {
            throw new ArgumentNullException("str" + " " + "строка не должен равняться null");
        }
        if (str.Length == 0)
        {
            throw new ArgumentException("str" + " " + "длина строки не должна равняться 0");
        }
        int cnt = 0;
        for(int i = 0; i < str.Length;i++)
        {
            if(Char.IsLower(str[i]))
            {
                cnt+=1;
            }
        }
        return cnt;
    }
}