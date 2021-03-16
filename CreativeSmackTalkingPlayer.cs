using System.Collections.Generic;
using System;

namespace ShootingDice
{
    // A SmackTalkingPlayer who randomly selects a taunt from a list to say to the other player
    public class CreativeSmackTalkingPlayer : Player
    {
        public List<string> Talk { get; } = new List<string>()
        {
            "You are the reason they put instructions on shampoo.",
            "You are bad and you should feel bad",
            "Garbage",
            "You're an inspiration for birth control."
        };

        public override void Play(Player other)
        {
            int x = new Random().Next(Talk.Count);
            Console.WriteLine(Talk[x]);

            int myRoll = Roll();
            int otherRoll = other.Roll();

            Console.WriteLine($"{Name} rolls a {myRoll}");
            Console.WriteLine($"{other.Name} rolls a {otherRoll}");
            if (myRoll > otherRoll)
            {
                Console.WriteLine($"{Name} Wins!");
            }
            else if (myRoll < otherRoll)
            {
                Console.WriteLine($"{other.Name} Wins!");
            }
            else
            {
                // if the rolls are equal it's a tie
                Console.WriteLine("It's a tie");
            }
        }
    }
}