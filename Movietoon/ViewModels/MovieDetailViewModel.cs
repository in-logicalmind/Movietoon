using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Movietoon.Models;

namespace Movietoon.ViewModels
{
    public class MovieDetailViewModel
    {
        public Movie Movie { get; set; }
        public IEnumerable<Genre> Genres { get; set; }
    }
}