using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication8.Migrations
{
    /// <inheritdoc />
    public partial class fh : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_customers",
                table: "customers");

            migrationBuilder.RenameTable(
                name: "customers",
                newName: "Student");

            migrationBuilder.RenameColumn(
                name: "age",
                table: "Student",
                newName: "Age");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Student",
                newName: "RegNo");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Student",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PhoneNmb",
                table: "Student",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Student",
                table: "Student",
                column: "RegNo");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Student",
                table: "Student");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Student");

            migrationBuilder.DropColumn(
                name: "PhoneNmb",
                table: "Student");

            migrationBuilder.RenameTable(
                name: "Student",
                newName: "customers");

            migrationBuilder.RenameColumn(
                name: "Age",
                table: "customers",
                newName: "age");

            migrationBuilder.RenameColumn(
                name: "RegNo",
                table: "customers",
                newName: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_customers",
                table: "customers",
                column: "Id");
        }
    }
}
