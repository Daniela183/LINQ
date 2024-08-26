using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperadorElementoI
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
        public static List<Endereco> GetEndereco()
        {
            List<Endereco> endereco = new()
            {
                new Endereco() { Id = 1, Local = "R. México 1004" },
                new Endereco() { Id = 2, Local = "Praça Miranda 12"},
                new Endereco() { Id = 3, Local = "Av. Luz 290" },
                new Endereco() { Id = 4, Local = "R. Projetada 33" },
                new Endereco() { Id = 5, Local = "R Mirassol 11"},
                new Endereco() { Id = 6, Local = "Av. da Saudade 43" },
                new Endereco() { Id = 7, Local = "Av. Felicidade 77"  },
                new Endereco() { Id = 8, Local = "R. Equador 90" },
                new Endereco() { Id = 9, Local = "R. Trajano 55" },
                new Endereco() { Id = 10, Local = "R. Trajano 100" },
            };
            return endereco;
        }
        public static List<Curso> GetCurso()
        {
            List<Curso> curso = new()
            {
                new Curso() { Id = 10, Nome = "CSharp" },
                new Curso() { Id = 20, Nome = "Node"},
                new Curso() { Id = 30, Nome = "Java"},
                new Curso() { Id = 40, Nome = "Phyton"},
            };
            return curso;
        }
    }
}
