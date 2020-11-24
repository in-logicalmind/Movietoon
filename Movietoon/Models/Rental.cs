using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Http.Routing.Constraints;

namespace Movietoon.Models
{
    public class Rental
    {
        [Required]
        public int Id { get; set; }
        public Customer Customer { get; set; }
        public Movie Movie { get; set; }
        public DateTime RentedDate { get; set; }
        public DateTime? ReturnedDate { get; set; }
        public float TotalAfterDiscount { get; set; }
    }
}