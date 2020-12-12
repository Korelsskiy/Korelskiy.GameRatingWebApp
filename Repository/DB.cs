using Korelskiy.NextBlazor.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Korelskiy.NextBlazor.Repository
{
    public class DB : DbContext
    {
        public DB(DbContextOptions<DB> options): base(options) { }

        public DbSet<Game> Games { get; set; }
    }
}
