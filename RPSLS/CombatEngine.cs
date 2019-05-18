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
            GestureName[] combat1WinTab = combatant1.GeteWinTable();
            GestureName[] combat2WinTab = combatant2.GeteWinTable();
            
            //get the gesture choice for each combatant
            GestureName combatant1Choice = combatant1.GetChoice();
            GestureName combatant2Choice = combatant2.GetChoice();

            //win lose draw strings
            string userWin = "You Win!";
            string userLose = "You Lost!";
            string userDraw = "You Drew... ";

            //combatant1 win condition check loop this is the User
            for (int i = 0; i < combat1WinTab.Length; i++)
            {
                //if the 
                if (combatant2Choice == combat1WinTab[i])
                {
                    return string.Concat(userWin, winTextGenerator(i, combatant1, combatant2));
                }
            }
            //combatant2 win condition check loop this is the random selection
            for (int i = 0; i < combat2WinTab.Length; i++)
            {
                if (combatant1Choice == combat2WinTab[i])
                {
                    return string.Concat(userLose, winTextGenerator(i, combatant2, combatant1));
                }
            }

            return string.Concat(userDraw,combatant1," VS ",combatant2);
        }

        //win text generator determines the win text to return
        private string winTextGenerator(int winCode, Gesture winner, Gesture loser)
        {
            // returns the win text with spaces around it to add on the gesture names
            return String.Concat(" ",winner," ",winner.GetWinText()[winCode]," ",loser);
        }
    }
}
