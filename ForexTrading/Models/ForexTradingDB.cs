using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ForexTrading.Models
{
    public class ForexTradingDB : DbContext
    {
        public ForexTradingDB() : base("name=DefaultConnection")
        {

        }

        public DbSet<Forex> Forex { get; set; }
        public DbSet<Binary> Binary { get; set; }
    }
}