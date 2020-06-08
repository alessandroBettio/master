using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiLivraria.Repositorio
{
    public interface ILogOperacaoRepositorio
    {

        void InsereLogOperacao(string operacao, int? chaveObjeto, string nomeObjeto, string dados);

    }
}
