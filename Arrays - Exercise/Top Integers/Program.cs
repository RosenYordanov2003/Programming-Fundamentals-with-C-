using System;
using System.Linq;

namespace Top_Integers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            for (int i = 0; i < nums.Length; i++)
            {
                bool biiger = true;
                for (int z = i + 1; z < nums.Length; z++)
                {
                    if (nums[i] <= nums[z])
                    {
                        biiger = false;
                    }
                }
                if (biiger)
                {
                    Console.Write(nums[i] + " ");
                }
            }
        }
    }
}
