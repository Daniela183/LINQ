//aula 231
using ConsultasLinq;

Console.WriteLine("Consultas Linq");
Console.WriteLine("Consultas simples\n");

var numeros = FonteDados.GetNumeros();

var resultado1 = numeros.Where(n => n < 10);

var resultado2 = numeros.Where(n => n > 1 && n != 4 && n < 20);

var listaNegra = FonteDados.GetListaNegra();

var resultado3 = numeros.Where(n => !listaNegra.Contains(n));

var resultado4 = numeros.Where(n => n > 1)
                        .Where(n => n != 4)
                        .Where(n => n > 20);

Console.WriteLine(string.Join(" ", resultado1));
Console.WriteLine();
Console.WriteLine(string.Join(" ", resultado2));
Console.WriteLine();
Console.WriteLine(string.Join(" ", resultado3));
Console.WriteLine();
Console.WriteLine(string.Join(" ", resultado4));

Console.WriteLine("\nConsultas Complexas\n");

var alunos = FonteDados.GetAlunos();

var resultado5 = alunos.Where(a => a.Nome.StartsWith('A')
                                && a.Idade < 18);
var result = from a in alunos
             where a.Nome.StartsWith('A') && a.Idade > 18
             select a;

foreach (var aluno in resultado5)
    Console.WriteLine(aluno.Nome + ": " + aluno.Idade);





Console.ReadKey();