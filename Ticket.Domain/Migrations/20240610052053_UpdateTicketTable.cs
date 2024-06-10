using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ticket.Domain.Migrations
{
    /// <inheritdoc />
    public partial class UpdateTicketTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ToUserId",
                table: "ticket_Tickets");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ToUserId",
                table: "ticket_Tickets",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
