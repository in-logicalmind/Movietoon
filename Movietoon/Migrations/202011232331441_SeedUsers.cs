namespace Movietoon.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'2362820d-d181-4643-8f63-18b2d179c6c5', N'ivanrnarvaez@gmail.com', 0, N'ADK5+cNyiJFuonvgS0jca52W4IW6wxyztc0BeG4SOalM8f450xlLt8mXoc6jZ35mUQ==', N'ecb5e210-fe6c-4fe7-9dd4-d9c26a297486', NULL, 0, 0, NULL, 1, 0, N'ivanrnarvaez@gmail.com')
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'ae1b7e3f-5a40-40f5-8e6f-783990e16c68', N'admin@movietoon.com', 0, N'ANg8orTQnxUYr1p9DxEO1l+J0ZgjhjGomTshQj1mPS8VIoAxntyvmuY7GyDFWY3Kkw==', N'c3a617d7-9487-47ed-afe3-25bb7d2083f8', NULL, 0, 0, NULL, 1, 0, N'admin@movietoon.com')

                INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'3392291b-19a2-4d29-abfa-b15bc5ff9f4b', N'AdminMovies')
                INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'ae1b7e3f-5a40-40f5-8e6f-783990e16c68', N'3392291b-19a2-4d29-abfa-b15bc5ff9f4b')


                ");
        }
        
        public override void Down()
        {
        }
    }
}
