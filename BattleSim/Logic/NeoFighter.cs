using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public enum NeoFighterNames
    {
        Korbat,
        Grarrl,
        Blumaroo
    }

    abstract public class NeoFighter
    {
        public Random rnd = new Random();

        public NeoFighterNames Name { get; internal set; }
        public int Health { get; internal set; }
        public int AttackPower { get; internal set; }
        /// <summary>Chance in percentage. Example 30 means 30%</summary>
        public int CritRatio { get; internal set; }
        public bool IsPoisoned { get; internal set; }
        public string Attack1Name { get; internal set; }
        public string Attack2Name { get; internal set; }
        public string Attack3Name { get; internal set; }


        public void SetPoisoned(bool value)
        {
            IsPoisoned = value;
        }
        public void LoseHealth(int damage)
        {
            Health -= damage;
        }
        public void GainHealth(int health)
        {
            Health += health;
        }
        public void GainAttackPower(int attackPower)
        {
            AttackPower += attackPower;
        }
        public int Attack(Random rnd, int attackpower)
        {
            int attackModifier = rnd.Next(-2, 3);
            return attackpower + attackModifier;
        }

        abstract public int Attack1(Random rnd, NeoFighter enemyNeoFighter);
        abstract public int Attack2(Random rnd, NeoFighter enemyNeoFighter);
        abstract public int Attack3(Random rnd, NeoFighter enemyNeoFighter);
    }
}

