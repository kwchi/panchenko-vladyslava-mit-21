﻿using lab_10.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace lab_10.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {

        public DbSet<Book> Books { get; set; }
        public DbSet<Purchase> Purchases { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}