using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Makale.Models.Siniflar
{
    public class Context: DbContext
    {
        public DbSet<MakaleData> Makales { get; set; }
    }
}