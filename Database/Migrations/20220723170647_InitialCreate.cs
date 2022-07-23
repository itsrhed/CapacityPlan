using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

namespace CapacityPlanApp.Database.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Project",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(type: "varchar(200)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Project", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "capacity_plan_details",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(type: "varchar(200)", nullable: true),
                    date_from = table.Column<string>(type: "varchar(200)", nullable: true),
                    date_to = table.Column<string>(type: "varchar(200)", nullable: true),
                    project_id = table.Column<int>(type: "int", nullable: true),
                    is_deleted = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_capacity_plan_details", x => x.id);
                    table.ForeignKey(
                        name: "FK_capacity_plan_details_Project_project_id",
                        column: x => x.project_id,
                        principalTable: "Project",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "capacity_plan",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    cap_view = table.Column<string>(type: "varchar(200)", nullable: true),
                    week_start = table.Column<string>(type: "varchar(200)", nullable: true),
                    status = table.Column<string>(type: "varchar(200)", nullable: true),
                    cp_details_id = table.Column<int>(type: "int", nullable: true),
                    is_deleted = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_capacity_plan", x => x.id);
                    table.ForeignKey(
                        name: "FK_capacity_plan_capacity_plan_details_cp_details_id",
                        column: x => x.cp_details_id,
                        principalTable: "capacity_plan_details",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_capacity_plan_cp_details_id",
                table: "capacity_plan",
                column: "cp_details_id");

            migrationBuilder.CreateIndex(
                name: "IX_capacity_plan_details_project_id",
                table: "capacity_plan_details",
                column: "project_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "capacity_plan");

            migrationBuilder.DropTable(
                name: "capacity_plan_details");

            migrationBuilder.DropTable(
                name: "Project");
        }
    }
}
