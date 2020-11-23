using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Web;

namespace Movietoon.Models
{
    public class Movie
    {
        
        public int Id { get; set; }
        public string Title { get; set; }
        public short ReleaseYear { get; set; }
        public DateTime DateAdded { get; set; }
        public Genre Genre { get; set; }
        public int GenreId { get; set; }
    }
}