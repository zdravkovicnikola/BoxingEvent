using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BoxingEvent.Models
{
    public class GrejnoTelo
    {
        public int GrejnoTeloId { get; set; }
        public string Naziv { get; set; }
        public string Tip { get; set; }
        public double Snaga { get; set; }
    }
}