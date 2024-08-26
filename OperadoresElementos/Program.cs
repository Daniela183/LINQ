//aula 242
using OperadoresElementos;

Console.WriteLine("Operadores de Elementos - I e II");

Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("\n---ElementAt---\n");
Console.ResetColor();

List<int> numeros = new List<int>() { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };

Console.WriteLine("0\t 1\t 2\t 3\t 4\t 5\t 6\t 7\t 8\t 9    (indices)");
Console.WriteLine("10\t 20\t 30\t 40\t 50\t 60\t 70\t 80\t 90\t 100\t\n");

int resultado = numeros.ElementAt(5);
Console.WriteLine($"Condição: Elemento 5 = { resultado}");

var aluno = FonteDados.GetAluno().ElementAt(5);
Console.WriteLine("\t\t      Id  Nome  IdCurso");
Console.WriteLine($"Condição: Elemento 5 = {aluno.Id} {aluno.Nome} {aluno.CursoId}");

var nome = FonteDados.GetAluno().Select(a => a.Nome).ElementAt(5);
Console.WriteLine($"Condição: Elemento 5 = {nome}");

Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("\n---ElementAtOrDefaut---\n");
Console.ResetColor();

//List<int> numeros1 = new List<int>() { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };

//Console.WriteLine("0\t 1\t 2\t 3\t 4\t 5\t 6\t 7\t 8\t 9    (indices)");
//Console.WriteLine("10\t 20\t 30\t 40\t 50\t 60\t 70\t 80\t 90\t 100\t\n");

int resultado1 = numeros.ElementAtOrDefault(10);
Console.WriteLine($"Condição: Elemento 10 = {resultado1}");

var aluno1 = FonteDados.GetAluno().ElementAtOrDefault(4);
Console.WriteLine("\t\t      Id  Nome  IdCurso");
Console.WriteLine($"Condição: Elemento 4 = {aluno1.Id} {aluno1.Nome} {aluno1.CursoId}");

var nome1 = FonteDados.GetAluno().Select(a => a.Nome).ElementAtOrDefault(4);
Console.WriteLine($"Condição: Elemento 4 = {nome1}");

Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("\n---First---\n");
Console.ResetColor();

//List<int> numeros2 = new List<int>() { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };

//Console.WriteLine("0\t 1\t 2\t 3\t 4\t 5\t 6\t 7\t 8\t 9    (indices)");
//Console.WriteLine("10\t 20\t 30\t 40\t 50\t 60\t 70\t 80\t 90\t 100\t\n");

int resultado2 = numeros.First();
int resultado3 = numeros.First(n => n >20);

Console.WriteLine($"O primeiro número da lista = { resultado2 }");
Console.WriteLine($"Condição: (n => n > 20) = { resultado3 }");

var aluno2 = FonteDados.GetAluno().First();
var aluno3 = FonteDados.GetAluno().First(a => a.CursoId == 30);

Console.WriteLine($"\nO primeiro número da lista = {aluno2.Id} {aluno2.Nome} {aluno2.CursoId}");
Console.WriteLine($"Condição: (a => a.CursoId == 30) {aluno3.Id} {aluno3.Nome} {aluno3.CursoId}");

Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine("\n---FirstOrDefault---\n");
Console.ResetColor();

List<int> numeros3 = new List<int>() { 10, 20, 30, 40, 50, 60, 70, 80, 90, 90 };

Console.WriteLine("0\t 1\t 2\t 3\t 4\t 5\t 6\t 7\t 8\t 9    (indices)");
Console.WriteLine("10\t 20\t 30\t 40\t 50\t 60\t 70\t 80\t 90\t 90\t\n");

int resultado4 = numeros3.FirstOrDefault();
int resultado5 = numeros3.FirstOrDefault(n => n > 20);

int resultado6 = numeros3.FirstOrDefault(n => n > 90);
Console.WriteLine($"Exeção: {resultado6}");

Console.WriteLine($"\nO primeiro número da lista = {resultado2}");
Console.WriteLine($"Condição: (n => n > 20) = {resultado3}");

var aluno4 = FonteDados.GetAluno().FirstOrDefault();
var aluno5 = FonteDados.GetAluno().FirstOrDefault(a => a.CursoId == 30);

Console.WriteLine($"\nO primeiro número da lista = {aluno2.Id} {aluno2.Nome} {aluno2.CursoId}");
Console.WriteLine($"Condição: (a => a.CursoId == 30) {aluno3.Id} {aluno3.Nome} {aluno3.CursoId}");

//aula 243
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("\n---Last---\n");
Console.ResetColor();

int resultado7 = numeros.Last();
Console.WriteLine($"O último da lista: {resultado7}");

int resultado8 = numeros.Last(num => num < 50);
Console.WriteLine($"O último da lista <50: {resultado8}");

Console.WriteLine("\nMensagem exception para Last");
List<int> numeros2 = new List<int>() { };
//int resultado11 = numeros2.Last();
//Console.WriteLine($"\nExeção: {resultado11}");

Console.WriteLine("Mensagem exception para Last");
List<int> numeros1 = new List<int>() { 1, 2, 3 };
//int resultado12 = numeros1.Last(num => num > 5);
//Console.WriteLine($"Exeção: {resultado12}");

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("\n---LastOrDefault---\n");
Console.ResetColor();

int resultado9 = numeros.LastOrDefault();
Console.WriteLine($"O último da lista: {resultado7}");

int resultado10 = numeros.LastOrDefault(num => num < 50);
Console.WriteLine($"O último da lista <50: {resultado8}");

int resultado13 = numeros2.LastOrDefault();
Console.WriteLine($"\nExeção: {resultado13}");

int resultado14 = numeros1.LastOrDefault(num => num > 5);
Console.WriteLine($"Exeção: {resultado14}");

Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine("\n---Single---\n");
Console.ResetColor();

Console.WriteLine("{ 10, 20, 30 }\n"); 

List<int> numeros4 = new List<int>() { 10 };
int resultado11 = numeros4.Single();
Console.WriteLine($"Retorna o único elemento da lista: {resultado11}");

List<int> numeros5 = new List<int>() { 10, 20, 30 };
int resultado12 = numeros5.Single(num => num > 20);
Console.WriteLine($"Número >20: {resultado12}");

Console.WriteLine("\nMensagem exception para Single pois tem mais de um elemento >10");
//int resultado15 = numeros5.Single(num => num > 10);
//Console.WriteLine($"Número >10: {resultado15}");

Console.ForegroundColor = ConsoleColor.DarkCyan;
Console.WriteLine("\n---SingleOrDefault---\n");
Console.ResetColor();

List<int> numeros6 = new List<int>() { };
int resultado16 = numeros6.SingleOrDefault();
Console.WriteLine($"Retorna o número padrão: {resultado16}");

int resultado17 = numeros5.SingleOrDefault(num => num > 50);
Console.WriteLine(" n => n >50 ");
Console.WriteLine($"Retorna o número padrão: {resultado17}");

Console.ForegroundColor = ConsoleColor.DarkMagenta;
Console.WriteLine("\n---DefaultEmpty---\n");
Console.ResetColor();

IEnumerable<int> resultado18 = numeros5.DefaultIfEmpty();
Console.Write("Retorna os elementos da lista: ");
foreach (int nums in resultado18)
{
    Console.Write($"{ nums } " );
}

IEnumerable<int> resultado19 = numeros6.DefaultIfEmpty();
foreach (int num in resultado19)
{
    Console.WriteLine($"\nLista vazia: { num }");
}

IEnumerable<int> resultado20 = numeros6.DefaultIfEmpty(5);
foreach (int numd in resultado20)
{
    Console.WriteLine($"Lista vazia com elemento definido: {numd}\n");
}

var Filmes = new List<Filmes>
            {
                new Filmes("Titanic", 7) ,
                new Filmes("De volta para o futuro", 8) ,
                new Filmes("Mulher maravilha", 6) ,
              };

var filmeFavorito = new Filmes("O quinto elemento", 10);

var filmeAssistir = Filmes.Where(f => f.Avaliação >= 9)
    .DefaultIfEmpty(filmeFavorito).First();

Console.WriteLine($"Filme assistir nota > 9: {filmeAssistir.Titulo}");

Console.ReadKey();