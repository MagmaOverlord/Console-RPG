using System;
using System.Collections.Generic;

namespace Console_RPG
{

    public class Moves {
        public Dictionary<string, Attack> attacks;

        public Moves() {
            attacks = new Dictionary<string, Attack>();

            attacks.Add("hit", new Attack(10, "hit"));
            attacks.Add("slam", new Attack(25, "slam"));
            attacks.Add("slit throat", new Attack(30, "slit throat"));
            attacks.Add("S U C C", new Attack(5, "S U C C"));
            attacks.Add("Hug", new Attack(-1, "Hug"));
            attacks.Add("Destroy Soul", new Attack(150, "Destroy Soul"));
        }

        public Attack GetMove(string name) {
            return attacks[name];
        }

        public void SetMove(string name, Attack value) {
            attacks[name] = value;
        }

        public Attack this[string name] {
            get => GetMove(name);
            set => SetMove(name, value);
        }
    }

}