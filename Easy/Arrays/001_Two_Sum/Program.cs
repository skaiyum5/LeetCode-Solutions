namespace _001_Two_Sum
{
    internal class Program
    {
        //Complexity=O(n)^2
        private static int[] TwoSum(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++) { 
                for (int j = 1; j <= nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        return new int[]{i, j};
                    }

                }
            }

            return new int[];
        }

        //Complexity=O(n)
        private static int[] TwoSum(int[] nums, int target)
        {
            public int[] TwoSum(int[] nums, int target)
            {

                Dictionary<int, int> result = new Dictionary<int, int>();
                int i = 0;
                while (i < nums.Length)
                {
                    int dif = target - nums[i];
                    if (result.ContainsKey(dif))
                    {
                        return new int[] { result[dif], i };
                    }
                    result.Add(nums[i], i);
                    i++;
                }

                return new int[] { };
            }

            //Dictionary<int, int> map = new Dictionary<int, int>();
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    int t = target - nums[i];
            //    if (map.ContainsKey(t))
            //    {
            //        return new int[] { map[t], i };
            //    }
            //    map[nums[i]] = i;
            //}

            //return new int[] { };
        }
        static void Main(string[] args)
        {
            int[] nums = [2, 7, 11, 15];
            TwoSum(nums, 9);
            Console.WriteLine("Hello, World!");
        }
    }
}
