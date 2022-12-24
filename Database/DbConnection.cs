using lab5.Models;
using Microsoft.EntityFrameworkCore;
using System.Net;

namespace lab5.Database
{
    public class DbConnection : DbContext
    {
		public DbConnection(DbContextOptions<DbConnection> options) : base(options)
		{

		}

		public DbSet<Receipt> Receipts { get; set; } = null!;
		public DbSet<Consumer> Consumers { get; set; } = null!;
		public DbSet<Address> Addresses { get; set; } = null!;
		public DbSet<Service> Services { get; set; } = null!;


	}
}
