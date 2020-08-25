using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PlaviZabac.Models;

namespace PlaviZabac.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Film> Filmovi { get; set; }

        public DbSet<Zanr> Zanrovi { get; set; }

        public DbSet<Prodavnica> Prodavnice { get; set; }
    }
}
