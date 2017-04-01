using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace films.Models
{
    public class FilmsContext:DbContext
    {
        public FilmsContext() : base("Films") { }
        public DbSet<Films> Films { get; set; }
    }
}