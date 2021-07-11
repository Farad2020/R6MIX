using Microsoft.EntityFrameworkCore.Migrations;

namespace R6MIX.Data.Migrations
{
    public partial class UpdModelsForAbilityDemoLinks : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AbilityDemoLink",
                table: "Operator",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AbilityDemoLink",
                table: "Operator");
        }
    }
}
