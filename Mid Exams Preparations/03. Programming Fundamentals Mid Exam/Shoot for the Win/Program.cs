using System;
using System.Linq;

namespace Shoot_for_the_Win
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] targets = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            string command = string.Empty;
            int counterShootTargets = 0;
            while ((command = Console.ReadLine()) != "End")
            {
                int indexToShoot = int.Parse(command);
                if (indexToShoot >= 0 && indexToShoot < targets.Length)
                {
                    int previusTargetBeforeShoot = targets[indexToShoot];
                    targets[indexToShoot] = -1;
                    counterShootTargets++;
                    ReduceOrIncrease(targets, previusTargetBeforeShoot);
                }
            }
            Console.WriteLine($"Shot targets: {counterShootTargets} -> {string.Join(" ", targets)}");
        }

        static void ReduceOrIncrease(int[] targets, int previusTargetBeforeShoot)
        {
            int power = previusTargetBeforeShoot;
            for (int i = 0; i < targets.Length; i++)
            {
                int currentTarget = targets[i];
                if (currentTarget > power && currentTarget != -1)
                {
                    targets[i] -= power;
                }
                else if (currentTarget <= power && currentTarget != -1)
                {
                    targets[i] += power;
                }
            }
        }
    }
}
