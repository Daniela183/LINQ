using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaginacaoSkipTake
{
    public class Aluno
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Curso { get; set; }

        public static List<Aluno> GetAlunos()
        {
            return new List<Aluno>
            {

                new Aluno() { Id = 1, Nome = "Maria", Curso = "Java"  },
                new Aluno() { Id = 2, Nome =  "Jorge", Curso = "Node" },
                new Aluno() { Id = 3, Nome =  "Bernado", Curso = "C#" },
                new Aluno() { Id = 4, Nome =  "Denise", Curso = "SQL" },
                new Aluno() { Id = 5, Nome =  "Carla", Curso = "Java"},
                new Aluno() { Id = 6, Nome =  "Cecilia", Curso = "SQL" },
                new Aluno() { Id = 7, Nome =  "Helio", Curso = "C#"  },
                new Aluno() { Id = 8, Nome =  "Amanda", Curso = "Phyton" },
                new Aluno() { Id = 9, Nome =  "Biel", Curso = "Node" },
                new Aluno() { Id = 10, Nome =  "Manoel", Curso = "Java" },
                new Aluno() { Id = 11, Nome =  "Helena", Curso = "Phyton" },
                new Aluno() { Id = 12, Nome =  "Sivio", Curso = "C#"  },
                new Aluno() { Id = 13, Nome =  "Renato", Curso = "JS" },
                new Aluno() { Id = 14, Nome =  "Tania", Curso = "SQL" },
                new Aluno() { Id = 15, Nome =  "Ana", Curso = "PHP" },
                new Aluno() { Id = 16, Nome =  "Debora", Curso = "Phyton" },
                new Aluno() { Id = 17, Nome =  "Luis", Curso = "C#" },

            };
        }
    }
}
