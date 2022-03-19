
public class HayatEveSigarContext : DbContext
{
    public DbSet<Account>? Accounts { get; set; }
    public DbSet<PatientDensity>? Densities { get; set; }
    public DbSet<HesCode>? HesCodes { get; set; }

    public DbSet<Neigborhood>? Neigborhoods { get; set; }
    public DbSet<User>? Users { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var serverVersion = new MySqlServerVersion(new Version(8, 0, 28));
        optionsBuilder.UseMySql("server=localhost;database=hayatevesigar;user=root;port=3306;password=toortoor", serverVersion);
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        UserBuilder.TableBuilder(modelBuilder);
        AccountDatabaseBuilder.TableBuilder(modelBuilder);
        HesCodeDatabaseBuilder.TableBuilder(modelBuilder);
        PatientDensityDatabaseBuilder.TableBuilder(modelBuilder);
        modelBuilder.Entity<Neigborhood>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.Property(e => e.Name);
            entity.Property(e => e.Population);
            entity.Property(e => e.DistrictId);
            entity.Property(e => e.PatientDensityId);
            entity.HasOne(e=>e.District).WithMany(e=>e.Neigborhood).HasForeignKey(e=>e.DistrictId);
        });
    }
}