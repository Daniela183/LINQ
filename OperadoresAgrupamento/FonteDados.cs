using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperadoresAgrupamento
{
    public class FonteDados
    {
        public static List<Alunos> GetAlunos()
        {
            List<Alunos> Alunos = new()
            {
                new Alunos() { AlunoId= 1, Curso="Física", Nome = "Maria", Sexo ='F', Idade = 21 },
                new Alunos() { AlunoId= 1, Curso="Química", Nome = "Jorge", Sexo ='M', Idade = 19 },
                new Alunos() { AlunoId= 1, Curso="Engenharia", Nome = "Bernado", Sexo ='M', Idade = 26 },
                new Alunos() { AlunoId= 1, Curso="Moda", Nome = "Denise", Sexo ='F', Idade = 19 },
                new Alunos() { AlunoId= 1, Curso="Moda", Nome = "Carla", Sexo ='F', Idade = 27 },
                new Alunos() { AlunoId= 1, Curso="Engenharia", Nome = "Cecilia", Sexo ='F', Idade = 26 },
                new Alunos() { AlunoId= 1, Curso="Química", Nome = "Helio", Sexo ='M', Idade = 30 },
                new Alunos() { AlunoId= 1, Curso="Física", Nome = "Amanda", Sexo ='F', Idade = 30 },
            };
            return Alunos;
        }
    }
}
