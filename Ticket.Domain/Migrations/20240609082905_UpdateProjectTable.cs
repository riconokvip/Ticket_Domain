using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ticket.Domain.Migrations
{
    /// <inheritdoc />
    public partial class UpdateProjectTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "EstimateTime",
                table: "work_Projects",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProjectPriority",
                table: "work_Projects",
                type: "int",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EstimateTime",
                table: "work_Projects");

            migrationBuilder.DropColumn(
                name: "ProjectPriority",
                table: "work_Projects");
        }
    }
}
