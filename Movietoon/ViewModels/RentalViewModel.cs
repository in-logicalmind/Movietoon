using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services.Protocols;
using Movietoon.Models;

namespace Movietoon.ViewModels
{
    public class RentalViewModel
    {
        public Customer Customer { get; set; }
        public Movie Movie { get; set; }
        public IEnumerable<Rental> Rentals { get; set; }

    }
}