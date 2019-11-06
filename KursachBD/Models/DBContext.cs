﻿using KursachBD.Models.DataBaseModel;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KursachBD.Models
{
    public class DBContext : IdentityDbContext<User>
    {
        public DbSet<Film> Films { get; set; }
        public new DbSet<UserRole> UserRoles { get; set; }

        public DBContext (DbContextOptions<DBContext> options):base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<AspNetUserRoles>().HasKey(p => new { p.UserId, p.RoleId });
            base.OnModelCreating(modelBuilder);
        }
    }
}
