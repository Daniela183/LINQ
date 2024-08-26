using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperadoresConversao
{
    public class FonteDados
    {
        public static IEnumerable<Aluno> GetAluno()
        {
            List<Aluno> aluno = new()
            {
                new Aluno() { Id = 1, Nome = "Maria", Idade = 21 },
                new Aluno() { Id = 2, Nome =  "Jorge", Idade = 32},
                new Aluno() { Id = 3, Nome =  "Bernado", Idade = 43 },
                new Aluno() { Id = 4, Nome =  "Denise", Idade = 24 },
                new Aluno() { Id = 5, Nome =  "Carla", Idade = 25},
                new Aluno() { Id = 6, Nome =  "Cecilia", Idade = 36 },
                new Aluno() { Id = 7, Nome =  "Helio", Idade = 27  },
                new Aluno() { Id = 8, Nome =  "Amanda", Idade = 18 },
                new Aluno() { Id = 9, Nome =  "Biel", Idade = 29 },
                new Aluno() { Id = 10, Nome =  "Manoel", Idade = 19 },
            };
            return aluno.AsEnumerable();
        }
        public static IEnumerable<Funcionario> GetFuncionarios()
        {
            List<Funcionario> funcionarios = new()
            {
                new Funcionario() { Nome = "Maria", Cidade = "Santos", Cargo = "Adim"  },
                new Funcionario() { Nome = "Manoel", Cidade = "Lins", Cargo = "Gerente" },
                new Funcionario() { Nome = "Amanda", Cidade = "Campinas", Cargo = "Vendedor" },
                new Funcionario() { Nome = "Carlos", Cidade = "Lins", Cargo = "Vendedor" },
                new Funcionario() { Nome = "Alicia", Cidade = "Barretos", Cargo = "Caixa" },
                new Funcionario() { Nome = "Vicente", Cidade = "Santos", Cargo = "Operador" },
                new Funcionario() { Nome = "Armando", Cidade = "Campinas", Cargo = "Adim" },
            };
            return funcionarios.AsEnumerable();
        }
    }
}
