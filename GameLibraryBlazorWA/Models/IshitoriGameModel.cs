using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GameLibraryBlazorWA.Models
{
    public class IshitoriGameModel
    {
        public int CpRetrieve { get; set; }
        [Required]
        [Range(1,3,ErrorMessage ="The number must be between 1 and 3 for this game")]
        public int PlayerRetrieve { get; set; } = 0;
        public int CpPreviousRetrieve { get; set; } = 0;
        public int PlayerPreviousRetrieve { get; set; } = 0;
        public int PiecesLeft { get; set; } = 0;
        public bool isAWin { get; set; } = false;
        public int InitialPieces { get; set; } = 0;
        public bool IsCpTurn { get; set; } = false;
    }
}
