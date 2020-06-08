using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using ApiLivraria.Repositorio;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace ApiLivraria.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LivrosController : Controller
    {
        private readonly ILivroRepositorio _livroRepositorio;        

        public LivrosController(ILivroRepositorio livroRepositorio)
        {
            _livroRepositorio = livroRepositorio;
        }

        [HttpGet("GetLivros")]
        public IEnumerable<Livro> GetLivros()
        {            
            return _livroRepositorio.GetAll().OrderBy(o => o.Titulo);
        }

        [HttpGet("GetLivroByID/{id}")]
        public IActionResult GetLivro(int id)
        {
            var livroAux = _livroRepositorio.Busca(id);
            if (livroAux == null)
                return NotFound();

            return new ObjectResult(livroAux);
        }

        [HttpPost("InsertLivro")]
        public IActionResult InsereLivro([FromBody] Livro livro)
        {
            var livroAux = _livroRepositorio.Busca(livro.LivroId);
            if (livro == null || livroAux != null)
                return BadRequest();
            

            _livroRepositorio.InsereLivro(livro);
            
            return new ObjectResult(livro);
        }

        [HttpPut("UpdateLivro/{id}")]
        public IActionResult AtualizaLivro(int id, [FromBody] Livro livro)
        {
            if (livro == null || id != livro.LivroId)
                return BadRequest();
            
            var livroAux = _livroRepositorio.Busca(id);
            if (livroAux == null)
               return NotFound();
            
            livroAux.Titulo = livro.Titulo;
            livroAux.Editora = livro.Editora;
            livroAux.Autor = livro.Autor;
            livroAux.Isbn = livro.Isbn;
            livroAux.NumeroEdicao = livro.NumeroEdicao;
            livroAux.AnoEdicao = livro.AnoEdicao;

            _livroRepositorio.AtualizaLivro(livroAux);
            
            return new NoContentResult();
        }

        [HttpDelete("DeleteLivro/{id}")]
        public IActionResult RemoveLivro(int id)
        {
            var livroAux = _livroRepositorio.Busca(id);
            if (livroAux == null)
                return NotFound();
           
            _livroRepositorio.RemoveLivro(id);
            
            return new NoContentResult();
        }
    }
}
