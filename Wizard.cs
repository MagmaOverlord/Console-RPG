using System;
using System.Collections.Generic;


namespace Console_RPG
{
    public class Wizard: Fighter {
        public Wizard(): base("Wizard", 100) {
            Moves attacks = new Moves();

            moves.Add(attacks["S U C C"]);
            moves.Add(attacks["Destroy Soul"]);

        }
    }
}