using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS
{
    class Gesture
    {
        /**
         *              1                   3
         *Scissors cuts paper & Decapitates Lizard 
         *              2                5
         * Paper covers Rock & Disproves Spock
         *              4                0
         * Rock crushes Sissors & crushes Lizard
         *                5            1
         * Lizard eats paper & poisons Spock  
         *               0                      2
         * Spock smashes Scissors and vaporizes Rock
         */

        //name of Gestures
        public enum GestureName
        {
            Scissors = 0,
            Paper,
            Rock,
            Lizard,
            Spock
        }

        //jagged int array to store how each Gesture can win. Readonly and static as these are the same for all Gestures
        private static readonly int[][] winTable = new int[][] 
        { 
            new int[]{ 1, 3 }, //scissors
            new int[]{ 2, 4 }, //paper
            new int[]{ 0, 3 }, //rock
            new int[]{ 1, 4 }, //lizard
            new int[]{ 0, 2 }  //spock
        };

        //jagged string array with victory text for each gesture. Readonly and static as these are the same for all Gestures
        private static readonly string[][] winText = new string[][] 
        {
            new string[]{"cuts","decapitates"}, //scissors
            new string[]{"covers","disproves"}, //paper
            new string[]{"crushes", "crushes"}, //rock
            new string[]{"eats","poisions"},    //lizard
            new string[]{"smashes","vaporizes"} //spock
        };

        //store the users gesture choice
        private int gestureChoice;

        //constructor that takes the users choice
        public Gesture(GestureName gestureChoice)
        {
            //set instance variable to inputted choice
            this.gestureChoice = (int)gestureChoice;
        }

        //returns the win table for the selected gesture
        public int[] GeteWinTable()
        {
            return winTable[gestureChoice];
        }

        //returns the gesture choice
        public int GetChoice()
        {
            return gestureChoice;
        }

        //returns the winText for the selected choice
        public string[] GetWinText()
        {
            return winText[gestureChoice];
        }

        //Overridden ToString for use in displaying result
        public override string ToString()
        {
            return ((GestureName)gestureChoice).ToString();
        }
    }
}
