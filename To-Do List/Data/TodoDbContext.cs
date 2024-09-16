﻿using Microsoft.EntityFrameworkCore;
using To_Do_List.Models;

namespace To_Do_List.Data
{
    public class TodoDbContext : DbContext
    {
        public TodoDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<TodoItem> TodoItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<TodoItem>(entity =>
            {
                entity.Property(e => e.Title)
                    .HasMaxLength(200)
                    .IsRequired();

                entity.Property(e => e.Description)
                    .HasMaxLength(1000);

                entity.Property(e => e.CreatedAt)
                    .HasDefaultValueSql("GETDATE()");

                entity.HasIndex(e => e.IsComplete);
            });
            
        }
    }
}
