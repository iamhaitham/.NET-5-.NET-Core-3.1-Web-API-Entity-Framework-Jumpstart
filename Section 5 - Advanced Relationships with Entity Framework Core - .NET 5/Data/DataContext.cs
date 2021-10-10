using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Section_1___Introduction___.NET_5.Models;

namespace Section_1___Introduction___.NET_5.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        public DbSet<Character> Characters { set; get; }
        public DbSet<User> Users { set; get; }
        public DbSet<Weapon> Weapons { set; get; }
        public DbSet<Skill> Skills { set; get; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Skill>().HasData(
                new Skill() { Id = 1, Name = "Fireball", Damage = 30 },
                new Skill() { Id = 2, Name = "Frenzy", Damage = 20 },
                new Skill() { Id = 3, Name = "Blizzard", Damage = 50 }
            );
        }
    }
}