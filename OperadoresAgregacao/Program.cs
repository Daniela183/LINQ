//aula 236
using OperadoresAgregacao;

Console.WriteLine("Operadores de Agregação - I");
Console.WriteLine("---Aggregate---\n");

string[] cursos = { "C#", "Java", "Phyton", "PHP", "JavaScript", "Go" };

string resultado = cursos.Aggregate((s1, s2) => s1 + ", " + s2);
Console.WriteLine(resultado);


Console.WriteLine("\n---Multiplicação dos números 3x5x7x9---\n");
int[] numeros = { 3, 5, 7, 9 };

int resultado1 = numeros.Aggregate((n1, n2) => n1 * n2);
Console.WriteLine($"\t{resultado1}");


Console.WriteLine("\n---Semente inicial---\n");

var alunos = FonteDados.GetAlunos();

string listaAlunos = alunos.Aggregate<Alunos, string>(
    "Nomes: ", (semente, alunos) => semente += alunos.Nome + ", ");

int indice = listaAlunos.LastIndexOf(",");
listaAlunos = listaAlunos.Remove(indice);

Console.WriteLine(listaAlunos);


Console.WriteLine("\n---Semente inicial e seletor de resultado---\n");

string listaAlunos1 = alunos.Aggregate<Alunos, string, string>(
    "Nomes: ", (semente, aluno) => semente += aluno.Nome + ", ",
    resultado1 => resultado1.Substring(0, resultado1.Length-2));

Console.WriteLine(listaAlunos1);


Console.WriteLine("\n---Average - Média de idades---\n");

var mediaIdades = alunos.Average(aluno => aluno.Idade);
Console.WriteLine($"\t{ mediaIdades }");

Console.ReadKey();

