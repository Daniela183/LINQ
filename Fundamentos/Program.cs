//aula 230
Console.WriteLine("Apresentação dos Fundamentos");

IList<string> frutas = new List<string>() { "Banana", "Maça", "Pêra", "Laranja", "Uva" };

Console.WriteLine("\nQuery syntax");//
var resultado = from f  in frutas
                where f.Contains('r')
                select f;
Console.WriteLine(string.Join(" - ", resultado));

Console.WriteLine("\nQuery syntax");//
var resultado2 = frutas.Where(f => f.Contains('n'));
Console.WriteLine(string.Join(" - ", resultado2));


Console.ReadKey(); 