using Domain;
using EFDataAccess.Configurations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace EFDataAccess
{
    public class PhoTexBlogContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Rating> Ratings { get; set; }
        public DbSet<Topic> Topics { get; set; }
        public DbSet<UserUseCase> UserUseCases { get; set; }
        public DbSet<UseCaseLog> UseCaseLogs { get; set; }
        public DbSet<UseCase> UseCases { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=.\SQLEXPRESS;Initial Catalog=PhoTexBlog;Integrated Security=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            var rand = new Random();
            var fakeTopics = new List<Topic>();
            for(int i=1;i<9;i++)
            {
                fakeTopics.Add(new Topic
                {
                    Id = i,
                    Name="Topic " + i,
                    Visible = true,
                    CreatedAt = DateTime.Now
                }) ;
            }
            modelBuilder.Entity<Topic>().HasData(fakeTopics);

            var fakeUsers = new List<User> {
            new User{ 
                Id=1,
                FirstName = "Admin",
                LastName = "Admin",
                Email = "admin@gmail.com",
                Password="7guOFkbnL2s5eA0xSepLNiQdTQ+Rj8Oe0t6HR2KpKlw=", // Primer_123,
                Visible = true,
                CreatedAt = DateTime.Now
            },
            new User{
                Id=2,
                FirstName = "User",
                LastName = "User",
                Email = "User@gmail.com",
                Password="7guOFkbnL2s5eA0xSepLNiQdTQ+Rj8Oe0t6HR2KpKlw=", // Primer_123
                Visible = true,
                CreatedAt = DateTime.Now
            }
            };
            modelBuilder.Entity<User>().HasData(fakeUsers);

            var fakePosts = new List<Post>
            {
                new Post
                {
                    Id=1,
                    Title = "Post 1",
                    Content = "post1post1post1post1post1post1post1post1post1post1post1post1post1post1",
                    PhotoPath = "images/1.png",
                    UserId = rand.Next(1,2),
                    TopicId=rand.Next(1,8),
                    Visible = true,
                    CreatedAt = DateTime.Now
                },
                new Post
                {
                    Id=2,
                    Title = "Post 2",
                    Content = "post2post2post2post2post2post2post2post2post2post2post2",
                    PhotoPath = "images/2.png",
                    UserId = rand.Next(1,2),
                    TopicId = rand.Next(1,8),
                    Visible = true,
                    CreatedAt = DateTime.Now
                },
                new Post
                {
                    Id=3,
                    Title = "Post 3",
                    Content = "post3post3post3post3post3post3post3",
                    PhotoPath = "images/3.png",
                    UserId = rand.Next(1,2),
                    TopicId= rand.Next(1,8),
                    Visible = true,
                    CreatedAt = DateTime.Now
                },
                new Post
                {
                    Id=4,
                    Title = "Post 4",
                    Content = "post4post4post4post4post4post4post4post4post4post4",
                    PhotoPath = "images/4.png",
                    UserId = rand.Next(1,2),
                    TopicId=rand.Next(1,8),
                    Visible = true,
                    CreatedAt = DateTime.Now
                },
                new Post
                {
                    Id=5,
                    Title = "Post 5",
                    Content = "post1post1post1post1post1post1post1post1post1post1post1post1post1post1",
                    PhotoPath = "images/5.png",
                    UserId = rand.Next(1,2),
                    TopicId=rand.Next(1,8),
                    Visible = true,
                    CreatedAt = DateTime.Now
                },
                new Post
                {
                    Id=6,
                    Title = "Post 6",
                    Content = "post2post2post2post2post2post2post2post2post2",
                    PhotoPath = "images/6.png",
                    UserId = rand.Next(1,2),
                    TopicId=rand.Next(1,8),
                    Visible = true,
                    CreatedAt = DateTime.Now
                },
                new Post
                {
                    Id=7,
                    Title = "Post 7",
                    Content = "post3post3post3post3post3post3post3",
                    PhotoPath = "images/7.png",
                    UserId = rand.Next(1,2),
                    TopicId=rand.Next(1,8),
                    Visible = true,
                    CreatedAt = DateTime.Now
                },
                new Post
                {
                    Id=8,
                    Title = "Post 8",
                    Content = "post4post4post4post4post4post4post4post4post4",
                    PhotoPath = "images/8.png",
                    UserId = rand.Next(1,2),
                    TopicId=rand.Next(1,8),
                    Visible = true,
                    CreatedAt = DateTime.Now
                },
                new Post
                {
                    Id=9,
                    Title = "Post 9",
                    Content = "post1post1post1post1post1post1post1post1",
                    PhotoPath = "images/9.png",
                    UserId = rand.Next(1,2),
                    TopicId=rand.Next(1,8),
                    Visible = true,
                    CreatedAt = DateTime.Now
                },
                new Post
                {
                    Id=10,
                    Title = "Post 10",
                    Content = "post2post2post2post2post2post2post2post2post2",
                    PhotoPath = "images/10.jpg",
                    UserId = rand.Next(1,2),
                    TopicId=rand.Next(1,8),
                    Visible = true,
                    CreatedAt = DateTime.Now
                },
                new Post
                {
                    Id=11,
                    Title = "Post 11",
                    Content = "post3post3post3post3post3post3post3",
                    PhotoPath = "images/11.jpg",
                    UserId = rand.Next(1,2),
                    TopicId=rand.Next(1,8),
                    Visible = true,
                    CreatedAt = DateTime.Now
                },
                new Post
                {
                    Id=12,
                    Title = "Post 12",
                    Content = "post3post3post3post3post3post3post3",
                    PhotoPath = "images/12.jpg",
                    UserId = rand.Next(1,2),
                    TopicId=rand.Next(1,8),
                    Visible = true,
                    CreatedAt = DateTime.Now
                },
                new Post
                {
                    Id=13,
                    Title = "Post 13",
                    Content = "post1post2post3post4",
                    PhotoPath = "images/13.jpg",
                    UserId = rand.Next(1,2),
                    TopicId=rand.Next(1,8),
                    Visible = true,
                    CreatedAt = DateTime.Now
                },
                new Post
                {
                    Id=14,
                    Title = "Post 14",
                    Content = "post4post4post431",
                    PhotoPath = "images/14.jpg",
                    UserId = rand.Next(1,2),
                    TopicId=rand.Next(1,8),
                    Visible = true,
                    CreatedAt = DateTime.Now
                },
                new Post
                {
                    Id=15,
                    Title = "Post 15",
                    Content = "post4post4post431",
                    PhotoPath = "images/15.jpg",
                    UserId = rand.Next(1,2),
                    TopicId=rand.Next(1,8),
                    Visible = true,
                    CreatedAt = DateTime.Now
                },
                new Post
                {
                    Id=16,
                    Title = "Post 16",
                    Content = "post1post1post2post3",
                    PhotoPath = "images/16.jpg",
                    UserId = rand.Next(1,2),
                    TopicId=rand.Next(1,8),
                    Visible = true,
                    CreatedAt = DateTime.Now
                },
                new Post
                {
                    Id=17,
                    Title = "Post 17",
                    Content = "post1post1post2post3post2",
                    PhotoPath = "images/17.jpg",
                    UserId = rand.Next(1,2),
                    TopicId=rand.Next(1,8),
                    Visible = true,
                    CreatedAt = DateTime.Now
                },
                new Post
                {
                    Id=18,
                    Title = "Post 18",
                    Content = "post4post4post4post4post4post4post4",
                    PhotoPath = "images/18.jpg",
                    UserId = rand.Next(1,2),
                    TopicId=rand.Next(1,8),
                    Visible = true,
                    CreatedAt = DateTime.Now
                },
                new Post
                {
                    Id=19,
                    Title = "Post 19",
                    Content = "post2post2post2post2",
                    PhotoPath = "images/19.jpg",
                    UserId = rand.Next(1,2),
                    TopicId=rand.Next(1,8),
                    Visible = true,
                    CreatedAt = DateTime.Now
                },
                new Post
                {
                    Id=20,
                    Title = "Post 20",
                    Content = "post12post1post1post1post1",
                    PhotoPath = "images/20.jpg",
                    UserId = rand.Next(1,2),
                    TopicId=rand.Next(1,8),
                    Visible = true,
                    CreatedAt = DateTime.Now
                },
                new Post
                {
                    Id=21,
                    Title = "Post 21",
                    Content = "post12post1post1post1post4",
                    PhotoPath = "images/21.jpg",
                    UserId = rand.Next(1,2),
                    TopicId=rand.Next(1,8),
                    Visible = true,
                    CreatedAt = DateTime.Now
                },
                new Post
                {
                    Id=22,
                    Title = "Post 22",
                    Content = "post1post2post3post4",
                    PhotoPath = "images/22.jpg",
                    UserId = rand.Next(1,2),
                    TopicId=rand.Next(1,8),
                    Visible = true,
                    CreatedAt = DateTime.Now
                },
                new Post
                {
                    Id=23,
                    Title = "Post 23",
                    Content = "post1post2post3post4",
                    PhotoPath = "images/23.jpg",
                    UserId = rand.Next(1,2),
                    TopicId=rand.Next(1,8),
                    Visible = true,
                    CreatedAt = DateTime.Now
                },
                new Post
                {
                    Id=24,
                    Title = "Post 24",
                    Content = "this is a random content",
                    PhotoPath = "images/24.jpg",
                    UserId = rand.Next(1,2),
                    TopicId=rand.Next(1,8),
                    Visible = true,
                    CreatedAt = DateTime.Now
                }
            };
            modelBuilder.Entity<Post>().HasData(fakePosts);

            var fakeComments = new List<Comment>();
            for (int i = 1; i < 100; i++) 
            {
                fakeComments.Add(new Comment
                {
                    Id = i,
                    UserId = rand.Next(1, 2),
                    PostId = rand.Next(1, 24),
                    CommentText = "In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ",
                    Visible = true,
                    CreatedAt = DateTime.Now
                });
            }
            modelBuilder.Entity<Comment>().HasData(fakeComments);

            var fakeRatings = new List<Rating>();

            for (int i = 1; i <= fakeUsers.Count(); i++) 
            {
                    fakeRatings.Add(new Rating
                    {
                        Id = i,
                        PostId = i,
                        UserId = i,
                        Value = rand.Next(1, 10),
                        Visible = true,
                        CreatedAt = DateTime.Now
                    });            
            }

            modelBuilder.Entity<Rating>().HasData(fakeRatings);

            var useCases = new List<UseCase> 
            { 
                new UseCase { Id=1,Name="Create User"},
                new UseCase { Id=2,Name="Soft Delete User"},
                new UseCase { Id=3,Name="Update User"},
                new UseCase { Id=4,Name="Create Topic"},
                new UseCase { Id=5,Name="Soft Delete Topic"},
                new UseCase { Id=6,Name="Update Topic"},
                new UseCase { Id=7,Name="Create Post"},
                new UseCase { Id=8,Name="Soft Delete Post"},
                new UseCase { Id=9,Name="Update Post"},
                new UseCase { Id=10,Name="Create Rating"},
                new UseCase { Id=11,Name="Update Rating"},
                new UseCase { Id=12,Name="Create Comment"},
                new UseCase { Id=13,Name="Soft Delete Comment"},
                new UseCase { Id=14,Name="Update Comment"},
                new UseCase { Id=15,Name="Search UseCaseLog"},
                new UseCase { Id=16,Name="Search Topics"},
                new UseCase { Id=17,Name="Search Posts"},
                new UseCase { Id=18,Name="Get One Topic"},
                new UseCase { Id=19,Name="Get One Post"},
                new UseCase { Id=20,Name="Search Comments"},
                new UseCase { Id=21,Name="Get One Comment"},
                new UseCase { Id=22,Name="Search Users"},
                new UseCase { Id=23,Name="Get One User"},
                new UseCase { Id=24,Name="Search Ratings"},
                new UseCase { Id=25,Name="Get One Rating"},
                new UseCase { Id=26,Name="Create UseCase"},
                new UseCase { Id=27,Name="Update UseCase"},
                new UseCase { Id=28,Name="Search UseCases"},
                new UseCase { Id=29,Name="Get One UseCase"},
                new UseCase { Id=30,Name="Create UserUseCase"},
                new UseCase { Id=31,Name="Search UserUseCases"},
            };
            modelBuilder.Entity<UseCase>().HasData(useCases);


            var fakeUsersUseCase = new List<UserUseCase>();
            for (int i = 1; i <= 29; i++)
            {
                fakeUsersUseCase.Add(new UserUseCase { 
                    Id=i,
                    UserId=1,
                    UseCaseId=i,
                    Visible=true,
                    CreatedAt = DateTime.Now
                });
            }
            var regularUserUseCases = new List<UserUseCase> 
            {
                new UserUseCase{ Id = 30,UserId=2,UseCaseId=2,Visible=true,CreatedAt=DateTime.Now},
                new UserUseCase{ Id = 31,UserId=2,UseCaseId=3,Visible=true,CreatedAt=DateTime.Now},
                new UserUseCase{ Id = 32,UserId=2,UseCaseId=7,Visible=true,CreatedAt=DateTime.Now},
                new UserUseCase{ Id = 33,UserId=2,UseCaseId=8,Visible=true,CreatedAt=DateTime.Now},
                new UserUseCase{ Id = 34,UserId=2,UseCaseId=9,Visible=true,CreatedAt=DateTime.Now},
                new UserUseCase{ Id = 35,UserId=2,UseCaseId=10,Visible=true,CreatedAt=DateTime.Now},
                new UserUseCase{ Id = 36,UserId=2,UseCaseId=11,Visible=true,CreatedAt=DateTime.Now},
                new UserUseCase{ Id = 37,UserId=2,UseCaseId=12,Visible=true,CreatedAt=DateTime.Now},
                new UserUseCase{ Id = 38,UserId=2,UseCaseId=13,Visible=true,CreatedAt=DateTime.Now},
                new UserUseCase{ Id = 39,UserId=2,UseCaseId=14,Visible=true,CreatedAt=DateTime.Now},
                new UserUseCase{ Id = 40,UserId=2,UseCaseId=16,Visible=true,CreatedAt=DateTime.Now},
                new UserUseCase{ Id = 41,UserId=2,UseCaseId=17,Visible=true,CreatedAt=DateTime.Now},
                new UserUseCase{ Id = 42,UserId=2,UseCaseId=18,Visible=true,CreatedAt=DateTime.Now},
                new UserUseCase{ Id = 43,UserId=2,UseCaseId=19,Visible=true,CreatedAt=DateTime.Now},
                new UserUseCase{ Id = 44,UserId=2,UseCaseId=20,Visible=true,CreatedAt=DateTime.Now},
                new UserUseCase{ Id = 45,UserId=2,UseCaseId=21,Visible=true,CreatedAt=DateTime.Now},
                new UserUseCase{ Id = 46,UserId=2,UseCaseId=23,Visible=true,CreatedAt=DateTime.Now},
                new UserUseCase{ Id = 47,UserId=2,UseCaseId=24,Visible=true,CreatedAt=DateTime.Now},
                new UserUseCase{ Id = 48,UserId=2,UseCaseId=25,Visible=true,CreatedAt=DateTime.Now},
            };
            fakeUsersUseCase.AddRange(regularUserUseCases);

            modelBuilder.Entity<UserUseCase>().HasData(fakeUsersUseCase);

            modelBuilder.ApplyConfiguration(new TopicConfiguration());
            modelBuilder.ApplyConfiguration(new CommentConfiguration());
            modelBuilder.ApplyConfiguration(new PostConfiguration());
            modelBuilder.ApplyConfiguration(new RatingConfiguration());            
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new UseCaseConfiguration());
            modelBuilder.ApplyConfiguration(new UseCaseLogConfiguration());
            

            modelBuilder.Entity<UserUseCase>().HasKey(x => new {x.UseCaseId,x.UserId });
            modelBuilder.Entity<Rating>().HasIndex(r => new { r.UserId, r.PostId }).IsUnique();

            modelBuilder.Entity<Topic>().HasQueryFilter(t => t.Visible);
            modelBuilder.Entity<Post>().HasQueryFilter(t => t.Visible);
            modelBuilder.Entity<Rating>().HasQueryFilter(t => t.Visible);
            modelBuilder.Entity<User>().HasQueryFilter(t => t.Visible);
            modelBuilder.Entity<Comment>().HasQueryFilter(t => t.Visible);
        }
        public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries())
            {
                if (entry.Entity is BaseEntity e)
                {
                    switch (entry.State)
                    {
                        case EntityState.Added:
                            e.Visible = true;
                            e.CreatedAt = DateTime.Now;
                            e.ModifiedAt = null;
                            e.DeletedAt = null;
                            break;

                        case EntityState.Modified:
                            e.ModifiedAt = DateTime.Now;

                            break;
                    }
                }
            }

            return base.SaveChanges();
        }

    }
}
