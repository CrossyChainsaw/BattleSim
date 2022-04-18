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

        public override int Attack1(Random rnd, NeoFighter enemyNeoFighter)
        {
            //wooden fist
            //10% to increase attackPower by 1
            throw new NotImplementedException();
        }
        public override int Attack2(Random rnd, NeoFighter enemyNeoFighter)
        {
            //mimic
            //learn enemies' last used move
            throw new NotImplementedException();
        }
        public override int Attack3(Random rnd, NeoFighter enemyNeoFighter)
        {
            //ingrain
            //heal 10 health every turn for 3 turns
            throw new NotImplementedException();
        }
    }
}
