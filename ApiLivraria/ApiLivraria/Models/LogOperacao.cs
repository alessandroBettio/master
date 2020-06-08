using System;

namespace ApiLivraria
{
    public class LogOperacao
    {
        public DateTime? DataLog { get; set; }

        public string Operacao { get; set; }

        public int? ChaveObjeto { get; set; }

        public string NomeObjeto { get; set; }
        
        public string Dados { get; set; }
    }
}
