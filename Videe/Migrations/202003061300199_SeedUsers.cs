namespace Videe.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'560f2410-0d02-4224-9ef1-7fdcf9bd8055', N'guest@videe.com', 0, N'AJKvCEYdlvwDtrzyfBjKvOkL9iwpV3X0313EOOY+Ko7JbZnskVC1Si44FXXgl0V37w==', N'128c6587-2c3c-488b-854a-05c07cd76481', NULL, 0, 0, NULL, 1, 0, N'guest@videe.com')
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'bd746fa6-ebb6-435f-a51f-2518ef50d3ef', N'admin@videe.com', 0, N'ALhvSbmfCQpjWmZXRotQAQ5tY11rZ8QLXNWUXB4pkMUjRuxpnRWrjTBwwNhKnGPH1Q==', N'85c04e28-6955-48db-9e80-59912a8b9095', NULL, 0, 0, NULL, 1, 0, N'admin@videe.com')

                INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'2c568369-edcb-42bc-9599-77a2d44f8e90', N'CanManageMovies')

                INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'bd746fa6-ebb6-435f-a51f-2518ef50d3ef', N'2c568369-edcb-42bc-9599-77a2d44f8e90')
            ");
        }
        
        public override void Down()
        {
        }
    }
}
