using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.NeoFighters
{
    public class Korbat : NeoFighter
    {
        NeoFighterNames _name = NeoFighterNames.Korbat;
        int _health = 280;
        int _attackPower = 28; // this means between 26-30
        int _critRatio = 15;

        public Korbat()
        {
            Name = _name;
            Health = _health;
            AttackPower = _attackPower;
            CritRatio = _critRatio;
            Attack1Name = "LifeSteal";
            Attack2Name = "Strychine";
            Attack3Name = "PoisonBite";
        }

        public override int Attack1(Random rnd, int attackPower)
        {
            return Attack(rnd, _attackPower);
            //LifeSteal
            //heal 40% of dealth damage
        }
        public override int Attack2(Random rnd, int attackPower)
        {
            return Attack(rnd, _attackPower * 3);
            //Strychine
            //double damage if enemy is poisoned
        }
        public override int Attack3(Random rnd, int attackPower)
        {
            return Attack(rnd, _attackPower * 6);
            //PoisonBite
            //30% chance to poison
        }
    }
}
