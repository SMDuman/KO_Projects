using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KO_Projects.Migrations
{
    public partial class SeedRoles : Migration
    {
        private string ManagerRoleId = Guid.NewGuid().ToString();
        private string UserRoleId = Guid.NewGuid().ToString();
        private string AdminRoleId = Guid.NewGuid().ToString();

        private string User1Id = Guid.NewGuid().ToString();
        private string User2Id = Guid.NewGuid().ToString();
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            SeedRolesSQL(migrationBuilder);
            SeedUser(migrationBuilder);
            SeedUserRoles(migrationBuilder);
        }

        protected  void SeedRolesSQL(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql($@"INSERT INTO [dbo].[AspNetRoles] ([Id],[Name],[NormalizedName],[ConcurrencyStamp]) VALUES ('{AdminRoleId}', 'Administrator', 
            'ADMINISTRATOR', null);");
            migrationBuilder.Sql($@"INSERT INTO [dbo].[AspNetRoles] ([Id],[Name],[NormalizedName],[ConcurrencyStamp]) VALUES ('{ManagerRoleId}', 'Manager', 
            'MANAGER', null);");
            migrationBuilder.Sql($@"INSERT INTO [dbo].[AspNetRoles] ([Id],[Name],[NormalizedName],[ConcurrencyStamp]) VALUES ('{UserRoleId}', 'User', 
            'USER', null);");
        }

        protected  void SeedUser(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql($@"INSERT [dbo].[AspNetUsers] ([Id]
      ,[UserName]
      ,[NormalizedUserName]
      ,[Email]
      ,[NormalizedEmail]
      ,[EmailConfirmed]
      ,[PasswordHash]
      ,[SecurityStamp]
      ,[ConcurrencyStamp]
      ,[PhoneNumber]
      ,[PhoneNumberConfirmed]
      ,[TwoFactorEnabled]
      ,[LockoutEnd]
      ,[LockoutEnabled]
      ,[AccessFailedCount]) VALUES (N'{User1Id}', N'test2@test.com' , N'TEST2@TEST.COM', N'test2@test.com', N'TEST2@TEST.COM',
        0 , N'AQAAAAEAACcQAAAAEG6k0Dc3xqdToR7srcEo9c9La570BFp7aQFLGOButfOybQKQGqnc2pWuVwEci82scA==', N'DB3QUKL655WEL4XYVYCMIMVVOA5ARG7M', 
        N'8fe5e8ea-6c80-4f53-ba2b-26120e84eec5', NULL, 0, 0, NULL, 1, 0);");
            migrationBuilder.Sql($@"INSERT [dbo].[AspNetUsers] ([Id]
      ,[UserName]
      ,[NormalizedUserName]
      ,[Email]
      ,[NormalizedEmail]
      ,[EmailConfirmed]
      ,[PasswordHash]
      ,[SecurityStamp]
      ,[ConcurrencyStamp]
      ,[PhoneNumber]
      ,[PhoneNumberConfirmed]
      ,[TwoFactorEnabled]
      ,[LockoutEnd]
      ,[LockoutEnabled]
      ,[AccessFailedCount]) VALUES (N'{User2Id}', N'test3@test.com' , N'TEST3@TEST.COM', N'test3@test.com', N'TEST3@TEST.COM',
        0 , N'AQAAAAEAACcQAAAAEG6k0Dc3xqdToR7srcEo9c9La570BFp7aQFLGOButfOybQKQGqnc2pWuVwEci82scA==', N'DB3QUKL655WEL4XYVYCMIMVVOA5ARG7M', 
        N'8fe5e8ea-6c80-4f53-ba2b-26120e84eec5', NULL, 0, 0, NULL, 1, 0);");
        }

        protected  void SeedUserRoles(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql($@"INSERT INTO [dbo].[AspNetUserRoles] ([UserId],[RoleId]) VALUES ('{User1Id}', '{ManagerRoleId}'); 
            INSERT INTO [dbo].[AspNetUserRoles] ([UserId],[RoleId]) VALUES ('{User1Id}', '{UserRoleId}');");
            migrationBuilder.Sql($@"INSERT INTO [dbo].[AspNetUserRoles] ([UserId],[RoleId]) VALUES ('{User2Id}', '{AdminRoleId}'); 
            INSERT INTO [dbo].[AspNetUserRoles] ([UserId],[RoleId]) VALUES ('{User2Id}', '{ManagerRoleId}');");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
        }
        }
}
