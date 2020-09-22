using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GameLibraryBlazorWA.Models
{
    public class GuessTheNumberGameModel
    {
        public int NumberToGuess { get; set; }
        [Range(0,int.MaxValue,ErrorMessage ="You must introduce a positive number")]
        public int PlayerGuess { get; set; }
        public int[] GuessingInterval { get; set; }
        public int AllowedTurns { get; set; }
        public bool isAWin { get; set; }
        public string GuessResult { get; set; }
    }
}
