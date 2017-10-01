using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace MolopolyGame
{
    public class Jail
    {
        public Player _player { get; set; }//automated property

        Player[] playersInJail = new Player[8];//arrayList of players in jail
        
        public Jail(Player _player)
        {
            this._player = _player;
            //loop through array and assign new player to the next empty index
            for(int i = 0; i <= playersInJail.Length; i++)
            {
                if(playersInJail[i] == null)
                {
                    playersInJail[i] = _player;
                }                
            }
        }

        public override string ToString()
        {
            return string.Format("You ({0}) are in jail!", _player.getName());
        }
    }
}
