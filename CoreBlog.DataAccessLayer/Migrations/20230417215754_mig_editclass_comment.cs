using Microsoft.EntityFrameworkCore.Migrations;

namespace CoreBlog.DataAccessLayer.Migrations
{
    public partial class mig_editclass_comment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CommentEmail",
                table: "Comments",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CommentEmail",
                table: "Comments");
        }
    }
}
