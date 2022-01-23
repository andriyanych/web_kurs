using System;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using web_app.Domain.Entities;

namespace web_app.Domain
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<TextField> TextFields { get; set; }
        public DbSet<ServiceItem> ServiceItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = "44546e06-8719-4ad8-b88a-f271ae9d6eab",
                Name = "admin",
                NormalizedName = "ADMIN"
            });

            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = "38546e06-8719-4ad8-b88a-f271ae9d6ecs",
                Name = "user",
                NormalizedName = "USER"
            });

            modelBuilder.Entity<IdentityUser>().HasData(new IdentityUser
            {
                Id = "2c62472e-4f66-49fa-a20f-e7685b9565e9",
                UserName = "user",
                NormalizedUserName = "USER",
                Email = "user@email.com",
                NormalizedEmail = "MY@EMAIL.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "superpassword"),
                SecurityStamp = string.Empty
            });

            modelBuilder.Entity<IdentityUser>().HasData(new IdentityUser
            {
                Id = "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                UserName = "admin",
                NormalizedUserName = "ADMIN",
                Email = "admin@email.com",
                NormalizedEmail = "MY@EMAIL.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "superpassword"),
                SecurityStamp = string.Empty
            });

            modelBuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string> // для пользователя
            {
                RoleId = "38546e06-8719-4ad8-b88a-f271ae9d6ecs",
                UserId = "2c62472e-4f66-49fa-a20f-e7685b9565e9"
            });

            modelBuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string> //для админа
            {
                RoleId = "44546e06-8719-4ad8-b88a-f271ae9d6eab",
                UserId = "3b62472e-4f66-49fa-a20f-e7685b9565d8"
            });

            modelBuilder.Entity<TextField>().HasData(new TextField
            {
                Id = new Guid("f86a8c7c-eb4a-4a2b-8385-414d9cf0fca5"),
                CodeWord = "PageIndex",
                Title = "Главная"
            });
            modelBuilder.Entity<TextField>().HasData(new TextField
            {
                Id = new Guid("b3f80e0e-9d09-42fb-86e7-22b804a88bc5"),
                CodeWord = "PageTargets",
                Title = "Цели и задачи"
            });
            modelBuilder.Entity<TextField>().HasData(new TextField
            {
                Id = new Guid("9b6c65ae-1b34-4c09-8f0d-1d352fc98509"),
                CodeWord = "PageSources",
                Title = "Исходные данные"
            });
            modelBuilder.Entity<TextField>().HasData(new TextField
            {
                Id = new Guid("69e55792-e895-4b9e-b5f2-7a24328e6e98"),
                CodeWord = "PagePlan",
                Title = "План работы"
            });

            modelBuilder.Entity<TextField>().HasData(new TextField
            {
                Id = new Guid("0730ca63-ee35-46d7-b290-38f539c6528b"),
                CodeWord = "PageTheory",
                Title = "Теоретические и практические результаты"
            });
            modelBuilder.Entity<TextField>().HasData(new TextField
            {
                Id = new Guid("a4c61202-34cc-4716-866c-9d6990b699cf"),
                CodeWord = "PageTests",
                Title = "Апробация результатов"
            });

        }
    }
}
