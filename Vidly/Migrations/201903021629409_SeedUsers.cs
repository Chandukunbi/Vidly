namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'5f920446-b3ea-41da-81c8-2d30af6f918c', N'guest@vidly.com', 0, N'ANUQYTVIoQ9cSBXEfgrHlNgvZOFOgKZaEgZI95F0YajJv8IXH8dJoa/EEfif8/VbMw==', N'70bcf03e-617a-46c7-b994-c233efd4ae75', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'b811bef2-e0d1-4077-a2c8-15ccdd13b7e5', N'admin@vidly.com', 0, N'AJGtHoyl2TttPsDfGX1CHye6lS0Cvri15JckgIQ+Iel2fdtfvCOPDHOQS25iuNdtsg==', N'69ba2f18-a11f-41fc-bea8-e75704ae321e', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'c022a798-1c9b-46f2-893d-6b8295fe8652', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'b811bef2-e0d1-4077-a2c8-15ccdd13b7e5', N'c022a798-1c9b-46f2-893d-6b8295fe8652')


");
        }
        
        public override void Down()
        {
        }
    }
}
