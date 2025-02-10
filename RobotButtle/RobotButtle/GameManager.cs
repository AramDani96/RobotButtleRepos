using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotButtle
{
    internal static class GameManager
    {
        public static void StartButtle(Robot robot1, Robot robot2)
        {
            Console.WriteLine("Start Game");
            while (true)
            {
                robot1.Attack(robot2);
                robot2.Attack(robot1);
                Console.WriteLine($"Robot1 Energy: {robot1.Energy}");
                Console.WriteLine($"Robot2 Energy: {robot2.Energy}");

                if (robot1.Energy <= 0)
                {
                    Console.WriteLine("Win Robot 2");
                    return;
                }
                if (robot2.Energy <= 0)
                {
                    Console.WriteLine("Win Robot 1");
                    return;
                }
                Thread.Sleep(10);
            }
        }
    }
}
