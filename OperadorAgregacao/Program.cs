//aula 237
using OperadorAgregacao;

Console.WriteLine("Operadores de Agregação - II");
Console.WriteLine("---Count---\n");
Console.WriteLine("C#, Java, Phyton, PHP, JavaScript, Go, ASP.NET, Node\n");
string[] cursos = { "C#", "Java", "Phyton", "PHP", "JavaScript", "Go", "ASP.NET", "Node" };

var resultado = cursos.Count();
Console.WriteLine($"\t{resultado}");

Console.WriteLine("\n---Count com filtro---\n");

var resultado1 = cursos.Count(c => c.Contains('P'));

var resultado2 = cursos.Where(c => c.Contains('A')).Count();

var resultado3 = (from c in cursos
                  where c.Contains('S')
                  select c).Count();

Console.WriteLine($"Usando Count (P) - { resultado1 }");
Console.WriteLine($"Usando Where (A) - { resultado2 }");
Console.WriteLine($"Usando Select (S) - { resultado3 }");

Console.WriteLine("\n---LongCount com filtro---\n");

var resultado4 = cursos.LongCount(c => c.Contains('P'));
var resultado5 = cursos.Where(c => c.Contains('J')).LongCount();
var resultado6 = (from c in cursos
                  where c.Contains('S')
                  select c).LongCount();

Console.WriteLine($"Usando Count (P) - {resultado4}");
Console.WriteLine($"Usando Where (J) - {resultado5}");
Console.WriteLine($"Usando Select (S) - {resultado6}");

Console.WriteLine("\n---Sun---");
Console.WriteLine("Soma dos números: 3, 5, 7, 9, 10, 12, 15, 20, 30, 39 \n");

int[] num = { 3, 5, 7, 9, 10, 12, 15, 20, 30, 39 };

int resultado7 = num.Sum();
Console.WriteLine($"\t{ resultado7}");

Console.WriteLine("\n---Sun com filtro---");
Console.WriteLine("Soma dos números maiores que 10\n");
int resultado8 = num.Where(n => n > 10).Sum();

//sintaxe de consulta
int resultado9 = num.Sum(n =>
{
    if (n > 10)
        return n;
    else return 0;
});
var resultado10 = (from n in num
                  where n > 10
                  select n).Sum();

Console.WriteLine($"\t{resultado8}");
Console.WriteLine($"\t{resultado9}");
Console.WriteLine($"\t{resultado10}");

Console.WriteLine("\n---Max---\n");

var funcionarios = FonteDados.GetFuncionarios();

var maiorIdade = funcionarios.Max(f => f.Idade);
var maiorSalario = funcionarios.Max(f => f.Salario);

//sintaxe de consulta
var resultado11 =(from f in funcionarios
                  select f).Max(f => f.Salario);

Console.WriteLine($"Maior idade = {maiorIdade}\nMaior salário = {maiorSalario}");
Console.WriteLine(resultado11);

Console.WriteLine("\n---MaxBy---\n");

var maiorIdade1 = funcionarios.MaxBy(f => f.Idade);
var maiorSalario1 = funcionarios.MaxBy(f => f.Salario);

//sintaxe de consulta
var resultado12 = (from f in funcionarios
                   select f).MaxBy(f => f.Salario);

Console.WriteLine($"Maior idade = {maiorIdade}\nMaior salário = {maiorSalario}");
Console.WriteLine(resultado12);

Console.WriteLine("\n---Min---\n");

var menorIdade = funcionarios.Min(f => f.Idade);
var menorSalario = funcionarios.Min(f => f.Salario);

//sintaxe de consulta
var resultado13 = (from f in funcionarios
                   select f).Min(f => f.Salario);

Console.WriteLine($"Menor idade = {menorIdade}\nMenor salário = {menorSalario}");
Console.WriteLine(resultado13);

Console.WriteLine("\n---MinBy---\n");

var menorIdade1 = funcionarios.MinBy(f => f.Idade);
var menorSalari2 = funcionarios.MinBy(f => f.Salario);

//sintaxe de consulta
var resultado14 = (from f in funcionarios
                   select f).MinBy(f => f.Salario);

Console.WriteLine($"Menor idade = {menorIdade}\nMenor salário = {menorSalario}");
Console.WriteLine(resultado14);
Console.ReadKey();