using Microsoft.EntityFrameworkCore;

namespace ParksLookup.Models
{
  public class ParksLookupContext : DbContext
  {
    public ParksLookupContext(DbContextOptions<ParksLookupContext> options) : base(options) { }
    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Park>()
        .HasData(
          new Park { ParkId = 1, ParkName = "Buike", ParkLocation = "Portland, OR", National = false, Local = true},
          new Park { ParkId = 2, ParkName = "Yosemite", ParkLocation = "Sierra Nevada, CA", National = true, Local = false},
          new Park { ParkId = 3, ParkName = "LakeView", ParkLocation = "Denver, CO", National = false, Local = true},
          new Park { ParkId = 4, ParkName = "Grand Canyon", ParkLocation = "Arizona", National = true, Local = false}
        );
    }
    public virtual DbSet<Park> Parks { get; set; }
  }
}