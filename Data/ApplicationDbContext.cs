using System;
using System.Collections.Generic;
using System.Text;
using GospelCares.Models;
using GospelCares.Models.ForIscholar;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace GospelCares.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Request> Requests { get; set; }
        public DbSet<Supply> Supplies { get; set; }
        public DbSet<EventReport> EventReports { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<TermlyDue> TermlyDues  { get; set; }
        public DbSet<GospelCares.Models.ForIscholar.Payment> Payment { get; set; }
    }
}
