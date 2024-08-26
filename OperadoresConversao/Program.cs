// aula 244
using OperadoresConversao;

Console.WriteLine("Operadores de conversão");
Console.WriteLine("---Usando ToList em paises---\n");
string[] paises = { "US", "UK", "India", "Russia", "China", "Brasil", "Peru" };
var resultado = paises.ToList();

foreach (var pais in resultado)
{
    Console.Write($"{pais} ");
}
Console.WriteLine("\n\n---Usando ToList 'M'---\n");
var alunos = FonteDados.GetAluno();
var lista = alunos.Where(a => a.Nome.Contains('M')).ToList();

foreach (var aluno in lista)
{
    Console.WriteLine($"{aluno.Nome} ");
}

Console.WriteLine("\n---Usando ToArray 'a'---\n ");

var listaA = alunos.Where(a => a.Nome.Contains('a')).ToArray();

foreach (var alunoA in listaA)
{
    Console.WriteLine($"{alunoA.Nome} ");
}

Console.WriteLine("\n---Usando IEnumerable e ToArray---\n");

IEnumerable<Pacote> pacotes = new List<Pacote> //pode ser List
{
    new Pacote {Empresa="Google", Peso = 5.2 },
    new Pacote {Empresa="JcmSoft", Peso = 8.7 },
    new Pacote {Empresa="Twitter", Peso = 3.8},
}.AsEnumerable();

string[] empresas = pacotes.Select(pct => pct.Empresa).ToArray();

foreach (var empresa in empresas)
{
    Console.WriteLine(empresa);
}

Console.WriteLine("\n---Usando ToDictionary---\n");

var listaD = alunos.ToDictionary<Aluno, int>(a => a.Id);

foreach (var chave in listaD.Keys)
{
    Console.WriteLine($"Chave: {chave}, Valor: {(listaD[chave] as Aluno).Nome}");
}

Console.WriteLine("\n---Usando ToLookup---\n");

var funcionarios = FonteDados.GetFuncionarios();//ienumerable<Funcinario>

var funciPorCity = funcionarios.ToLookup(x => x.Cidade); //agrupa por cidade

Console.WriteLine("Funcionários agrupado por Cidade");
foreach (var func in funciPorCity)
{
    Console.WriteLine(func.Key);
    foreach (var item in funciPorCity[func.Key])
    {
        Console.WriteLine("\t" + item.Nome + "\t" + item.Cargo);
    }
}
Console.ReadKey();