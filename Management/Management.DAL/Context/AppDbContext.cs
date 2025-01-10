using Management.Core.Entities;
using Management.Core.Entitiesl;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management.DAL.Context;
public class AppDbContext : DbContext
{
    public DbSet<Assignment> Assignments { get; set; }
    public DbSet<AssignmentTag> AssignmentTags { get; set; }
    public DbSet<Tag> Tags { get; set; }
    public DbSet<Topic> Topics { get; set; }
    public DbSet<Employee> Employees { get; set; }

    public AppDbContext(DbContextOptions<AppDbContext> opt) : base(opt) { }
}
