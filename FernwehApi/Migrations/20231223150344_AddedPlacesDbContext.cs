using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FernwehApi.Migrations
{
	/// <inheritdoc />
	public partial class AddedPlacesDbContext : Migration
	{
		/// <inheritdoc />
		protected override void Up(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.CreateTable(
				name: "DisplayName",
				columns: table => new
				{
					DisplayNameId = table.Column<string>(type: "nvarchar(450)", nullable: false),
					Text = table.Column<string>(type: "nvarchar(max)", nullable: false),
					LanguageCode = table.Column<string>(type: "nvarchar(max)", nullable: false)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_DisplayName", x => x.DisplayNameId);
				});

			migrationBuilder.CreateTable(
				name: "Places",
				columns: table => new
				{
					PlaceId = table.Column<int>(type: "int", nullable: false)
						.Annotation("SqlServer:Identity", "1, 1"),
					FormattedAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
					Rating = table.Column<double>(type: "float", nullable: false),
					UserRatingCount = table.Column<int>(type: "int", nullable: false),
					DisplayNameId = table.Column<string>(type: "nvarchar(450)", nullable: true)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_Places", x => x.PlaceId);
					table.ForeignKey(
						name: "FK_Places_DisplayName_DisplayNameId",
						column: x => x.DisplayNameId,
						principalTable: "DisplayName",
						principalColumn: "DisplayNameId");
				});

			migrationBuilder.CreateIndex(
				name: "IX_Places_DisplayNameId",
				table: "Places",
				column: "DisplayNameId");
		}

		/// <inheritdoc />
		protected override void Down(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.DropTable(
				name: "Places");

			migrationBuilder.DropTable(
				name: "DisplayName");
		}
	}
}
