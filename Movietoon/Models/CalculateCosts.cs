using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Movietoon.Models
{
    public class CalculateCosts
    {
        public MembershipType MembershipType { get; set; }
        public Movie Movie { get; set; }

        public float CalculateCostsMovie(MembershipType membershipType, Movie movie)
        {
            var pct = (float)membershipType.DiscountPct/100;
            var price = movie.Price;
            return price * (1 - pct);
        }
    }
}