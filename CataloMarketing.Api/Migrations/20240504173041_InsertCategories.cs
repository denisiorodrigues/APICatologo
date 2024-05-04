using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CataloMarketing.Api.Migrations
{
    /// <inheritdoc />
    public partial class InsertCategories : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Insert into Categories (Name, ImageUri) values ('Bebidas', 'bebidas.jpg')");
            migrationBuilder.Sql("Insert into Categories (Name, ImageUri) values ('Lanches', 'lanches.jpg')");
            migrationBuilder.Sql("Insert into Categories (Name, ImageUri) values ('Sobremeses', 'Sobremeses.jpg')");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("delete from Categories");
        }
    }
}
