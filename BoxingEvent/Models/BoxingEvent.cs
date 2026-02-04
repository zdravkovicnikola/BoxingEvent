using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BoxingEvent.Models
{
    public class BoxingEvent :DbContext
    {
        public BoxingEvent() : base("name=DBContext")
        {
            
        }
        public DbSet<GrejnoTelo> GrejnoTelo { get; set; }
    }
}