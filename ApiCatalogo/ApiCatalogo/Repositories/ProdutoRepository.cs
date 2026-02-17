using ApiCatalogo.Context;
using ApiCatalogo.Models;
using ApiCatalogo.Pagination;
using ApiCatalogo.Repositories;
using Microsoft.EntityFrameworkCore;

namespace ApiCatalogo.Repositories;

public class ProdutoRepository : Repository<Produto>, IProdutoRepository
{
    public ProdutoRepository(AppDbContext context) : base(context)
    { 
    }

    public IEnumerable<Produto> GetProdutos(ProdutosParameters produtosParameters)
    {
        return GetAll()
            .OrderBy(p => p.Nome)
            .Skip((produtosParameters.PageNumber - 1) * produtosParameters.PageSize)
            .Take(produtosParameters.PageSize).ToList();

    }

    public IEnumerable<Produto> GetProdutosPorCategoria(int id)
    {
        return GetAllAsync().Where(c => c.CategoriaId == id);
    }
}