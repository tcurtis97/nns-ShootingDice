using System;
using System.Collections.Generic;
using System.Linq;

namespace ShootingDice
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player1 = new Player();
            player1.Name = "Bob";

            Player player2 = new Player();
            player2.Name = "Sue";

            player2.Play(player1);

            Console.WriteLine("-------------------");

            Player player3 = new Player();
            player3.Name = "Wilma";

            player3.Play(player2);

            Console.WriteLine("-------------------");

            Player large = new LargeDicePlayer();
            large.Name = "Bigun Rollsalot";

            large.Play(player3);

            Console.WriteLine("-------------------");

            CreativeSmackTalkingPlayer smackTalkPlayer = new CreativeSmackTalkingPlayer();
            smackTalkPlayer.Name = "badmouth mcgee";

            smackTalkPlayer.Play(player3);

            Console.WriteLine("-------------------");

            OneHigherPlayer higherPlayer = new OneHigherPlayer();
            higherPlayer.Name = "vanquisher";

            higherPlayer.Play(player3);

            Console.WriteLine("-------------------");

            // HumanPlayer u = new HumanPlayer();
            // u.Name = "You";

            // player3.Play(u);

            Console.WriteLine("-------------------");

            SmackTalkingPlayer smack = new SmackTalkingPlayer();
            smack.Name = "smacky";
            smack.Taunt = "About to win me a new pair of shoes";

            smack.Play(player1);

            Console.WriteLine("-------------------");

            SoreLoserPlayer Loser = new SoreLoserPlayer();
            Loser.Name = "wack";

            Loser.Play(player1);

            Console.WriteLine("-------------------");

            UpperHalfPlayer Upper = new UpperHalfPlayer();
            Upper.Name = "Up";

            Upper.Play(player3);

            Console.WriteLine("-------------------");

            List<Player> players = new List<Player>() {
                player1, player2, player3, large, smackTalkPlayer, higherPlayer,  smack, Loser, Upper
            };

            PlayMany(players);
        }

        static void PlayMany(List<Player> players)
        {
            Console.WriteLine();
            Console.WriteLine("Let's play a bunch of times, shall we?");

            // We "order" the players by a random number
            // This has the effect of shuffling them randomly
            Random randomNumberGenerator = new Random();
            List<Player> shuffledPlayers = players.OrderBy(p => randomNumberGenerator.Next()).ToList();

            // We are going to match players against each other
            // This means we need an even number of players
            int maxIndex = shuffledPlayers.Count;
            if (maxIndex % 2 != 0)
            {
                maxIndex = maxIndex - 1;
            }

            // Loop over the players 2 at a time
            for (int i = 0; i < maxIndex; i += 2)
            {
                Console.WriteLine("-------------------");

                // Make adjacent players play noe another
                Player player1 = shuffledPlayers[i];
                Player player2 = shuffledPlayers[i + 1];
                player1.Play(player2);
            }
        }
    }
}