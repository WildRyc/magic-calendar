using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MagicCalendar.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Event_Format_FormatID",
                table: "Event");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Format",
                table: "Format");

            migrationBuilder.DropColumn(
                name: "ID",
                table: "Format");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Game",
                newName: "GameName");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Game",
                newName: "GameID");

            migrationBuilder.RenameColumn(
                name: "IsTeamBased",
                table: "Format",
                newName: "FormatID");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Event",
                newName: "EventID");

            migrationBuilder.AddColumn<string>(
                name: "URL",
                table: "Organizer",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<int>(
                name: "FormatID",
                table: "Format",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "INTEGER")
                .Annotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Format",
                table: "Format",
                column: "FormatID");

            migrationBuilder.AddForeignKey(
                name: "FK_Event_Format_FormatID",
                table: "Event",
                column: "FormatID",
                principalTable: "Format",
                principalColumn: "FormatID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Event_Format_FormatID",
                table: "Event");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Format",
                table: "Format");

            migrationBuilder.DropColumn(
                name: "URL",
                table: "Organizer");

            migrationBuilder.RenameColumn(
                name: "GameName",
                table: "Game",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "GameID",
                table: "Game",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "FormatID",
                table: "Format",
                newName: "IsTeamBased");

            migrationBuilder.RenameColumn(
                name: "EventID",
                table: "Event",
                newName: "ID");

            migrationBuilder.AlterColumn<bool>(
                name: "IsTeamBased",
                table: "Format",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .OldAnnotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddColumn<int>(
                name: "ID",
                table: "Format",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0)
                .Annotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Format",
                table: "Format",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Event_Format_FormatID",
                table: "Event",
                column: "FormatID",
                principalTable: "Format",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
