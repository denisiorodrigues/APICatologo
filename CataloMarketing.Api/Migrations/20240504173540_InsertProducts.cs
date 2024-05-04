using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CataloMarketing.Api.Migrations
{
    /// <inheritdoc />
    public partial class InsertProducts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Products (Name, Description, Price, ImageUri, Stok, CreatedDate, CategoryId) VALUES ('Coca-cola 2l', 'Um refrigerante de 2 litros', 10, 'coca-cola-2l.jpg', 28, now(), 1)");
            migrationBuilder.Sql("INSERT INTO Products (Name, Description, Price, ImageUri, Stok, CreatedDate, CategoryId) VALUES ('Hamburger', 'Delicioso hambúrguer grelhado com queijo, alface, tomate e molho especial.', 9.99, 'hamburger.jpg', 100, NOW(), 1)");
            migrationBuilder.Sql("INSERT INTO Products (Name, Description, Price, ImageUri, Stok, CreatedDate, CategoryId) VALUES ('Pudim', 'Um irresistível pudim de leite condensado, coberto com calda de caramelo.', 14.99, 'pudim.jpg', 50, NOW(), 1)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Delete from Products");
        }
    }
}
