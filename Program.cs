namespace MaximumProductSubarray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums= {2,3,-2,4};

            int result = MaxProduct(nums);
            Console.WriteLine(result);

        }

        public static int MaxProduct(int[] nums) {
            int result = nums[0];
            int currentMin = nums[0];
            int currentMax = nums[0];
            for(int i = 1; i < nums.Length; i++)
            {
                if(nums[i] == 0)
                {
                    result = Math.Max(result, 0);
                    currentMin = 1;
                    currentMax = 1;
                    continue;
                }
                
                int[] options = new int[] {currentMax * nums[i], currentMin * nums[i], nums[i]};
                Array.Sort(options);
                currentMin = options[0];
                currentMax = options[2];
                result = Math.Max(result, currentMax);
            }
            return result;
        }
    }
}