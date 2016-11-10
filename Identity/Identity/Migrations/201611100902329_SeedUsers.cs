namespace Identity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'432cbf0f-9e91-4429-aae8-40ae1355f09d', N'admin@vidly.com', 0, N'AJN1GPB/IKm1r6tuvVVs/TVij5Je4FywDygraJbZ+wQQK45v18OCJZUTEKdeakIYXw==', N'9c634ba7-125a-4271-94c3-9fa23f96a58d', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'ca5eb5de-6b2c-4866-83aa-2e16acc0b960', N'Manager')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'432cbf0f-9e91-4429-aae8-40ae1355f09d', N'ca5eb5de-6b2c-4866-83aa-2e16acc0b960')

");
        }
        
        public override void Down()
        {
        }
    }
}
