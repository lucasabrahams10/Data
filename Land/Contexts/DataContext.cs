using LandLord.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace LandLord.Contexts;

internal class DataContext : DbContext
{
    private readonly string _connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Peter\Desktop\webbutveckling_inom_.net\Datalagring\Hans\DataStorage\LandLord\Contexts\landlord_db.mdf;Integrated Security=True;Connect Timeout=30";

    #region constructors

    public DataContext()
    {

    }

    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
    }

    #endregion

    #region overrides

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
            optionsBuilder.UseSqlServer(_connectionString);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<EmployeEntity>()
            .HasOne(e => e.Person)
            .WithMany()
            .OnDelete(DeleteBehavior.Restrict);
        modelBuilder.Entity<TenantEntity>()
            .HasOne(e => e.Person)
            .WithMany()
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<OrderEntity>()
            .HasOne(o => o.Employe)
            .WithMany(e => e.Orders)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<OrderEntity>()
            .HasOne(o => o.Tenant)
            .WithMany(t => t.Order)
            .HasForeignKey(o => o.TenantId)
            .OnDelete(DeleteBehavior.NoAction);

        base.OnModelCreating(modelBuilder);
    }

    #endregion

    #region entities

    public DbSet<ApartmentEntity> Apartments { get; set; } = null!;
    public DbSet<CommentEntity> Comments { get; set; } = null!;
    public DbSet<EmployeEntity> Employees { get; set; } = null!;
    public DbSet<OrderEntity> Orders { get; set; } = null!;
    public DbSet<OrderRowEntity> OrderRows { get; set; } = null!;
    public DbSet<RoleEntity> Roles { get; set; } = null!;
    public DbSet<TenantEntity> Tenants { get; set; } = null!;
    public DbSet<PersonEntity> Persons { get; set; } = null!;
    public DbSet<StatusCodeEntity> StatusCodes { get; set; } = null!;


    #endregion
}