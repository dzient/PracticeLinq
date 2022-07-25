// See https://aka.ms/new-console-template for more information
using System;
using System.Linq;
//-----------------------------------------------------------------
// Practice Linq
//
// Name: David Zientara
// Date: 7-25-2022
// Comments: An exercise in using Linq, part 1
// Added methods per the instructions
//-----------------------------------------------------------------

namespace PracticeLinq
{
    public class Program
    {
        public static void Main()
        {
            // Managed to get it to one line:
            var videolist = CreateGames();
            Console.WriteLine("Here's a list of videogames, ordered by length of the game name:");
            videolist.ToArray().OrderBy(x => x.Name.Length).ToList().ForEach(x => Console.WriteLine(x.Name));
        }


       
        
        #region CreateVideogamesMethod
        // Create a list of classic videogames
        private static List<VideoGame> CreateGames()
        {
            List<VideoGame> list = new List<VideoGame>();
            list.Add(new VideoGame("Pong","Atari",1972,"Sports",Mode.Multiplayer));
            list.Add(new VideoGame("Space Invaders", "Taito", 1978, "Shoot 'em up", Mode.Singleplayer));
            list.Add(new VideoGame("Galaxian", "Namco", 1979, "Fixed shooter", Mode.Singleplayer));
            list.Add(new VideoGame("Gorf", "Midway", 1981, "Fixed shooter", Mode.Singleplayer));
            list.Add(new VideoGame("Qix", "Taito", 1981, "Puzzle", Mode.Singleplayer));
            list.Add(new VideoGame("Pole Position", "Namco/Atari", 1982,"Racing", Mode.Singleplayer));
            list.Add(new VideoGame("Omega Race", "Midway", 1981, "Shoot 'em up", Mode.Singleplayer));
            list.Add(new VideoGame("Asteroids", "Atari", 1979, "Multidirectional shooter", Mode.Singleplayer));
            list.Add(new VideoGame("Centipede", "Atari", 1981, "Fixed shooter", Mode.Singleplayer));
            list.Add(new VideoGame("Pac-Man", "Namco", 1980, "Maze", Mode.Singleplayer));
            list.Add(new VideoGame("Q-Bert", "Gottlieb", 1982, "Action", Mode.Multiplayer));
            list.Add(new VideoGame("Frogger", "Sega", 1981, "Action", Mode.Singleplayer));
            list.Add(new VideoGame("Zaxxon","Sega",1981,"Scrolling shooter",Mode.Singleplayer));
            list.Add(new VideoGame("Missile Command","Atari", 1980, "Shoot 'em up", Mode.Singleplayer));
            list.Add(new VideoGame("Yars' Revenge", "Atari",1982,"Multidirection shooter",Mode.Singleplayer));
            list.Add(new VideoGame("Donkey Kong","Nintendo",1981,"Platform",Mode.Singleplayer));


            return list;
        }
        #endregion
    }
}