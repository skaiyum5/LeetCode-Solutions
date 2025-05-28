namespace maximum_subarray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //normalSolved();
            //BruteForceSolved();
            KadanesAlgoSolved();

            Console.ReadLine();
            Console.WriteLine("Hello, World!");
        }

        private static void KadanesAlgoSolved()
        {
            int[] arr = [-2, 1, -3, 4, -1, 2, 1, -5, 4];
            int n = arr.Length;
            int maxSum = 0;
            int currSum = 0;

            for (int i = 0; i < n; i++)
            {
                currSum += arr[i];
                if (currSum > maxSum)
                {
                    maxSum = currSum;
                }
                if (currSum<0)
                {
                    currSum = 0;
                }
            }
            Console.WriteLine(maxSum);

            // time Complexity : O(n)
            //space Complexity :O(1)
        }

        private static void BruteForceSolved()
        {
            int[] arr = [-2, 1, -3, 4, -1, 2, 1, -5, 4];
            int n = arr.Length;
            int maxSum = 0;
            for (int st = 0; st < n; st++)
            {
                int currentSum = 0;
                for(int end = st; end < n; end++)
                {
                    currentSum += arr[end];
                    if (currentSum > maxSum)
                    {
                        maxSum = currentSum;
                    }
                }
            }
            Console.WriteLine(maxSum);
            // time Complexity : O(n^2)
            //space Complexity :O(1)
        }
        private static void normalSolved()
        {
            int[] arr = [1, 2, 3, 4, 5];// [-2, 1, -3, 4, -1, 2, 1, -5, 4];
            int n = arr.Length;

            for (int st = 0; st < n; st++)
            {
                for (int end = st; end < n; end++)
                {
                    for (int i = st; i <= end; i++)
                    {
                        Console.Write(arr[i]);
                    }
                    Console.Write("  ");
                }
            }
            //output ;1  12  123  1234  12345
            //2  23  234  2345
            //3  34  345
            //4  45
            //5
            // time Complexity : O(n^3)
            //space Complexity :O(1)
        }
    }
}
