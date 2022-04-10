using Microsoft.AspNetCore.Authorization.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SuperheroAPI.Migrations
{
    public partial class NewDataAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table:"SuperHeros", columns: new[]{"Name","FirstName","LastName","Place"}, values:new []{"Amazing","F1","L1","Helsinki"});
            migrationBuilder.InsertData(
                table:"SuperHeros", columns: new[]{"Name","FirstName","LastName","Place"}, values:new []{"Amazing2","F2","L2","Helsinki"});
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
