using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Estudo.Models
{
    public class DBContext : DbContext
    {
        public DbSet<Pessoa> Pessoas { get; set; }
    }
}