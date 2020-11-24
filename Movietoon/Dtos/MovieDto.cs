using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using Movietoon.Models;

namespace Movietoon.Dtos
{
    public class MovieDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public short ReleaseYear { get; set; }
        public DateTime DateAdded { get; set; }
        public GenreDto Genre { get; set; }
        public int GenreId { get; set; }
        public float Price { get; set; }
        public int AmountAvailable { get; set; }
    }
}