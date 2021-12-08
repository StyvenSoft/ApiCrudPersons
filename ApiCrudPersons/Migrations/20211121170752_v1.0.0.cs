using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ApiCrudPersons.Migrations
{
    public partial class v100 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Person",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: false),
                    lastName = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: false),
                    typeDocument = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: false),
                    numDocument = table.Column<int>(type: "int", nullable: false),
                    address = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: false),
                    gender = table.Column<string>(type: "varchar(1) CHARACTER SET utf8mb4", nullable: false),
                    createdAt = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Person", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Person");
        }
    }
}
