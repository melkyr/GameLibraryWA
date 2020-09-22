using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GameLibraryBlazorWA.Models
{
    public class CreateGameModel
    {
        [Required]
        public int[] GameInterval { get; set; } =new int[]{ 0, 10 };
        public string SelectedGame { get; set; } = "";
    }
}
