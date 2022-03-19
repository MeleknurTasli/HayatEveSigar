public static class AccountDatabaseBuilder
{

    static void SetDataToDB(ModelBuilder modelBuilder)
    {
        
    }

    public static void TableBuilder(ModelBuilder modelBuilder)
    {
        
        modelBuilder.Entity<Account>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.Property(e => e.PhoneNumber);
            entity.Property(e => e.TCKN);
            entity.Property(e => e.Password);
            entity.Property(e => e.UserID);
            entity.Property(e => e.HesCodeId);
            entity.HasOne(e => e.HesCode).WithOne().HasForeignKey("HesCode","AccountId");
            entity.HasOne(e => e.User).WithOne().HasForeignKey("User","AccountId");
        });

        SetDataToDB(modelBuilder);
    }
}