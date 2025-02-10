using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotButtle
{
    internal class WarriorRobot : Robot
    {
        Random Random;

        public WarriorRobot()
        {
            Random = new Random();
            AtackPower = 20;
            Energy = 100;
        }
        public override void Attack(Robot opponent)
        {
            int result = Random.Next(1, AtackPower + 1);
            opponent.Energy -= result;
            CriticalHit(opponent);
            Defance(result);
            SpecialAbility(opponent);
        }

        public override void CriticalHit(Robot oponent)
        {
            if (Energy <= 10)
            {
                Console.WriteLine("Critical Hit");
                oponent.Energy -= Random.Next(1, AtackPower + 1) * 2;
            }
        }

        public override void Defance(int result)
        {
            int energy = Random.Next(1, AtackPower + 1);

            if (energy >=4 && energy<=8)
            {
                Console.WriteLine("Defance: ");
                energy += result;
            }
        }

        public override void SpecialAbility(Robot oponent)
        {
            int energy = Random.Next(1, AtackPower + 1);

            if (energy == 6)
            {
                Console.WriteLine("SpecialAbility");
                oponent.Energy -= 50;
            }
        }
    }
}
