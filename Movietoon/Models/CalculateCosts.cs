using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Movietoon.Models
{
    public class CalculateCosts
    {
        private MembershipType MembershipType { get; set; }
        private Movie Movie { get; set; }

        public float CalculateCostsMovie(MembershipType membershipType, Movie movie)
        {
            var pct = membershipType.DiscountPct;
            var price = movie.Price;
            return (price * (1-(pct / 100)));
        }
    }
}