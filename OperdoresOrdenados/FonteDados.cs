using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperdoresOrdenados
{
    public class FonteDados
    {
        public static List<Alunos> GetAlunos()
        {
            List<Alunos> alunos = new()
            {
            new Alunos() { Nome = "Maria", Idade = 42 },
            new Alunos() { Nome = "Manoel", Idade = 34 },
            new Alunos() { Nome = "Amanda", Idade = 25 },
            new Alunos() { Nome = "Carlos", Idade = 18 },
            new Alunos() { Nome = "Alicia", Idade = 15 },
            new Alunos() { Nome = "Jaime", Idade = 16 },
            new Alunos() { Nome = "Debora", Idade = 25 },
            new Alunos() { Nome = "Sandra", Idade = 19 },
            };
            return alunos;
        }
    }
}
