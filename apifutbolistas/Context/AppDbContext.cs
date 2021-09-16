using apifutbolistas.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace apifutbolistas.context
{
    public class AppDbContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext>Options):base (Options)
            
            {

            }
    public .DbSet<futbolista> Futbolistas { get; set; }
    }
}
