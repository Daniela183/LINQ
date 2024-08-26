// aula 245
Console.WriteLine("Operadores de Particionamento");
Console.WriteLine("---Take---\n");
//usando método
List<int> numeros = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
List<int> resultado = numeros.Take(4).ToList();

foreach (int num in resultado)
{
    Console.Write($" {num} ");
}

Console.WriteLine("\n");

List<int> numeros1 = new List<int>() { 1, 2, 3, 7, 10, 5, 8, 6, 9, 4 };
var resultado1 = numeros1.OrderByDescending(n => n).Take(5);

foreach (int num in resultado1)
{
    Console.Write($" {num} ");
}

Console.WriteLine("\n");

var resultado2 = numeros1.OrderBy(n => n).Where(num => num > 5).Take(4).ToList();

foreach (int num in resultado1)
{
    Console.Write($" {num} ");
}

Console.WriteLine("\n");

var resultado3 = numeros1.OrderBy(n => n).Take(4).Where(num => num > 3);

foreach (int num in resultado3)
{
    Console.Write($" {num} ");
}
//sintaxe de consulta

//List<int> lista = null;
//var resultado4 = (from num in numeros 
//                        select num).Take(4).ToList();

Console.WriteLine("\n");

Console.WriteLine("---TakeWhile---\n");

List<int> resultado4 = numeros.TakeWhile(num => num < 6).ToList();
Console.WriteLine("Com lista ordenada");
foreach (int num in resultado4)
{
    Console.Write($" {num} ");
}
Console.WriteLine();
Console.WriteLine("\nCom lista desordenada");

List<int> resultado5 = numeros1.TakeWhile(num => num < 6).ToList();

foreach (int num in resultado5)
{
    Console.Write($" {num} ");
}

Console.WriteLine("\n\nCom Where, lista desordenada");

List<int> resultado6 = numeros1.Where(num => num < 6).ToList();

foreach (int num in resultado6)
{
    Console.Write($" {num} ");
}
Console.WriteLine("\n");

List<string> nomes = new List<string>() { "Sara", "Raul", "José", "Ana", "Pedro"};
List<string> resultado7 = nomes.TakeWhile((nomes, index) => nomes.Length > index).ToList();

foreach(var nome in resultado7)
{
    Console.Write($" {nome} ");
}
Console.WriteLine();

Console.WriteLine("\n---Skip---\n");

List<int> resultado8 = numeros.Skip(4).ToList();

foreach (int num in resultado8)
{
    Console.Write($" {num} ");
}

Console.WriteLine("\n\nCom Where");

var resultado9 = numeros.Where(num => num > 3).Skip(4).ToList();

foreach (int num in resultado9)
{
    Console.Write($" {num} ");
}

Console.WriteLine("\n");

var resultado10 = numeros.Skip(4).Where(num => num < 7).ToList();

foreach (int num in resultado10)
{
    Console.Write($" {num} ");
}

//Console.WriteLine("\n");

Console.WriteLine("\n\n---SkipWhile---\n");

List<int> resultado11 = numeros.SkipWhile(num => num < 5).ToList();

foreach (int num in resultado11)
{
    Console.Write($" {num} ");
}

Console.WriteLine("\n");

List<int> resultado12 = numeros1.SkipWhile(num => num < 5).ToList();

foreach (int num in resultado12)
{
    Console.Write($" {num} ");
}

Console.WriteLine("\n");

List<string> resultado13 = nomes.SkipWhile((nomes, index) => nomes.Length > index).ToList();

foreach (var nome in resultado13)
{
    Console.Write($" {nome} ");
}

Console.ReadKey();