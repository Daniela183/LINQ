//aula 232
using ProjecaoLinq;

Console.WriteLine("Operdores de Projeção");
Console.WriteLine("Sintaxe de métodos\n");

IEnumerable<Aluno> alunos = FonteDados.GetAlunos().ToList();

Console.WriteLine("---Alunos: Notas---\n");
foreach (var aluno in alunos)
    Console.WriteLine($"{aluno.Nome}: {aluno.Nota}");

IEnumerable<string> nomes = FonteDados.GetAlunos().Select(n => n.Nome);

Console.WriteLine("\n---Alunos---\n");
foreach (var nome in nomes)
    Console.WriteLine(nome);

List<Aluno> lista = FonteDados.GetAlunos().Select(a => new Aluno()
                                            {
                                            Nome = a.Nome,
                                            Idade = a.Idade,
                                            }).ToList();

Console.WriteLine("\n---Alunos: Idade---\n");
foreach (var aluno in lista)
    Console.WriteLine($"{aluno.Nome}: {aluno.Idade}");

var alunosAnonimos = FonteDados.GetAlunos().Select(a => new
                                                    {
                                                     NomeAluno = a.Nome,
                                                     IdadeAluno = a.Idade,
                                                     NotaAluno = a.Nota,
                                                     }).ToList();
Console.WriteLine("\n---Alunos, Idade, Nota---\n");
foreach (var aluno in alunosAnonimos)
    Console.WriteLine($"Nome: {aluno.NomeAluno}, Idade: {aluno.IdadeAluno}, Nota: {aluno.NotaAluno}");

var alunosTiposAnonimos = FonteDados.GetFuncionarios().Select(f => new
                                                {
                                                NomeAluno = f.Nome,
                                                IdadeAluno = f.Idade,
                                                SalarioAnual = f.Salario * 12,
                                                }).ToList();
Console.WriteLine("\n---Alunos, Idade, Salário Anual---\n");
foreach (var aluno in alunosTiposAnonimos)
    Console.WriteLine($"{aluno.NomeAluno}: {aluno.IdadeAluno} {aluno.SalarioAnual.ToString("c")}");

Console.WriteLine("\nSelectMany\n");

List<List<int>> listas = new List<List<int>>
{
    new List<int>{1, 2, 3},
    new List<int>{12},
    new List<int>{5, 6, 5, 7},
    new List<int>{10, 12, 13, 14},
};
IEnumerable<int> resultado = listas.SelectMany(lista => lista.ToList());
foreach (var item in resultado)
    Console.Write($"{item} ");
Console.WriteLine();

IEnumerable<int> resultado1 = listas.SelectMany(lista => lista.Distinct());
foreach (var i in resultado1)
    Console.Write($"{i} ");
Console.WriteLine();

Console.WriteLine("\nUsando Select\n");
IEnumerable<List<string>> retornoSelect = FonteDados.GetAlunos().Select(c => c.Cursos);
foreach (List<String> listaCursos in retornoSelect)
{
    foreach (string curso in listaCursos)
    {
        Console.Write($"{curso} ");
    }
    Console.WriteLine();
}
Console.WriteLine("\nUsando SelectMAny\n");

IEnumerable<string> retornoSelectMany = FonteDados.GetAlunos().SelectMany(c => c.Cursos);
   
foreach (string cursos in retornoSelectMany)
    {
    Console.Write($"{cursos} ");
    }


Console.ReadKey();