using Microsoft.EntityFrameworkCore.Migrations;

namespace UserManage_RoleBased.Data.Migrations
{
    public partial class assignAdminToAllRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO [security].[UserRoles] (UserId, RoleId) SELECT 'cd424787-984a-4493-8baa-ded853e59922', Id FROM [security].[Roles]");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM [security].[UserRoles] WHERE UserId = 'cd424787-984a-4493-8baa-ded853e59922'");
        }
    }
}
