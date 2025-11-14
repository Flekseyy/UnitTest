namespace Autotest_contr;

public class Task3
{
    public static char IsLast3Simb(string s)
    {
        
        if (s == null)  throw new ArgumentNullException("string" + " " +
                                                        "строка не должен равняться null");
        if (s.Length == 0)  throw new ArgumentException("String" + " " + 
                                                            "длина строки не должна равняться 0");
        if (s.Length < 3 )  throw new ArgumentOutOfRangeException("string" + " " 
                                                            +  "Недопустимое значение");   
        return s[s.Length - 3];
    }
}