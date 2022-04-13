using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.NeoFighters
{
    public class Grarrl : NeoFighter
    {
        public Grarrl()
        {
            Name = NeoFighterNames.Grarrl;
            Health = 320;
            AttackPower = 32;
            CritRatio = 5;
        }

        public override int Attack1(Random rnd, int attackPower, NeoFighter enemyNeoFighter)
        {
            throw new NotImplementedException();
        }
        public override int Attack2(Random rnd, int attackPower, NeoFighter enemyNeoFighter)
        {
            throw new NotImplementedException();
        }
        public override int Attack3(Random rnd, int attackPower, NeoFighter enemyNeoFighter)
        {
            throw new NotImplementedException();
        }
    }
}
