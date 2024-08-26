using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
//using Microsoft.EntityFrameworkCore;

namespace OperacaoJunção
{
    public class AppDBContext //: DbContext
    {
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("");
        //    optionsBuilder.LogTo(Console.WriteLine,Microsoft.Extensions.Logging.LogLevel.Information);
        //}
        //public DbSet<Setor> setores {  get; set; }
        //public DbSet<Funcionario> Funcionarios {  get; set; }
        public object Funcionario { get; internal set; }
    }
}
