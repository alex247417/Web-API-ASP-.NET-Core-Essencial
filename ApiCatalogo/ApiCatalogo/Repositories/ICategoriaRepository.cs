using ApiCatalogo.Models;
using APICatalogo.Pagination;
using APICatalogo.Repositories;
using X.PagedList;


namespace ApiCatalogo.Repositories;

public interface ICategoriaRepository : IRepository<Categoria>
{
    Task<IPagedList<Categoria>> GetCategoriasAsync(CategoriasParameters categoriasParams);
    Task<IPagedList<Categoria>> GetCategoriasFiltroNomeAsync(CategoriasFiltroNome categoriasParams);
}
