using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InvitacionWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace InvitacionWeb.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options){}

        public DbSet<Invitado> Invitados {get; set;}
    }
}