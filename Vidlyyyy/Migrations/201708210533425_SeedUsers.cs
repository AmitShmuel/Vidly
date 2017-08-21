namespace Vidlyyyy.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'5278fdf7-dc3c-48e6-a851-90f9f6b55fd3', N'admin@vidly.com', 0, N'AC2QNcy8U/5FbDCxepBTZ7J/rl/Aberzg3Gy5WTDadkLlrOelfDBQC72v63rd4fJfw==', N'b9dc983a-8533-4204-b9b1-4dc15eca53d3', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'fb13a94e-6d27-4d56-b5db-4ae2a21b7546', N'guest@vidly.com', 0, N'ANVob7QuxWDjR/34VEW+89B+2UnyGyRghcHX6vqgN4H3qlQnVercPs3zAtXjpkvJYw==', N'ff48987d-f7da-4e95-861c-0e3fae9a5f73', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')

                INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'8fe4f1ea-0ba2-4df7-a075-1d79e6395dc7', N'CanManageMovies')
                
                INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'5278fdf7-dc3c-48e6-a851-90f9f6b55fd3', N'8fe4f1ea-0ba2-4df7-a075-1d79e6395dc7')"
            );
        }
        
        public override void Down()
        {
        }
    }
}
