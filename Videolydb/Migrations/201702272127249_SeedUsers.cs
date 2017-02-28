namespace Videolydb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'dd2992dc-9042-43aa-9db9-49ced0281f6e', N'admin@videoly.com', 0, N'AI3kn/FWjzWt1Y7QO0HB5ykKhO4illfNyhDuz8KfZKBbxc8psoch6qchdubd9p+x5w==', N'32e7c20c-a2b0-471b-b222-8b52eed542de', NULL, 0, 0, NULL, 1, 0, N'admin@videoly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'ff5f0853-e778-4995-b162-7e73e128ff6a', N'guest@videolydb.com', 0, N'AOVZdm4xVN9z5i96y5waiuEApqNHTWuoD5ECJXmRI2ZsEITwZCu5bzvv94sybcZjaw==', N'c9826e9c-b4ff-43b6-a776-5d6fdb34c436', NULL, 0, 0, NULL, 1, 0, N'guest@videolydb.com')               
INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'bebc3720-7887-404e-8bac-c7b74c96fead', N'CanManageMovies')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'dd2992dc-9042-43aa-9db9-49ced0281f6e', N'bebc3720-7887-404e-8bac-c7b74c96fead')

");
        }
        
        public override void Down()
        {
            AlterColumn("dbo.MembershipTypes", "Name", c => c.String());
        }
    }
}
