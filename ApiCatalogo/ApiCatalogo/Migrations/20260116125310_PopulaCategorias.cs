using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiCatalogo.Migrations
{
    /// <inheritdoc />
    public partial class PopulaCategorias : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder mb)
        {
            mb.Sql("Insert Into Categorias(Nome, ImagemUrl) Values('Bebidas','Bebidas.jpg')");
            mb.Sql("Insert Into Categorias(Nome, ImagemUrl) Values('Lanches','Lanches.jpg')");
            mb.Sql("Insert Into Categorias(Nome, ImagemUrl) Values('Sobremesas','Sobremesas.jpg')");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder mb)
        {
            mb.Sql("Delete From Categorias");
        }
    }
}
