using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.NeoFighters
{
    public class Korbat : NeoFighter
    {
        public Korbat()
        {
            SetName(NeoFighterNames.Korbat);
            SetHealth(280);
            SetAttackPower(28);
            SetCritRatio(15);
        }

        public int Attack1_LifeSteal()
        {
            int attack = Attack(rnd, AttackPower);
            Heal(attack);
            return attack;
        }
        public void Attack2_Strychine()
        {
            //double damage if enemy is poisoned
        }
        public void Attack3_PoisonBite()
        {
            //30% chance to poison
        }



        void Heal(int stolenHealth)
        {
            SetHealth(Health + stolenHealth);
        }
    }
}
