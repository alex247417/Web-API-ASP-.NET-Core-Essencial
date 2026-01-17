using ApiCatalogo.Context;
using ApiCatalogo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ApiCatalogo.Controllers;


[Route("[controller]")]
[ApiController]
public class CategoriasController : ControllerBase
{
    private readonly AppDbContext _context;

    public CategoriasController(AppDbContext context)
    {
        _context = context;
    }
    
   /* //GET: Produtos
    [HttpGet("produtos")]
    public ActionResult<IEnumerable<Categoria>> GetCategoriasProdutos()
    {
        return _context.Categorias.Include(p=>p.Produtos).ToList();
    }*/
    
   // GET: Categorias
   [HttpGet]
   public ActionResult<IEnumerable<Categoria>> Get()
   {
       return _context.Categorias.ToList();
   }
   
   //GET ID: Categorias
   [HttpGet("{id:int}", Name = "ObterCategoria")]
   public ActionResult<Categoria> Get(int id)
   {
       var categoria =  _context.Categorias.FirstOrDefault(c => c.CategoriaId == id);
       if (categoria == null)
       {
           return NotFound("Categoria não encontrada");
       }
       
       return Ok(categoria);
   }
   
   //POST
   [HttpPost]
   public ActionResult Post(Categoria categoria)
   {
     if(categoria is null)
         return BadRequest();
     _context.Categorias.Add(categoria);
     _context.SaveChanges();
     
     return new CreatedAtRouteResult("ObterCategoria", 
         new { id = categoria.CategoriaId }, categoria);
   }
   
   
   //PUT
   [HttpPut("{id:int}")]
   public ActionResult Put(int id, Categoria categoria)
   {
       if (id != categoria.CategoriaId)
       {
           return BadRequest();
       }
       
       _context.Entry(categoria).State = EntityState.Modified;
       _context.SaveChanges();
       return Ok(categoria);
   }
   
   //DELETE
   [HttpDelete("{id:int}")]
   public ActionResult<Categoria> Delete(int id)
   {
       var categoria = _context.Categorias.FirstOrDefault(p => p.CategoriaId == id);
       if (categoria == null)
       {
           return NotFound();
       }
       _context.Categorias.Remove(categoria);
       _context.SaveChanges();
       return Ok(categoria);
   }
}