namespace Autotest_contr;

public class Task6
{
    public static bool TryParse(string str, out int number)
    {
        if (str == null)  throw new ArgumentNullException("string" + " " + 
                                                          "строка не должен равняться null");
        if (str.Length == 0)  throw new ArgumentException("String" + " " + 
                                                            "длина строки не должна равняться 0");
        number = 0;
        bool ist = true;        
        for (int i = 0; i < str.Length; i++)
        {
            if (str[0] == '-') continue;
            if (Char.IsDigit(str[i]) == false)
            {
                ist = false;
                break;
            } 
        }
        if(ist == true)
        {
            number = int.Parse(str);
        }
        return ist;
    }
}