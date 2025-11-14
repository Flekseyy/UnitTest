namespace Tasks;

public class Task1
{
    public static int GetMin(int[] mass)
    {
        if (mass == null)  throw new ArgumentNullException("mass" + " " + "массив не должен равняться null");
        
        if (mass.Length == 0)  throw new ArgumentException("mass" + " " + 
                                                           "длина массива не должна равняться 0");
        
        int temp = mass[0];
        for (int i = 0; i < mass.Length; i++)
        {
            if (temp > mass[i])
            {
                temp = mass[i];
            }
        }
        return temp;
    }
}