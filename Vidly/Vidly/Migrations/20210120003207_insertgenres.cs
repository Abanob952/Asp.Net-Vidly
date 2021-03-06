using Microsoft.EntityFrameworkCore.Migrations;

namespace Vidly.Migrations
{
    public partial class insertgenres : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO GENRES(NAME) VALUES('Action')");
            migrationBuilder.Sql("INSERT INTO GENRES(NAME) VALUES('Comedy')");
            migrationBuilder.Sql("INSERT INTO GENRES(NAME) VALUES('Family')");
            migrationBuilder.Sql("INSERT INTO GENRES(NAME) VALUES('Romance')");


        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
