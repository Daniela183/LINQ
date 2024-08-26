//aula 235
using OperdoresOrdenados;

Console.WriteLine("Opredores de Ordenação\n");
Console.WriteLine("---Usando OrderBy---");
Console.WriteLine("Nomes -> Paulo, Tarcísio, Amaral, Pedro, Debora, Helena, Percival, Manoel, Rute, José\n");

List<string> nomes = new List<string>() { "Paulo", "Tarcísio", "Amaral", "Pedro",
    "Debora", "Helena", "Percival", "Manoel", "Rute", "José"};

var lista = nomes.OrderBy(x => x).ToList();

foreach (var item in lista)
    Console.WriteLine(item);

//-----------------------------------------------------------------

Console.WriteLine("\n---Usando OrderByDescending---\n");
var lista2 = nomes.OrderByDescending(x => x).ToList();

foreach (var item in lista2)
    Console.WriteLine(item);

//-----------------------------------------------------------------

Console.WriteLine("\n---Usando OrderByDescending ThenByDescending---\n");

var alunos = FonteDados.GetAlunos();

var listaAl1 = alunos.OrderBy(n => n.Nome);
var listaAl2 = alunos.Where(n => n.Nome.Contains("r")).OrderBy(n => n.Nome);
var listaAl3 = alunos.Where(n => n.Nome.Contains("r"))
    .OrderBy(n => n.Nome).ThenBy(n => n.Idade);
var listaAl4 = alunos.Where(n => n.Nome.Contains("r"))
    .OrderByDescending(n => n.Nome).ThenByDescending(n => n.Idade);
//var listaAl5 = alunos.OrderBy(n => n.Nome);

Console.WriteLine("Usando Where, Contains e OrderBy\n");
foreach (var item in listaAl1)
    Console.WriteLine($"{item.Nome} {item.Idade}");

Console.WriteLine("\nUsando Where, Contains, OrderBy e ThenBy\n");
foreach (var item in listaAl2)
    Console.WriteLine($"{item.Nome} {item.Idade}");

Console.WriteLine("\nUsando Where, Contains, OrderBy e ThenBy\n");
foreach (var item in listaAl3)
    Console.WriteLine($"{item.Nome} {item.Idade}");

Console.WriteLine("\nUsando Where, Contains, OrderByDescending, ThenByDescending\n");
foreach (var item in listaAl4)
    Console.WriteLine($"{item.Nome} {item.Idade}");

//-----------------------------------------------------------------

Console.WriteLine("\n---Usando Reverse---");

List<string> nomesRev = new List<string>() 
        {"Pedro", "Tania", "Amaral", "Penita", "Debora"};
Console.WriteLine("Nomes -> Pedro, Tania, Amaral, Penita, Debora\n");

IEnumerable<string> list1 = nomesRev.AsEnumerable().Reverse();
IQueryable<string> list2 = nomesRev.AsQueryable().Reverse();

foreach (var nomesR in list1)
    Console.Write($"{nomesR} ");

Console.ReadKey();