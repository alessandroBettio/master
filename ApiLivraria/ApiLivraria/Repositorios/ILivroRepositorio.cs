using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiLivraria.Repositorio
{
    public interface ILivroRepositorio
    {
        IEnumerable<Livro> GetAll();

        Livro Busca(int livroId);

        void InsereLivro(Livro livro);

        void AtualizaLivro(Livro livro);

        void RemoveLivro(int livroId);
    }
}
