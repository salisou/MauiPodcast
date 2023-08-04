﻿using LoginAppApi.Models;
using Microsoft.EntityFrameworkCore;

namespace LoginAppApi.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; } = default!;
    }
}
