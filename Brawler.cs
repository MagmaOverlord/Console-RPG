using System;
using System.Collections.Generic;


namespace Console_RPG
{
    public class Brawler: Fighter {
        public Brawler(): base("Brawler", 200) {
            Moves attacks = new Moves();

            moves.Add(attacks["hit"]);
            moves.Add(attacks["slit throat"]);
            moves.Add(attacks["slam"]);
        }
    }
}