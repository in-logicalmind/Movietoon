using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Movietoon.Models
{
    public class Customer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        [Display(Name = "First Name")]
        
        public string FirstName { get; set; }

        [Required]
        [MaxLength(100)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Phone]
        [Display(Name = "Cell phone number")]
        public string MobilePhone { get; set; }

        [EmailAddress]
        [Display(Name = "Email Address")]
        public string Email { get; set; }

        [Required]
        [Range(1900, 2020)]
        [Display(Name = "Year of birth")]
        [AdultAgeConfirmationValidation]
        public short YearOfBirth { get; set; }
        public DateTime DateAdded { get; set; }

        [Display(Name = "Membership type")]
        public MembershipType MembershipType { get; set; }
        public short MembershipTypeId { get; set; }

    }

}