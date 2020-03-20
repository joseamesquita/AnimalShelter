using Microsoft.EntityFrameworkCore;

namespace HairSalon.Models
{
  public class HAIRSALONContext : DbContext
  {
    public virtual DbSet<Client> Client { get; set; }
    public DbSet<Stylist> Stylist { get; set; }

    public Context(HairSalonDbContextOptions options) : base(options) { }
  }
}