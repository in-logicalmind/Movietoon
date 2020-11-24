using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Movietoon.Models
{
    public class CurrentDate
    {
        public CurrentDate()
        {
            this.YearOfToday = DateTime.Now.Year;
        }
        public int YearOfToday;
    }
}