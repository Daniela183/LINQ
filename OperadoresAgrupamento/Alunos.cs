using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperadoresAgrupamento
{
    public sealed class Alunos
    {
        public int AlunoId { get; set; }
        public string Nome { get; set; } = string.Empty;
        public char Sexo { get; set; }
        public string Curso { get; set; }
        public int Idade { get; set; }
    }
}
