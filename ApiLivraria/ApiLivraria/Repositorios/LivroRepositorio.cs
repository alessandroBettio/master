using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiLivraria.Repositorio
{
    public class LivroRepositorio : ILivroRepositorio
    {
        private readonly LivroDbContext _context;

        public LivroRepositorio(LivroDbContext contexto) 
        {
            _context = contexto;

        }
        public void AtualizaLivro(Livro livro)
        {
            _context.Livros.Update(livro);
            _context.SaveChanges();
        }

        public Livro Busca(int livroId)
        {
            return _context.Livros.FirstOrDefault(x => x.LivroId == livroId);
        }

        public IEnumerable<Livro> GetAll()
        {
            return _context.Livros.ToList();
        }

        public void InsereLivro(Livro livro)
        {
            _context.Livros.Add(livro);
            _context.SaveChanges();
        }

        public void RemoveLivro(int livroId)
        {
            var livro = _context.Livros.FirstOrDefault(x => x.LivroId == livroId);
            _context.Livros.Remove(livro);
            _context.SaveChanges();
        }
    }
}
