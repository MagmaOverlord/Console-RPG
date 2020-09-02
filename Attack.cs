using System;
using System.Collections.Generic;


namespace Console_RPG
{

    public class Attack {
        int damage;
        string name;

        public Attack(int _damage, string _name) {
            damage = _damage;
            name = _name;
        }

        public string GetName() {
            return name;
        }

        public void UseAttack(Fighter target) {
            target.health -= damage;
        }

        public int getDamage() {
            return damage;
        }
    }

}