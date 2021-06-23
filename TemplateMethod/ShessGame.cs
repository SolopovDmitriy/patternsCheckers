using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethod
{
    class ShessGame : Game
    {
        public ShessGame(int players):base(players)
        {

        }
        public override bool CheckWinner()
        {
            throw new NotImplementedException();
        }

        public override void NextStep()
        {
            throw new NotImplementedException();
        }

        public override void Start()
        {
            throw new NotImplementedException();
        }
    }
}
