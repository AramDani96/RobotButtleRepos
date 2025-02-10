using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotButtle
{
    internal abstract class Robot:IAttack
    {
        public string Name { get; set; }
        public int Energy { get; set; }
        public int AtackPower { get; set; }

        public Robot()
        {
            Energy = 100;
            AtackPower = 10;
        }
        public abstract void CriticalHit(Robot oponent);
        public abstract void Defance( int result);
        public abstract void SpecialAbility(Robot oponent);
        public abstract void Attack(Robot opponent);
        public bool isAlive()
        {
            if (Energy > 0)
            {
                return true;
            }

            return false;
        }
    }
}
