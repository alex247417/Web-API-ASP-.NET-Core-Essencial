using ApiCatalogo.Context;
using ApiCatalogo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ApiCatalogo.Controllers;

[ApiController]
[Route("[controller]")]
public class ProdutosController : ControllerBase
{
       private readonly AppDbContext _context;

       public ProdutosController(AppDbContext context)
       {
           _context = context;
       }

       // GET: Produtos
       [HttpGet]
       public  ActionResult <IEnumerable<Produto>> Get()
       {
           var Produtos = _context.Produtos.ToList();
           if (Produtos is null)
           {
               return NotFound("Produtos não encontrados");
           }
           return Produtos;
       }
       
       // GET ID: Produtos
       [HttpGet("{id:int}", Name = "ObterProduto")]
       public ActionResult<Produto> Get(int id)
       {
          var produto =  _context.Produtos.FirstOrDefault(p => p.ProdutoId == id);
           if (produto is null)
           {
               return NotFound("Produto não encontrado");
           }

           return produto;
       }
       
       //POST: Produtos
       [HttpPost]
       public ActionResult Post(Produto produto)
       {
           if (produto is null)
               return BadRequest();
           
           _context.Produtos.Add(produto);
           _context.SaveChanges();

           return new CreatedAtRouteResult("ObterProduto", new { id = produto.ProdutoId }, produto);

       }
       
       //PUT: Produtos
       [HttpPut("{id:int}")]
       public ActionResult Put(int id, Produto produto)
       {
           if (id != produto.ProdutoId)
           {
               return BadRequest();
           }

           _context.Entry(produto).State = EntityState.Modified;
           _context.SaveChanges();
           return Ok(produto);
       }
       
       //DELETE: Produtos
       [HttpDelete("{id:int}")]
       public ActionResult Delete(int id)
       {
           var produto = _context.Produtos.FirstOrDefault(p => p.ProdutoId == id);
           if (produto is null)
           {
               return NotFound("Produto não Localizado...");
           }
           _context.Produtos.Remove(produto);
           _context.SaveChanges();
           return Ok(produto);
       }
       
       
}