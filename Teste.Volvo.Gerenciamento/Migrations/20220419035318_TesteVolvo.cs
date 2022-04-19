using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Teste.Volvo.Gerenciamento.Migrations
{
    public partial class TesteVolvo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Truck",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    DtCreated = table.Column<DateTime>(nullable: false),
                    DtChange = table.Column<DateTime>(nullable: false),
                    DsChangedBy = table.Column<string>(nullable: false),
                    Model = table.Column<string>(maxLength: 2, nullable: false),
                    ManufactureYear = table.Column<DateTime>(nullable: false),
                    ModelYear = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Truck", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Truck");
        }
    }
}
