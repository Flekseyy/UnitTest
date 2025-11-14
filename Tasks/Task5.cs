namespace Tasks;

public class Task5
{
    public static int[] RunningSum(int[] nums)
    {
        if (nums == null)  throw new ArgumentNullException("massive" + " " +
                                                           "массив не должен равняться null");
        
        if (nums.Length == 0)  throw new ArgumentException("massive" + " " + 
                                                               "длина массива не должна равняться 0");

        int[] result = new int[nums.Length];
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = 0; j < i; j++)
            {
                result[i] += nums[j];
            }

            Console.WriteLine(result[i]);
        }
        return result;
    }
}