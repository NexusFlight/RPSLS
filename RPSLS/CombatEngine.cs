using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS
{
    class CombatEngine
    {
        //instance variables for each gesture 
        private Gesture combatant1;
        private Gesture combatant2;

        //constructor that takes the two gestures
        public CombatEngine(Gesture combatant1, Gesture combatant2)
        {
            this.combatant1 = combatant1;
            this.combatant2 = combatant2;
        }

        //fight method determines the winner and returns the winners text
        public string Fight()
        {
            //get the gestures winTables
            int[] combat1WinTab = combatant1.GeteWinTable();
            int[] combat2WinTab = combatant2.GeteWinTable();
            string userWin = "You Win!";
            string userLose = "You Lost!";
           //combatant 1s win conditions
            if (combatant2.GetChoice() == combat1WinTab[0])
            {
               return string.Concat(userWin,winTextGenerator(0, combatant1,combatant2));
            }
            else if(combatant2.GetChoice() == combat1WinTab[1])
            {
                return string.Concat(userWin, winTextGenerator(1, combatant1, combatant2));
            }
            //combatant 2s win conditions
            else if (combatant1.GetChoice() == combat2WinTab[0])
            {
                return string.Concat(userLose, winTextGenerator(0, combatant2, combatant1));
            }
            else if (combatant1.GetChoice() == combat2WinTab[1])
            {
                return string.Concat(userLose, winTextGenerator(1, combatant2, combatant1));
            }

            return string.Concat("You Drew... ",combatant1," VS ",combatant2);
        }

        //win text generator determines the win text to return
        private string winTextGenerator(int winCode, Gesture winner, Gesture loser)
        {
            // returns the win text with spaces around it to add on the gesture names
            return String.Concat(" ",winner," ",winner.GetWinText()[winCode]," ",loser);
        }
    }
}
