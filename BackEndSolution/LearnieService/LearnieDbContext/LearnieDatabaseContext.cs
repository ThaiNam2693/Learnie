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

            // Seed data cho bảng User (10 Users)
            modelBuilder.Entity<User>().HasData(
                new User { UserID = 1, UserEmail = "user1@example.com", UserPassword = "password1", Fullname = "User One", Birthday = "1990-01-01", Subcription = true },
                new User { UserID = 2, UserEmail = "user2@example.com", UserPassword = "password2", Fullname = "User Two", Birthday = "1992-02-02", Subcription = false },
                new User { UserID = 3, UserEmail = "user3@example.com", UserPassword = "password3", Fullname = "User Three", Birthday = "1994-03-03", Subcription = true },
                new User { UserID = 4, UserEmail = "user4@example.com", UserPassword = "password4", Fullname = "User Four", Birthday = "1996-04-04", Subcription = false },
                new User { UserID = 5, UserEmail = "user5@example.com", UserPassword = "password5", Fullname = "User Five", Birthday = "1998-05-05", Subcription = true },
                new User { UserID = 6, UserEmail = "user6@example.com", UserPassword = "password6", Fullname = "User Six", Birthday = "2000-06-06", Subcription = false },
                new User { UserID = 7, UserEmail = "user7@example.com", UserPassword = "password7", Fullname = "User Seven", Birthday = "2002-07-07", Subcription = true },
                new User { UserID = 8, UserEmail = "user8@example.com", UserPassword = "password8", Fullname = "User Eight", Birthday = "2004-08-08", Subcription = false },
                new User { UserID = 9, UserEmail = "user9@example.com", UserPassword = "password9", Fullname = "User Nine", Birthday = "2006-09-09", Subcription = true },
                new User { UserID = 10, UserEmail = "user10@example.com", UserPassword = "password10", Fullname = "User Ten", Birthday = "2008-10-10", Subcription = false }
            );

            // Seed data cho bảng QuestionSet (50 QuestionSets)
            for (int i = 1; i <= 50; i++)
            {
                modelBuilder.Entity<QuestionSet>().HasData(
                    new QuestionSet
                    {
                        QuestionSetID = i,
                        QuestSetName = $"Question Set {i}",
                        UserID = (i % 10) + 1, // Sử dụng UserID từ 1 đến 10
                        CreatedAt = DateOnly.FromDateTime(DateTime.UtcNow.AddDays(-i))
                    }
                );
            }

            // Seed data cho bảng Question (50 Questions)
            for (int i = 1; i <= 50; i++)
            {
                modelBuilder.Entity<Question>().HasData(
                    new Question
                    {
                        QuestionID = i,
                        QuestionContent = $"What is question {i}?",
                        QuestionDescription = $"Description for question {i}",
                        QuestionSetID = (i % 50) + 1
                    }
                );
            }

            // Seed data cho bảng Answer (50 Answers)
            for (int i = 1; i <= 50; i++)
            {
                modelBuilder.Entity<Answer>().HasData(
                    new Answer
                    {
                        AnswerID = i,
                        AnswerContent = i, // Nội dung câu trả lời có thể là ID hoặc một số đại diện
                        IsRightAnswer = (i % 2 == 0), // Đánh dấu các câu trả lời chẵn là đúng
                        QuestionID = (i % 50) + 1
                    }
                );
            }

            // Seed data cho bảng Note (50 Notes)
            for (int i = 1; i <= 50; i++)
            {
                modelBuilder.Entity<Note>().HasData(
                    new Note
                    {
                        NoteID = i,
                        NoteContent = $"This is note {i}",
                        UserEmail = $"user{i % 10 + 1}@example.com", // UserEmail từ 1 đến 10
                        QuestionSetID = (i % 50) + 1
                    }
                );
            }
        }

    }
}
