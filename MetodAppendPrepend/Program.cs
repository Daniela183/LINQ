//aula 248
Console.WriteLine("Método Append<T>, Prepend<T> e Zip");
Console.ForegroundColor = ConsoleColor.DarkMagenta;
Console.WriteLine("---Append<T>---\n");
Console.ResetColor();

List<int> numeros = new List<int>() { 1, 2, 3, 4 };
numeros.Append(5);

Console.WriteLine(string.Join(", ", numeros.Append(5)));

var resultado = numeros.Append(5);
Console.WriteLine(string.Join(", ", resultado));

Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine("\nUsando sequência explícita\n");
Console.ResetColor();

List<int> novosNumeros = numeros.Append(5).ToList();
Console.WriteLine(string.Join(", ", novosNumeros));

Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine("\nUsando string\n");
Console.ResetColor();

List<string> frutas = new List<string>() { "Uva", "Banana", "Laranja" };
var resultado1 = frutas.Append("Abacaxi").ToList();
Console.WriteLine(string.Join(", ", resultado1));

Console.ForegroundColor = ConsoleColor.DarkMagenta;
Console.WriteLine("\n---Prepend<T>---\n");
Console.ResetColor();

numeros.Prepend(0);
Console.WriteLine(string.Join(", ", numeros.Prepend(0)));

var resultado2 = numeros.Prepend(0);
Console.WriteLine(string.Join(", ", resultado2));

Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine("\nUsando sequência explícita\n");
Console.ResetColor();

List<int> novosNumeros1 = numeros.Prepend(0).ToList();
Console.WriteLine(string.Join(", ", novosNumeros1));

Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine("\nUsando string\n");
Console.ResetColor();

var resultado3 = frutas.Prepend("Abacaxi").ToList();
Console.WriteLine(string.Join(", ", resultado3));

Console.ForegroundColor = ConsoleColor.DarkMagenta;
Console.WriteLine("\n---Zip---\n");
Console.ResetColor();

int[] numero = { 10, 20, 30, 40, 50 };
string[] palavras = { "Dez", "Vinte", "Trinta", "Quarenta",  };//"Cinquenta"

var resultado4 = numero.Zip(palavras,(prim, seg) => prim + " - " + seg);

foreach(var item in resultado4)
{
    Console.WriteLine(item);
}
Console.WriteLine();

var estados = new[] { "São Paulo", "Rio de Janeiro", "Belo Horizonte" };
var siglas = new[] { "SP", "RJ", "BH" };

var resultado5 = estados.Zip(siglas,(x, y) => x + " - " + y);
foreach(var item in resultado5)
{
    Console.WriteLine(item); 
}

Console.ReadKey();