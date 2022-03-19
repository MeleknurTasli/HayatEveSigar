public static class PatientDensityDatabaseBuilder
{

    static void SetDataToDB(ModelBuilder modelBuilder)
    {

    }

    public static void TableBuilder(ModelBuilder modelBuilder)
    {
        
        modelBuilder.Entity<PatientDensity>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.Property(e => e.AddressID);
            entity.HasOne(e => e.Address).WithOne().HasForeignKey("Address","PatientDensityId");
            entity.HasMany(e => e.Users);
        });

        SetDataToDB(modelBuilder);
    }
}