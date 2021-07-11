using Microsoft.EntityFrameworkCore.Migrations;

namespace R6MIX.Data.Migrations
{
    public partial class Models : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Loadout",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrimaryWeapon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrimaryWeaponImg = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecondaryWeapon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecondaryWeaponImg = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gadget = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GadgetImg = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Loadout", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Side",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Icon = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Side", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Operator",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OpImgLink = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OpIconLink = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Origin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Biography = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PshycoPortrait = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Armor = table.Column<int>(type: "int", nullable: false),
                    Speed = table.Column<int>(type: "int", nullable: false),
                    Difficulty = table.Column<int>(type: "int", nullable: false),
                    OpSideId = table.Column<int>(type: "int", nullable: true),
                    OpLoadoutId = table.Column<int>(type: "int", nullable: true),
                    AbilityName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AbilityIcon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AbilityTLDR = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Operator", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Operator_Loadout_OpLoadoutId",
                        column: x => x.OpLoadoutId,
                        principalTable: "Loadout",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Operator_Side_OpSideId",
                        column: x => x.OpSideId,
                        principalTable: "Side",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Operator_OpLoadoutId",
                table: "Operator",
                column: "OpLoadoutId");

            migrationBuilder.CreateIndex(
                name: "IX_Operator_OpSideId",
                table: "Operator",
                column: "OpSideId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Operator");

            migrationBuilder.DropTable(
                name: "Loadout");

            migrationBuilder.DropTable(
                name: "Side");
        }
    }
}
