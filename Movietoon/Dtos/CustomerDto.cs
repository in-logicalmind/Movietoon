using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using Movietoon.Models;

namespace Movietoon.Dtos
{
    public class CustomerDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MobilePhone { get; set; }
        public string Email { get; set; }
        public short YearOfBirth { get; set; }
        public DateTime DateAdded { get; set; }
        public MembershipTypeDto MembershipType { get; set; }
        public short MembershipTypeId { get; set; }
    }
}