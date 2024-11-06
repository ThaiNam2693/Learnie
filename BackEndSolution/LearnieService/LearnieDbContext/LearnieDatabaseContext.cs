using LearnieService.Models;
using Microsoft.EntityFrameworkCore;

namespace LearnieService.LearnieDbContext
{
	public class LearnieDatabaseContext : DbContext
	{
		public LearnieDatabaseContext() { }

		public DbSet<User> Users { get; set; }
		public DbSet<Order> Orders { get; set; }
		public DbSet<Question> Questions { get; set; }
		public DbSet<QuestionSet> QuestionSets { get; set; }
		public DbSet<Answer> Answers { get; set; }
		public DbSet<Note> Notes { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			var builder = new ConfigurationBuilder()
				.SetBasePath(AppContext.BaseDirectory)
				.AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
			var configuration = builder.Build();
			optionsBuilder.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
		}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Đảm bảo Email của User là duy nhất
            modelBuilder.Entity<User>().HasIndex(u => u.UserEmail).IsUnique();

        }

    }
}
