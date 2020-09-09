using System;
using System.Collections.Generic;


namespace Console_RPG
{
    public class Assassin: Fighter {
        public Assassin(): base("Assassin", 80) {
            Moves attacks = new Moves();

            moves.Add(attacks["hit"]);
            moves.Add(attacks["slit throat"]);
        }
    }
}