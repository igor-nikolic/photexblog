using Domain;
using EFDataAccess.Configurations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
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
                FirstName = "Pera",
                LastName = "Peric",
                Email = "pera@gmail.com",
                Password="7guOFkbnL2s5eA0xSepLNiQdTQ+Rj8Oe0t6HR2KpKlw=", // Primer_123,
                Visible = true,
                CreatedAt = DateTime.Now
            },
            new User{
                Id=2,
                FirstName = "Marko",
                LastName = "Markovic",
                Email = "marko@gmail.com",
                Password="7guOFkbnL2s5eA0xSepLNiQdTQ+Rj8Oe0t6HR2KpKlw=", // Primer_123
                Visible = true,
                CreatedAt = DateTime.Now
            },
            new User{
                Id=3,
                FirstName = "Petar",
                LastName = "Petrovic",
                Email = "petar@gmail.com",
                Password="7guOFkbnL2s5eA0xSepLNiQdTQ+Rj8Oe0t6HR2KpKlw=", // Primer_123
                Visible = true,
                CreatedAt = DateTime.Now
            },
            new User{
                Id=4,
                FirstName = "Ivan",
                LastName = "Ivanovic",
                Email = "ivan@gmail.com",
                Password="7guOFkbnL2s5eA0xSepLNiQdTQ+Rj8Oe0t6HR2KpKlw=", // Primer_123
                Visible = true,
                CreatedAt = DateTime.Now,
            },
            new User{
                Id=5,
                FirstName = "Nikola",
                LastName = "Nikolic",
                Email = "nikola@gmail.com",
                Password="7guOFkbnL2s5eA0xSepLNiQdTQ+Rj8Oe0t6HR2KpKlw=", // Primer_123
                Visible = true,
                CreatedAt = DateTime.Now
            },
            new User{
                Id=6,
                FirstName = "Marija",
                LastName = "Marjanovic",
                Email = "marija@gmail.com",
                Password="7guOFkbnL2s5eA0xSepLNiQdTQ+Rj8Oe0t6HR2KpKlw=", // Primer_123
                Visible = true,
                CreatedAt = DateTime.Now
            },
            new User{
                Id=7,
                FirstName = "Milinko",
                LastName = "Milinkovic",
                Email = "milinko@gmail.com",
                Password="7guOFkbnL2s5eA0xSepLNiQdTQ+Rj8Oe0t6HR2KpKlw=", // Primer_123
                Visible = true,
                CreatedAt = DateTime.Now
            },
            new User{
                Id=8,
                FirstName = "Zdravko",
                LastName = "Zdravkovic",
                Email = "zdravko@gmail.com",
                Password="7guOFkbnL2s5eA0xSepLNiQdTQ+Rj8Oe0t6HR2KpKlw=", // Primer_123
                Visible = true,
                CreatedAt = DateTime.Now
            }
            };
            modelBuilder.Entity<User>().HasData(fakeUsers);
            //var fakePost = new List<Post> {
            //new Post{
            //        Id=1,
            //        Title = "Post 1",
            //        Content = "post1post1post1post1post1post1post1post1post1post1post1post1post1post1",
            //        PhotoPath = "images/1.png",
            //        UserId = 1,
            //        TopicId = 1
            //} };
            var fakePosts = new List<Post>
            {
                new Post
                {
                    Id=1,
                    Title = "Post 1",
                    Content = "post1post1post1post1post1post1post1post1post1post1post1post1post1post1",
                    PhotoPath = "images/1.png",
                    UserId = rand.Next(1,8),
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
                    UserId = rand.Next(1,8),
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
                    UserId = rand.Next(1,8),
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
                    UserId = rand.Next(1,8),
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
                    UserId = rand.Next(1,8),
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
                    UserId = rand.Next(1,8),
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
                    UserId = rand.Next(1,8),
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
                    UserId = rand.Next(1,8),
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
                    UserId = rand.Next(1,8),
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
                    UserId = rand.Next(1,8),
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
                    UserId = rand.Next(1,8),
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
                    UserId = rand.Next(1,8),
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
                    UserId = rand.Next(1,8),
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
                    UserId = rand.Next(1,8),
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
                    UserId = rand.Next(1,8),
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
                    UserId = rand.Next(1,8),
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
                    UserId = rand.Next(1,8),
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
                    UserId = rand.Next(1,8),
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
                    UserId = rand.Next(1,8),
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
                    UserId = rand.Next(1,8),
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
                    UserId = rand.Next(1,8),
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
                    UserId = rand.Next(1,8),
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
                    UserId = rand.Next(1,8),
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
                    UserId = rand.Next(1,8),
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
                    UserId = rand.Next(1, 8),
                    PostId = rand.Next(1, 24),
                    CommentText = "In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ",
                    Visible = true,
                    CreatedAt = DateTime.Now
                });
            }
            modelBuilder.Entity<Comment>().HasData(fakeComments);
            var fakeRatings = new List<Rating>();
            for (int i = 1; i < 250; i++) 
            {
                fakeRatings.Add(new Rating
                {
                    Id=i,
                    PostId = rand.Next(1, 24),
                    UserId = rand.Next(1,8),
                    Value = rand.Next(1,10),
                    Visible = true,
                    CreatedAt = DateTime.Now
                });
            }
            modelBuilder.Entity<Rating>().HasData(fakeRatings);

            modelBuilder.ApplyConfiguration(new TopicConfiguration());
            modelBuilder.ApplyConfiguration(new CommentConfiguration());
            modelBuilder.ApplyConfiguration(new PostConfiguration());
            modelBuilder.ApplyConfiguration(new RatingConfiguration());            
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.Entity<UserUseCase>().HasKey(x => new {x.UseCaseId,x.UserId });

            modelBuilder.Entity<Topic>().HasQueryFilter(t => t.Visible);
            modelBuilder.Entity<Post>().HasQueryFilter(t => t.Visible);
            modelBuilder.Entity<Rating>().HasQueryFilter(t => t.Visible);
            modelBuilder.Entity<User>().HasQueryFilter(t => t.Visible);
            modelBuilder.Entity<Comment>().HasQueryFilter(t => t.Visible);
            //modelBuilder.
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
