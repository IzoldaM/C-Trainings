using DiceGame.Game_Units;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiceGame.Controllers;

namespace DiceGame.Controllers
{
    class GameController
    {
        int numberOfPlayers;
        int numberofDices;
        DiceD6 myDice;
        List<Player> myListofPlayers = new List<Player>();
        List<DiceGroup> myListofDiceRolls = new List<DiceGroup>();
        public GameController(int numberofPlayers, int numberofDices)
        {
            this.numberOfPlayers = numberofPlayers;
            this.numberofDices = numberofDices;
            myDice = new DiceD6();
            for (int i = 1; i <= numberOfPlayers; i++)
            {
                myListofPlayers.Add(new Player("Player" + Convert.ToString(i), i));
                myListofDiceRolls.Add(new DiceGroup("Player" + Convert.ToString(i)));
            }
        }

        public void StartGame()
        {
            Console.Clear();
            for (int i = 1; i <= numberofDices; i++)
            {
                Console.WriteLine($"Each player rolls {i} round:");
                EachPlayerRollsTheDice();
                System.Threading.Thread.Sleep(750);

            }
            bool numberOfWinnersInGame;
            numberOfWinnersInGame = CheckIfMoreThanOneWinner();
            do
            {
                if (numberOfWinnersInGame == false)
                {
                    
                }
                else
                {
                    Console.WriteLine("Extra dice roll requested");
                    EachPlayerRollsTheDice();
                    System.Threading.Thread.Sleep(750);
                    numberOfWinnersInGame = CheckIfMoreThanOneWinner();
                }


            } while (numberOfWinnersInGame != false);

            GetWinnerName();




        }

        public void EachPlayerRollsTheDice()
        {
            for (int i = 0; i < myListofPlayers.Count; i++)
            {
                int roll = myDice.RollTheDice();
                Console.WriteLine($"{myListofPlayers[i].Name} rolled number {roll}");
                myListofDiceRolls[i].groupOfDices.Add(roll);
            }
        }

        public int FindMaximumRollSum()
        {
            List<int> listOfSums = new List<int>();
            for (int i = 0; i < myListofPlayers.Count; i++)
            {
                listOfSums.Add(myListofDiceRolls[i].SumOfDices());
            }

            return listOfSums.Max();
        }

        public bool CheckIfMoreThanOneWinner()
        {

            int numberofWinners = 0;
            List<string> nameofWinners = new List<string>();
            for (int i = 0; i < myListofPlayers.Count; i++)
            {
                if (myListofDiceRolls[i].SumOfDices() == FindMaximumRollSum())
                {
                    numberofWinners += 1;
                    nameofWinners.Add(myListofPlayers[i].Name);
                }

            }
            if (numberofWinners == 1)
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        public void GetWinnerName()
        {

            string nameofWinner = null;
            for (int i = 0; i < myListofPlayers.Count; i++)
            {
                if (myListofDiceRolls[i].SumOfDices() == FindMaximumRollSum())
                {
                    nameofWinner = myListofPlayers[i].Name;
                }

            }
            Console.WriteLine($"Winner is {nameofWinner}");

        }
    }
}
