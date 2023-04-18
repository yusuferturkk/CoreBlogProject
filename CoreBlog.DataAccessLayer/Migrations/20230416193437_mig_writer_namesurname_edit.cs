using Microsoft.EntityFrameworkCore.Migrations;

namespace CoreBlog.DataAccessLayer.Migrations
{
    public partial class mig_writer_namesurname_edit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "WriterName",
                table: "Writers");

            migrationBuilder.RenameColumn(
                name: "WriterSurname",
                table: "Writers",
                newName: "WriterNameSurname");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "WriterNameSurname",
                table: "Writers",
                newName: "WriterSurname");

            migrationBuilder.AddColumn<string>(
                name: "WriterName",
                table: "Writers",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
