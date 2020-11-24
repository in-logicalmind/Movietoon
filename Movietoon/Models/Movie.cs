using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.AccessControl;
using System.Web;

namespace Movietoon.Models
{
    public class Movie
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MaxLength(200)]
        [Display(Name = "Movie's Title")]
        public string Title { get; set; }

        [Required]
        [Range(1900,2020)]
        [Display(Name = "Release Year")]
        public short ReleaseYear { get; set; }

        public DateTime DateAdded { get; set; }

        [Display(Name = "Movie's Genre")]
        public Genre Genre { get; set; }
        public int GenreId { get; set; }

        [Required]
        [Display(Name = "Unitary Cost")]
        public float Price { get; set; }

        [Required]
        [Display(Name = "Available Units")]
        public int AmountAvailable { get; set; }

        public int AvailableForRental { get; set; }
    }
}