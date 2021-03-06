using Microsoft.EntityFrameworkCore.Migrations;

namespace Vidly.Migrations
{
    public partial class populatemembershiptypes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("insert into MemberShipTypes(SignUpFee,DurationInMonth,DiscountRate) values(0,0,0)");
            migrationBuilder.Sql("insert into MemberShipTypes(SignUpFee,DurationInMonth,DiscountRate) values(30,1,10)");
            migrationBuilder.Sql("insert into MemberShipTypes(SignUpFee,DurationInMonth,DiscountRate) values(90,3,15)");
            migrationBuilder.Sql("insert into MemberShipTypes(SignUpFee,DurationInMonth,DiscountRate) values(300,12,20)");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
