using Microsoft.EntityFrameworkCore;

namespace ParksLookup.Models
{
  public class ParksLookupContext : DbContext
  {
    public ParksLookupContext(DbContextOptions<ParksLookupContext> options) : base(options) { }
    public virtual DbSet<Park> Parks { get; set; }
  }
}