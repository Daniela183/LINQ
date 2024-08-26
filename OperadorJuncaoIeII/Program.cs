//aula 240 - 241
using OperadorJuncaoIeII;

Console.WriteLine("Operadores de juncao - I");
Console.WriteLine("Alunos matriculados e seus endereços\n");

var consulta = from aluno in FonteDados.GetAluno()
               join endereco in FonteDados.GetEndereco()
               on aluno.EnderecoId equals endereco.Id
               join curso in FonteDados.GetCurso()
               on aluno.CursoId equals curso.Id
               select new
               {
                   ID = aluno.Id,
                   AlunoNome = aluno.Nome,
                   CursoNome = curso.Nome,
                   EnderecoLocal = endereco.Local,
               };

foreach (var aluno in consulta)
{
    Console.WriteLine($"ID = {aluno.ID}\t Nome = {aluno.AlunoNome}\t Endereço = {aluno.EnderecoLocal} \tCurso = {aluno.CursoNome} ");
}

Console.ReadLine();