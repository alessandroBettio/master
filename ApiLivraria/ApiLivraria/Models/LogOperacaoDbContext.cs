using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiLivraria
{
    public class LogOperacaoDbContext : DbContext
    {
        public LogOperacaoDbContext(DbContextOptions<LogOperacaoDbContext> options) : base(options)
        { }

        public DbSet<LogOperacao> LogOperacao { get; set; }
    }
}
