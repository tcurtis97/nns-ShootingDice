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
            int x = new Random().Next(6) + 1;
            Console.WriteLine(Talk[x]);
            base.Play(other);
        }
    }
}