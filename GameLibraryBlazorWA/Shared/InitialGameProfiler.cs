using GameLibraryBlazorWA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameLibraryBlazorWA.Shared
{
    public class InitialGameProfiler
    {
        public GuessTheNumberGameModel NumberGuessGame { get; set; }
        public IshitoriGameModel IshitoriGame { get; set; }

        public void Reset()
        {
            IshitoriGame = new IshitoriGameModel();
            NumberGuessGame = new GuessTheNumberGameModel();
        }
    }
}
