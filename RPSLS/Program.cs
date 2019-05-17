using System;

namespace RPSLS
{
    class Program
    {

        static void Main(string[] args)
        {
            //create new instance of the random class 
            Random rand = new Random();
            //store the random selection
            int compSelection = rand.Next(5);
            //talk to user
            Console.WriteLine("Welcome to Rock Paper Sissors Lizard Spock!");
            Console.WriteLine("Please Select Your Metaphorical Weapon");
            //loop over enum
            for (int i = 0; i < 5; i++)
            {
                //print out enum strings
                Console.WriteLine("{0}){1}",i+1,(GestureName)i);
            }
            //declare and initilize variables
            string input = "";
            int userSelction = -1;
            //do this while the users selection is outside the range
            do
            {
                Console.WriteLine("Please enter number between 1-5");
                //take input from console
                input = Console.ReadLine();
                //try to get an integer from input
                int.TryParse(input, out userSelction);
            } while (userSelction > 5 || userSelction < 1);

            //create a new instance of the Gesture class with the users selection - 1 as we lied to the user about numbers
            Gesture gest1 = new Gesture((GestureName)userSelction-1);
            //create the random selections gesture
            Gesture gest2 = new Gesture((GestureName)compSelection);
            //create a combat engine with the gestures
            CombatEngine combat = new CombatEngine(gest1, gest2);
            //output the result of the fight
            Console.WriteLine(combat.Fight());
        }


    }
}
