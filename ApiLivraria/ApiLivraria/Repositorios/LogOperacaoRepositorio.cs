using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiLivraria.Repositorio
{
    public class LogOperacaoRepositorio : ILogOperacaoRepositorio
    {
        private readonly LogOperacaoDbContext _context;
        private LogOperacao logOperacao;

        //Ideia para gravar os Logs
        //_logOperacaoRepositorio.InsereLogOperacao("GetLivros", 0, "Livros", "OK - consulta realizada com sucesso");
        //_logOperacaoRepositorio.InsereLogOperacao("GetLivroByID", id, "Livro", "ERRO - livro não encontrado");
        //_logOperacaoRepositorio.InsereLogOperacao("GetLivroByID", id, "Livro", "OK - livro encontrado com sucesso - " + JsonConvert.SerializeObject(livroAux, Formatting.None).ToString());

        public LogOperacaoRepositorio(LogOperacaoDbContext contexto) 
        {
            _context = contexto;

        }

        public void InsereLogOperacao(string operacao, int? chaveObjeto, string nomeObjeto, string dados)
        {
            logOperacao = new LogOperacao();

            logOperacao.DataLog = DateTime.Now;
            logOperacao.Operacao = operacao;
            logOperacao.ChaveObjeto = chaveObjeto;
            logOperacao.NomeObjeto = nomeObjeto;
            logOperacao.Dados = dados;

            _context.LogOperacao.Add(logOperacao);
            _context.SaveChanges();
        }

    }
}
