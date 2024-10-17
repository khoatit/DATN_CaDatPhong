using Data;
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.EntityFrameworkCore;

namespace Hotel.Models
{
	public class AppDbContext : DbContext
	{
        public AppDbContext()
        {
            
        }
        public AppDbContext(DbContextOptions options) : base(options)
		{
		}

		public DbSet<CaDatPhong> caDatPhongs { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("Server = KHOATIT\\SQLEXPRESS; Database = demodatn; Trusted_Connection = True; TrustServerCertificate = True");
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);
		}
	}
}
