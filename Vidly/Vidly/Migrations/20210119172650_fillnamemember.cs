using Microsoft.EntityFrameworkCore.Migrations;

namespace Vidly.Migrations
{
    public partial class fillnamemember : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("update MemberShipTypes set Name = 'Pay as You Go' where Id=1");
            migrationBuilder.Sql("update MemberShipTypes set Name = 'Monthly' where Id=2");
            migrationBuilder.Sql("update MemberShipTypes set Name = 'Quarterly' where Id=3");
            migrationBuilder.Sql("update MemberShipTypes set Name = 'Yearly' where Id=4");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
