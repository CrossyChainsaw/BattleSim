using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.NeoFighters
{
    public class Grarrl : NeoFighter
    {

        NeoFighterNames _name = NeoFighterNames.Grarrl;
        int _health = 320;
        int _attackPower = 32;
        int _critRatio = 5;

        public Grarrl()
        {
            Name = _name;
            Health = _health;
            AttackPower = _attackPower;
            CritRatio = _critRatio;
            Attack1Name = "Focus";
            Attack2Name = "Bite (wip)";
            Attack3Name = "Fury Rush";
        }

        public override int Attack1(Random rnd, NeoFighter enemyNeoFighter)
        {
            //focus
            //increase attackPower by 4
            GainAttackPower(4);
            return 0;
        }
        public override int Attack2(Random rnd, NeoFighter enemyNeoFighter)
        {
            //bite
            //20% to make enemy miss next attack
            throw new NotImplementedException();
        }
        public override int Attack3(Random rnd, NeoFighter enemyNeoFighter)
        {
            //dragon rush
            //25% extra damage boost
            int damage = Attack(rnd, _attackPower);
            damage = damage * 125 / 100;
            return damage;
        }
    }
}
