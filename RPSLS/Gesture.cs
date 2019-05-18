using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS
{
    //name of Gestures
    public enum GestureName
    {
        MinValue = Scissors,//Min Max are first as if they are last the ToString method outputs MinValue instead of Scissors
        MaxValue = Spock + 1,//If extra gestures are added this will need adjusted
        Scissors = 0,
        Paper,
        Rock,
        Lizard,
        Spock
    }

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
         
        //jagged GestureName array to store how each Gesture can win. Readonly and static as these are the same for all Gestures
        private static readonly GestureName[][] winTable = new GestureName[][] 
        { 
            new GestureName[]{ GestureName.Paper, GestureName.Lizard }, //scissors
            new GestureName[]{ GestureName.Rock, GestureName.Spock }, //paper
            new GestureName[]{ GestureName.Scissors, GestureName.Lizard }, //rock
            new GestureName[]{ GestureName.Paper, GestureName.Spock }, //lizard
            new GestureName[]{ GestureName.Scissors, GestureName.Rock }  //spock
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
        private GestureName gestureChoice;

        //constructor that takes the users choice
        public Gesture(GestureName gestureChoice)
        {
            //set instance variable to inputted choice
            this.gestureChoice = gestureChoice;
        }

        //returns the win table for the selected gesture
        public GestureName[] GeteWinTable()
        {
            return winTable[(int)gestureChoice];
        }

        //returns the gesture choice
        public GestureName GetChoice()
        {
            return gestureChoice;
        }

        //returns the winText for the selected choice
        public string[] GetWinText()
        {
            return winText[(int)gestureChoice];
        }

        //Overridden ToString for use in displaying result
        public override string ToString()
        {
            return (gestureChoice).ToString();
        }
    }
}
