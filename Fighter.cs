using System;
using System.Collections.Generic;


namespace Console_RPG
{
    public class Fighter {

        public string name;        
        public int health;
        public List<Attack> moves;
        public Fighter(string _name, int _health) {
            name = _name;
            health = _health;
            moves = new List<Attack>();
        }

        public List<Attack> GetMoves() {
            return moves;
        }
    }

}