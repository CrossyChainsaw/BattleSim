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

        int _chanceToPoison = 45;

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

        public override int Attack1(Random rnd, int attackPower, NeoFighter enemyNeoFighter)
        {
            //LifeSteal
            //heal 40% of dealth damage
            int damage = Attack(rnd, _attackPower);
            GainHealth(damage * 40 / 100);
            return damage;
        }
        public override int Attack2(Random rnd, int attackPower, NeoFighter enemyNeoFighter)
        {
            //Strychine
            //double damage if enemy is poisoned
            int damage = Attack(rnd, _attackPower);
            if (enemyNeoFighter.IsPoisoned)
            {
                damage *= 2;
            }
            return damage;
        }
        public override int Attack3(Random rnd, int attackPower, NeoFighter enemyNeoFighter)
        {
            //PoisonBite
            //30% chance to poison
            int poisonChance = rnd.Next(1, 101);
            if (poisonChance <= _chanceToPoison)
            {
                enemyNeoFighter.SetPoisoned(true);
            }
            return Attack(rnd, _attackPower);
        }
    }
}
