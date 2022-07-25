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
    // Enum for single player/multiplayer
    public enum Mode { Singleplayer, Multiplayer};
    public class VideoGame
    {
        // Create variables for Name, Designer, ReleaseYear, Genre, and GameMode:
        public string Name { get; set; }
        public string Designer { get; set; }
        public int ReleaseYear { get; set; }
        public string Genre { get; set; }
        public Mode GameMode { get; set; }
        // VideoGame
        // Constructor for VideoGame with parameters
        public VideoGame(string name, string designer, int releaseYear, string genre, Mode gameMode)
        {
            Name = name;
            Designer = designer;
            ReleaseYear = releaseYear;
            Genre = genre;
            GameMode = gameMode;
        }
        // VideoGame
        // Constructor for VideoGame w/o parameters
        // All properties set to reasonable defaults
        public VideoGame()
        {
            Name = "Name";
            Designer = "Acme";
            ReleaseYear = 1980;
            Genre = "Genre";
            GameMode = Mode.Multiplayer;
        }
    }
}

