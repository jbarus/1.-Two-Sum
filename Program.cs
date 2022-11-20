namespace _1._Two_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            int[] result;
            int[] question = {3, 3};
            result = TwoSum(question,6);
        }

        static public int[] TwoSum(int[] nums, int target) {
            int[] result = new int[2];
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target && i !=j) {
                        result[0] = i;
                        result[1] = j;
                        return result;
                    }
                }
            }  
            return result;
        }
    }
}