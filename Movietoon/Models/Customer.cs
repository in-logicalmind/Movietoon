using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Movietoon.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MobilePhone { get; set; }
        public string Email { get; set; }
        public short YearOfBirth { get; set; }
        public DateTime DateAdded { get; set; }
    }
}