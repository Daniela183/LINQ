//aula 249
using System.Collections;
using System.Linq.Expressions;

Console.WriteLine("Operadores de Conversão");
Console.WriteLine("---AsEnumerable---\n");

int[] numeros = new int[] { 1, 2, 3, 4, 5 };
var resultado = numeros.AsEnumerable();

foreach (int numero in numeros)
{
    Console.Write(numero + " ");
}
Console.WriteLine("\n");

var paises = new List<string> { "US", "UK", "India", "Russia", "China", "Brasil" };
var resultado1 = paises.AsEnumerable();

foreach (var pais in paises)
{
    Console.Write(pais + " ");
}

Console.WriteLine("\n\n---AsQueryable---\n");

List<int> numero1 = new List<int> { 78, 92, 100, 37, 81 };
IQueryable<int> resultado2 = numero1.AsQueryable();

Expression expressionTree = resultado2.Expression;

Console.WriteLine("O NodeTyr árvore de expressão é: "
    + expressionTree.NodeType.ToString());

Console.WriteLine("O tipo da árvore de expressão é: " 
    + expressionTree.Type.Name);

Console.WriteLine("\n");

foreach (var numero in resultado2)
    Console.Write($"{numero} ");

Console.WriteLine("\n");

var numeros2 = new int[] { 5, 10, 20, 60, 72, 90, 102, 114 };
double media = Queryable.Average(numeros2.AsQueryable());
int soma = Queryable.Sum(numeros2.AsQueryable());
int conta = Queryable.Count(numeros2.AsQueryable());
int maximo = Queryable.Max(numeros2.AsQueryable());
int minimo = Queryable.Min(numeros2.AsQueryable());

Console.WriteLine("5, 10, 20, 60, 72, 90, 102, 114\n");
Console.WriteLine($"Quantidade: {conta}");
Console.WriteLine($"Soma: {soma}");
Console.WriteLine($"Média: {media}");
Console.WriteLine($"Mínimo: {minimo}");
Console.WriteLine($"Máximo: {maximo}");

Console.WriteLine("\n\n---Cast---\n");

ArrayList lista = new ArrayList { 10, 20, 30 };

IEnumerable<int> resultado3 = lista.Cast<int>(); //var

foreach (int i in resultado3)
    Console.Write(i + " ");

Console.WriteLine("\n\n---OfType---\n");

List<object> dados = new List<object>()
{
    "Tania", "Maria", 50, "Manoel", 10, 20, 30, 40, "Tiago"
};

var dadosInt = dados.OfType<int>().ToList();

foreach (int i in dadosInt)
{
    Console.Write(i + " ");
}

Console.WriteLine("\n");
var dadosString = dados.OfType<string>().ToList();

foreach (var i in dadosString)
{
    Console.Write(i + " ");
}

Console.ReadLine();