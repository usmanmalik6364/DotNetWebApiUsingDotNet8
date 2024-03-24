using Microsoft.EntityFrameworkCore;

public class HouseDbContext:DbContext{

    public DbSet<HouseEntity> Houses => Set<HouseEntity>();
    public HouseDbContext(DbContextOptions<HouseDbContext> o):
    base(o){
        
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var folder = Environment.SpecialFolder.LocalApplicationData;
        var path = Environment.GetFolderPath(folder);
        optionsBuilder
        .UseSqlite($"Data Source={Path.Join(path,"houses2.db")}");
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        SeedData.Seed(modelBuilder);
    }
}