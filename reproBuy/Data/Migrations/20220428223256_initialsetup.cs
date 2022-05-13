using Microsoft.EntityFrameworkCore.Migrations;

namespace reproBuy.Data.Migrations
{
    public partial class initialsetup : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Price = table.Column<double>(nullable: false),
                    ProductName = table.Column<string>(nullable: false),
                    CategoryID = table.Column<int>(nullable: false),
                    StockAmount = table.Column<int>(nullable: false),
                    AccountUser = table.Column<string>(nullable: false),
                    ProductDesc = table.Column<string>(nullable: true),
                    ImageTitle = table.Column<string>(nullable: false),
                    ImageName = table.Column<string>(nullable: true),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.ID);
                }); ;
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Product");
        }
    }
}
