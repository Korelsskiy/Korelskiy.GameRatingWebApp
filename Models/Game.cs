using Korelskiy.NextBlazor.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Korelskiy.NextBlazor.Models
{
    public class Game
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string MainDeveloper { get; set; }
        public Country Country { get; set; }
        public float KirillsPoints { get; set; }
        public Platform Platform { get; set; }
    }
}
