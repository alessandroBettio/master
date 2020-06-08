using System;

namespace ApiLivraria
{
    public class Livro
    {
        public int LivroId { get; set; }

        public string Titulo { get; set; }

        public string Autor { get; set; }

        public string Editora { get; set; }
        
        public string Isbn { get; set; }
        
        public int? NumeroEdicao { get; set; }

        public int? AnoEdicao { get; set; }
    }
}
