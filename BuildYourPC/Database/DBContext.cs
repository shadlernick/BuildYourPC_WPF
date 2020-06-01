﻿using BuildYourPC.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace BuildYourPC.Database
{
    public class DBContext : DbContext
    {
        public DBContext() { }

        public DbSet<CPU> CPUs { get; set; }
        public DbSet<GraphicCard> GraphicCards { get; set; }
        public DbSet<Memory> Memories { get; set; }
        public DbSet<Motherboard> Motherboards { get; set; }
        public DbSet<PowerSupply> PowerSupplies { get; set; }
        public DbSet<RAM> RAMs { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Computer> Computers { get; set; }
    }
}
