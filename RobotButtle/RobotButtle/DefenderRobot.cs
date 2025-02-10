using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotButtle
{
    internal class DefenderRobot : Robot
    {
        Random Random;
        public DefenderRobot()
        {
            Energy = 120;
            AtackPower = 15;
            Random = new Random();
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
            if (Energy <= 20)
            {
                oponent.Energy = oponent.Energy - Random.Next(1, AtackPower + 1) * 2;
            }
        }

        public override void Defance(int result)
        {
            int energy = Random.Next(1, AtackPower + 1);

            if (energy >= 2 && energy <= 6)
            {
                Console.WriteLine("Defance: ");
                energy += result;
            }
        }

        public override void SpecialAbility(Robot oponent)
        {
            int energy = Random.Next(1, AtackPower + 1);

            if (energy == 4)
            {
                Console.WriteLine("SpecialAbility");
                oponent.Energy -= 50;
            }
        }
    }
}
