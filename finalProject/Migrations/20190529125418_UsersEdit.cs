using Microsoft.EntityFrameworkCore.Migrations;

namespace finalProject.Migrations
{
    public partial class UsersEdit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "role",
                table: "Users",
                newName: "userSurname");

            migrationBuilder.RenameColumn(
                name: "password",
                table: "Users",
                newName: "userRole");

            migrationBuilder.AddColumn<string>(
                name: "userEmail",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "userPassword",
                table: "Users",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "userEmail",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "userPassword",
                table: "Users");

            migrationBuilder.RenameColumn(
                name: "userSurname",
                table: "Users",
                newName: "role");

            migrationBuilder.RenameColumn(
                name: "userRole",
                table: "Users",
                newName: "password");
        }
    }
}
