using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ticket.Domain.Migrations
{
    /// <inheritdoc />
    public partial class UpdateUserPermission : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Claim",
                table: "user_UserPermissions",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Claim",
                table: "user_UserPermissions");
        }
    }
}
