using Microsoft.EntityFrameworkCore;
using MMN.DL.Interfaces;
using MMN.DL.Models;

namespace MMN.DL;

internal class Context : DbContext, IAppDb {
    internal Context(DbContextOptions<Context> options) : base(options) {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder) {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(Context).Assembly,
            t => t is { IsAbstract: false, IsInterface: false }
        );
    }

    public DbSet<Company> Companies { get; set; }
    public DbSet<Profile> Profiles { get; set; }
    public DbSet<Site> Sites { get; set; }
    public DbSet<SystemPlan> SystemPlans { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<UserProfile> UserProfiles { get; set; }
}