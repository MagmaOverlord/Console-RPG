﻿//HW: Create 2D projects
//https://repl.it/@Xander354/gameImages

using System;
using System.Collections.Generic;

namespace Console_RPG
{
    class Program
    {
        static void Main(string[] args)
        {
            Moves attackMoves = new Moves();

            Fighter player1 = new Wizard();
            Fighter player2 = new Assassin();

            List<Fighter> players = new List<Fighter>();
            List<Fighter> opponents = new List<Fighter>();

            players.Add(player1);
            players.Add(player2);

            opponents.Add(new Assassin());
            opponents.Add(new Wizard());

            BattleSystem testFight = new BattleSystem(players, opponents);
            
            int result = testFight.BattleLoop();

            if (result == 1) {
                Console.WriteLine("Enemies Won");
            } else if (result == 0) {
                Console.WriteLine("players Won");
            } else if (result == -1) {
                Console.WriteLine("Tie");
            }
        }
    }
}
