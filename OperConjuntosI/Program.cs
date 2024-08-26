//aula 233-234
using OperConjuntosI;
using System.ComponentModel.DataAnnotations;

Console.WriteLine("Operações com Conjuntos - I");
Console.WriteLine("---Distinct e DistinctBy---\n");

Console.WriteLine("Idades -> 30, 33, 35, 36, 40, 30, 33, 35, 36, 30, 40\n");

var idadeDistintas = FonteDados.GetIdades().Distinct();

foreach(var idade in idadeDistintas)
{
    Console.Write($"{idade} ");
}

//---------------------------------------------------------------------------------------------------------

Console.WriteLine("\n\nNomes -> Paulo, MARIA, paulo, Amanda, maria, amanda\n");

var nomesDistintos = FonteDados.GetNomes().Distinct(StringComparer.OrdinalIgnoreCase);

foreach (var nome in nomesDistintos)
{
    Console.Write($"{nome} ");
}

//---------------------------------------------------------------------------------------------------------

Console.WriteLine("\n\nNomes -> Maria, Manoel, Amanda, Carlos, Alicia, Jaime, Débora, Sandra\n");

var alunos = FonteDados.GetAlunos().ToList();

var alunosIdadeDistintas = alunos.DistinctBy(a => a.Idade);

foreach (var aluno in alunosIdadeDistintas)
{
    Console.WriteLine($"Aluno - {aluno.Nome} tem {aluno.Idade} anos");
}

var alunosReprovados = new List<string>() { "Amanda", "Alicia", "Jaime" };
var aunosAprovados = alunos.ExceptBy(alunosReprovados, n => n.Nome);

Console.WriteLine("\nAlunos Reprovados: Amanda, Alicia, Jaime\n");

Console.Write("Alunos Aprovados: ");
foreach (var a in aunosAprovados)
{
    Console.Write($" {a.Nome} ");
}

//---------------------------------------------------------------------------------------------------------

Console.WriteLine("\n\n---Except e ExceptBy---\n");

Console.WriteLine("Lista1 -> 1, 2, 3, 4, 5, 6" +
    "\nLista2 -> 1, 3, 5, 8, 9, 10\n");

List<int> fonte1 = new List<int>() { 1, 2, 3, 4, 5, 6};
List<int> fonte2 = new List<int>() { 1, 3, 5, 8, 9, 10};

var resultado = fonte1.Except( fonte2).ToList();

foreach (var item in resultado)
{
    Console.Write($"{item} ");
}

//---------------------------------------------------------------------------------------------------------

Console.WriteLine("\n\nPaíses1 -> Brasil, USA, UK, Argentina, China" +
    "\nPaíses2 -> Brasil, uk, Argentina, França, Japão\n");

var paises1 = FonteDados.GetPaises1();
var paises2 = FonteDados.GetPaises2();

var paisesExceptToList = paises1.Intersect(paises2).ToList();
Console.WriteLine("---Usando ToList---\n");
foreach (var pais in paisesExceptToList)
{
    Console.Write($"{pais} ");
}

var paisesExcept = paises1.Except(paises2, StringComparer.OrdinalIgnoreCase);
Console.WriteLine("\n\n---Usando StringComparer---\n");
foreach (var pais in paisesExcept)
{
    Console.Write($"{pais} ");
}

//---------------------------------------------------------------------------------------------------------

Console.WriteLine("\n\n---Intersect e IntersectBy---\n");

Console.WriteLine("Lista1 -> 1, 2, 3, 4, 5, 6" +
    "\nLista2 -> 1, 3, 5, 8, 9, 10\n");

List<int> fonteDados1 = new List<int>() { 1, 2, 3, 4, 5, 6 };
List<int> fonteDados2 = new List<int>() { 1, 3, 5, 8, 9, 10 };

var resultado1 = fonte1.Intersect(fonte2).ToList();

Console.WriteLine("Usando sintaxe de método\n");
foreach (var item in resultado1)
{
    Console.Write($"{item} ");
}

var resultado2 = (from num in fonteDados1 
                  select num)
                  .Intersect(fonteDados2).ToList();

Console.WriteLine("\n\nUsando sintaxe de consulta\n");
foreach (var item in resultado2)
{
    Console.Write($"{item} ");
}

var paisesIntersectToList = paises1.Intersect(paises2).ToList();
Console.WriteLine("\n\n---Usando ToList---\n");

foreach (var pais in paisesIntersectToList)
{
    Console.Write($"{pais} ");
}

var paisesIntersect = paises1.Intersect(paises2, StringComparer.OrdinalIgnoreCase).ToList();
Console.WriteLine("\n\n---Usando StringComparer e ToList---\n");

foreach (var pais in paisesIntersect)
{
    Console.Write($"{pais} ");
}

var turmaA = FonteDados.GetTurmaA();
var turmaB = FonteDados.GetTurmaB();

var consulta = turmaB.Select(p => p.Nascimento.Year)
                              .Intersect(turmaA.Select(p => p.Nascimento.Year));

var alunosTurmaMesmoAnoNascimento = turmaA.IntersectBy(turmaB.Select(p => p.Nascimento.Year),
                                        p => p.Nascimento.Year);


Console.WriteLine("\n\nTurma A - Alunos com mesmo ano nascimento da Turma B\n");
foreach (var p in alunosTurmaMesmoAnoNascimento)
{
    Console.WriteLine($"{p.Nome} ");
}

Console.WriteLine($"\nTotal de Alunos:  {alunosTurmaMesmoAnoNascimento.Count()}");

//---------------------------------------------------------------------------------------------------------

Console.WriteLine("\n\n---Union e UnionBy---\n");

var resultadoUnion = fonteDados1.Union(fonteDados2).ToList();

foreach (var unin in resultadoUnion)
{
    Console.Write($"{unin} ");
}

Console.WriteLine("\n");

var resultadoUnionPaises = paises1.Union(paises2, StringComparer.OrdinalIgnoreCase).ToList();

foreach (var uniao in resultadoUnionPaises)
{
    Console.Write($"{uniao} ");
}

Console.WriteLine("\n");

var turmasUnion = turmaA.UnionBy(turmaB, p => p.Nome);

Console.WriteLine("Alunos Distintos\n");

foreach (var t in turmasUnion)
{
    Console.WriteLine($"{t.Nome} {t.Nascimento.Year} {t.Idade}");
}

Console.ReadKey();