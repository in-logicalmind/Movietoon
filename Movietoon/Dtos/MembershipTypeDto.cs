using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Movietoon.Dtos
{
    public class MembershipTypeDto
    {
        public short Id { get; set; }
        public string Description { get; set; }
    }
}