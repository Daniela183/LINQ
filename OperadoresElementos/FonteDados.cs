using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperadoresElementos
{
    public class FonteDados
    {
        public static List<Aluno> GetAluno()
        {
            List<Aluno> Aluno = new()
            {
                new Aluno() { Id = 1, CursoId = 10, Nome = "Maria", EnderecoId = 1 },
                new Aluno() { Id = 2, CursoId = 20, Nome =  "Jorge", EnderecoId = 2},
                new Aluno() { Id = 3, CursoId = 30, Nome =  "Bernado", EnderecoId = 3 },
                new Aluno() { Id = 4, CursoId = 40, Nome =  "Denise", EnderecoId = 4 },
                new Aluno() { Id = 5, CursoId = 40, Nome =  "Carla", EnderecoId = 5},
                new Aluno() { Id = 6, CursoId = 30, Nome =  "Cecilia", EnderecoId = 6 },
                new Aluno() { Id = 7, CursoId = 20, Nome =  "Helio", EnderecoId = 7  },
                new Aluno() { Id = 8, CursoId = 10, Nome =  "Amanda", EnderecoId = 8 },
                new Aluno() { Id = 9, CursoId = 00, Nome =  "Biel", EnderecoId = 9 },
                new Aluno() { Id = 10, CursoId = 00, Nome =  "Flor", EnderecoId = 10 },
            };
            return Aluno;
        }
        public static List<Filmes> GetFilme()
        {
            List<Filmes> Filmes = new()
            {
                new Filmes("Titanic", 7) ,
                new Filmes("De volta para o futuro", 8) ,
                new Filmes("Mulher maravilha", 6) ,
              };
            return Filmes;
        }
    }
}
