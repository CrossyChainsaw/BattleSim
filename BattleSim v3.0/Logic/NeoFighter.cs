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

    public class NeoFighter
    {
        public Random rnd = new Random();

        public NeoFighterNames Name { get; private set; }
        public int Health { get; private set; }
        public int AttackPower { get; private set; }
        public int CritRatio { get; private set; }

        internal void SetName(NeoFighterNames name)
        {
            Name = name;
        }
        internal void SetHealth(int health)
        {
            Health = health;
        }
        internal void SetAttackPower(int attackPower)
        {
            AttackPower = attackPower;
        }
        /// <summary>Chance in percentage. Example 30 means 30%</summary>
        internal void SetCritRatio(int critRatio)
        {
            CritRatio = critRatio;
        }

        public void LoseHealth(int damage)
        {
            Health = Health - damage;
        }
        public int Attack(Random rnd, int attackpower)
        {
            int attackModifier = rnd.Next(-2, 3);
            return attackpower + attackModifier;
        }
    }
}

