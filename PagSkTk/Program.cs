//aula 247
Console.WriteLine("Operações por Geração");

Console.ForegroundColor = ConsoleColor.DarkCyan;
Console.WriteLine("---Range---\n");
Console.ResetColor();


IEnumerable<int> numeros = Enumerable.Range(1, 10);

foreach(int i in numeros)
{
    Console.Write($"{i} ");
}

Console.WriteLine("\n\nUsando filtro\n");

IEnumerable<int> pares = Enumerable.Range(10, 30).Where(x => x % 2 == 0);
Console.Write("Os pares de 10 a 30: ");
foreach (int num in pares)
{
    Console.Write($"{num} ");
}

Console.WriteLine("\n");

IEnumerable<int> quadrado = Enumerable.Range(1, 10).Select(x => x * x);

Console.Write("Os quadrado de 1 a 10: ");

foreach (int num in quadrado)
{
    Console.Write($"{num} ");
}

Console.ForegroundColor = ConsoleColor.DarkCyan;
Console.WriteLine("\n\n---Repeat---\n");
Console.ResetColor();

IEnumerable<string> valores = Enumerable.Repeat("Macoratti.net - LINQ", 10);

foreach (string str in valores)
{
    Console.WriteLine(str); 
}

Console.WriteLine();

IEnumerable<int> number = Enumerable.Repeat(2023, 10); //pode usar o var no lugar do IEnumer

foreach (int num in number)
{
    Console.WriteLine(num);
}

Console.ForegroundColor = ConsoleColor.DarkCyan;
Console.WriteLine("\n\n---Empty<T>---\n");
Console.ResetColor();

var vazio = Enumerable.Empty<string>();
foreach (string str in vazio)
{ 
    Console.WriteLine(str); 
}
Console.WriteLine("Concluído");

Console.WriteLine();
Console.ReadKey();