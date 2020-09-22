using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Threading.Tasks;

namespace GameLibraryBlazorWA.Models
{
    public class GameIntervalModel
    {
        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DataAnnotations.Range(0, int.MaxValue, ErrorMessage = "You must use with a positive value")]
        public int LowInterval { get; set; }
        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DataAnnotations.Range(0, int.MaxValue, ErrorMessage = "You must use with a positive value")]
        public int HighInterval { get; set; }
    }
}
