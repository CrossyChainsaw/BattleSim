using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.NeoFighters
{
    public class Blumaroo : NeoFighter
    {
        public Blumaroo()
        {
            Name = NeoFighterNames.Blumaroo;
            Health = 300;
            AttackPower = 29;
            CritRatio = 10;
        }

        public override int Attack1(Random rnd, int attackPower)
        {
            throw new NotImplementedException();
        }
        public override int Attack2(Random rnd, int attackPower)
        {
            throw new NotImplementedException();
        }
        public override int Attack3(Random rnd, int attackPower)
        {
            throw new NotImplementedException();
        }
    }
}
