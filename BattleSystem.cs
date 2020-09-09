using System;
using System.Collections.Generic;
using System.Linq;

namespace Console_RPG
{
    class BattleSystem
    {
       
        public List<Fighter> players;
        public List<Fighter> opponents;
        public Dictionary<Attack, Fighter> movesList;
        private Random movePicker;
        private bool stillFighting, playersLost, opponentsLost;

        public BattleSystem(List<Fighter>_players, List<Fighter>_opponents) {
            players = _players;
            opponents = _opponents;
            movesList = new Dictionary<Attack, Fighter>();
            movePicker = new System.Random();
            stillFighting = true;
            playersLost = false;
            opponentsLost = false;
        }

        private void ExecuteMoves() {
            for (int i=0;i<movesList.Count;i++) {
                Attack a = movesList.ElementAt(i).Key;
                Fighter target = movesList[a];

                a.UseAttack(target);

                Console.WriteLine(String.Format("{0} took {1} damage and "+ "has {2} health remaining \n", target.name, a.getDamage(), target.health));
            }
            movesList.Clear();
        }

        public int BattleLoop() {
            //List attacks, what player chooses, execute attacks. Opponent chooses attack, opponent executes attacks, output results.
            while(stillFighting) {
                playersLost = true;

                foreach(Fighter player in players) {
                    if (player.health <= 0) {
                        continue;
                    }

                    playersLost = false;

                    List<Attack> moves = player.GetMoves();

                    Console.WriteLine("Choose an attack: ");
                    
                    foreach (Attack move in moves) {
                        Console.WriteLine(move.GetName());
                    }

                    int choice = Int32.Parse(Console.ReadLine());

                    Attack chosenAttack = moves[choice - 1];

                    foreach (Fighter opponent in opponents) {
                        Console.WriteLine(opponent.name);
                    }

                    int opponentChoice = Int32.Parse(Console.ReadLine());

                    Fighter target = opponents[opponentChoice - 1];

                    movesList.Add(chosenAttack, target);
                }

                foreach(Fighter opponent in opponents) {
                    if (opponent.health <= 0) {
                        continue;
                    }

                    opponentsLost = false;

                    List<Attack> moves = opponent.GetMoves();

                    int choice = movePicker.Next();

                    Attack chosenAttack = moves[choice - 1];

                    int opponentChoice = movePicker.Next();

                    Fighter target = opponents[opponentChoice - 1];

                    movesList.Add(chosenAttack, target);
                }

                ExecuteMoves();
            }
            if (playersLost) {
                return 0;
            } else {
                return -1;
            }

        }
    }
}