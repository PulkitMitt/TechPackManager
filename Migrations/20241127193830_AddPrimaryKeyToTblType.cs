using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TechPackManager.Migrations
{
    /// <inheritdoc />
    public partial class AddPrimaryKeyToTblType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TblMaterials",
                columns: table => new
                {
                    MaterialId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReferenceNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReferenceDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MaterialName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Types = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Units = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rate = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Consumption = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblMaterials", x => x.MaterialId);
                });

            migrationBuilder.CreateTable(
                name: "TblTypes",
                columns: table => new
                {
                    TypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TypeName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblTypes", x => x.TypeId);
                });

            migrationBuilder.CreateTable(
                name: "TblUnits",
                columns: table => new
                {
                    UnitId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UnitName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblUnits", x => x.UnitId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TblMaterials");

            migrationBuilder.DropTable(
                name: "TblTypes");

            migrationBuilder.DropTable(
                name: "TblUnits");
        }
    }
}
