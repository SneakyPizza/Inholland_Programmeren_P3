﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht3
{
    class YahtzeeGame
    {
        private Dice[] _dices;
        

        public YahtzeeGame()
        {
            Random r = new Random();
            _dices = new Dice[5];

            for (int i = 0; i < _dices.Length; i++)
            {
                _dices[i] = new Dice(r);
            }
        }

        public void Throw()
        {
            for(int i = 0; i < _dices.Length; i++)
            {
                _dices[i].Throwdice(_dices[i]);
            }
            
        }

        public void ShowValues()
        {
            foreach( Dice d in _dices)
            {
                d.ShowValue();
            }
            Console.Write("\n");
        }

        public bool Yahtzee()
        {
            int firstvalue = _dices.First().value;

            for(int i = 0; i < _dices.Length; i++)
            {
                if(_dices[i].value != firstvalue)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
