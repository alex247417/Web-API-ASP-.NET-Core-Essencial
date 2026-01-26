namespace ApiCatalogo.Repositories;

public interface IUnitOfWork
{
    public IProdutoRepository ProdutoRepository { get; }
    public ICategoriaRepository CategoriaRepository { get; }

    void  Commit();
}