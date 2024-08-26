using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperConjuntosI
{
    public class FonteDados
    {
        public static int[] GetIdades()
        {
            var idades = new[] { 30, 33, 35, 36, 40, 30, 33, 35, 36, 30, 40 };
            return idades;
        }
        public static string[] GetNomes()
        {
            var nomes = new[] { "Paulo", "MARIA", "paulo", "Amanda", "maria", "amanda" };
            return nomes;
        }
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
        public static string[] GetPaises1()
        {
            string[] paises = { "Brasil", "USA", "UK", "Argentina", "China" };
            return paises;
        }
        public static string[] GetPaises2()
        {
            string[] paises = { "Brasil", "uk", "Argentina", "França", "Japão" };
            return paises;
        }
        public static List<Alunos> GetTurmaA()
        {
            List<Alunos> aluno = new()
            {
                new Alunos() { Nome = "Maria", Idade = 42, Nascimento = new DateTime(1981, 6, 11)},
                new Alunos() { Nome = "Manoel", Idade = 34, Nascimento = new DateTime(1989, 2, 10)},
                new Alunos() { Nome = "Amanda", Idade = 25, Nascimento = new DateTime(1998, 9, 30)},
                new Alunos() { Nome = "Carlos", Idade = 18, Nascimento = new DateTime(2008, 10, 11)},
                new Alunos() { Nome = "Alicia", Idade = 15, Nascimento = new DateTime(2005, 9, 15)},
            };
            return aluno;
        }

        public static List<Alunos> GetTurmaB()
        {
            List<Alunos> aluno = new()
            {
                new Alunos() { Nome = "Homero", Idade = 26, Nascimento = new DateTime(1997, 9, 15)},
                new Alunos() { Nome = "Silvia", Idade = 31, Nascimento = new DateTime(1992, 9, 30)},
                new Alunos() { Nome = "Felicia", Idade = 21, Nascimento = new DateTime(2002, 9, 30)},
                new Alunos() { Nome = "Alfredo", Idade = 18, Nascimento = new DateTime(2005, 10, 15)},
                new Alunos() { Nome = "Denize", Idade = 33, Nascimento = new DateTime(1990, 11, 5)},
            };
            return aluno;
        }
    }
}
