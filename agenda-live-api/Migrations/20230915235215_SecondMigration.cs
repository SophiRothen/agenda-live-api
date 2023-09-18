using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace agenda_live_api.Migrations
{
    /// <inheritdoc />
    public partial class SecondMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Lives",
                columns: table => new
                {
                    id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    liveName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    channelName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    liveDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    liveTime = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    liveLink = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lives", x => x.id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Lives");
        }
    }
}
