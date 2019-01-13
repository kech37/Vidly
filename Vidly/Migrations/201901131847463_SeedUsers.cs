namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'a29fac90-8ab9-43b7-9c30-c387d1b63cde', N'guest@vidly.com', 0, N'AGL28BDJ4k1BmONuNcy0q6oLDL1omcKCbsuEFycznJ4LYn3MmcO9MKxA3iG6OYlPJg==', N'68df9c85-7b3c-4a99-bf70-c1666ae6a164', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')");
            Sql(@"INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'dd4073ec-c4d1-41fa-b164-dbd293b329e1', N'admin@vidly.com', 0, N'AClNY0G1joGzLlGNuUIPE49H+VPL5VXhLw5PL83IHyDFlyqZQV13qpoJR1zXzXY8Aw==', N'c8e17f52-9d4d-4977-a0da-069f729e9b5c', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')");

            Sql(@"INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'3ce54541-a4c2-4e76-bc45-2767df493b0c', N'CanManageMovies')");

            Sql(@"INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'dd4073ec-c4d1-41fa-b164-dbd293b329e1', N'3ce54541-a4c2-4e76-bc45-2767df493b0c')");
        }
        
        public override void Down()
        {
        }
    }
}
