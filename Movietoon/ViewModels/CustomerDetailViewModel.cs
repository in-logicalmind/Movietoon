using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Movietoon.Models;

namespace Movietoon.ViewModels
{
    public class CustomerDetailViewModel
    {
        public Customer Customer { get; set; }
        public IEnumerable<MembershipType> MembershipTypes { get; set; }
    }
}