//aula 238
using OperadorQuantificacao;

Console.WriteLine("Operadores de Quantificação");
Console.WriteLine("---All---\n");

int[] numeros = { 10, 22, 32, 44, 56, 64, 78 };

var resultado = numeros.All(n => n % 2 == 0);
var resultado2 = (from n in numeros
                  select n).All(n => n % 2 == 0);

Console.WriteLine($"{(resultado? "Todos são pares" : "Nem todos são pares")}");

var funcionarios = FonteDados.GetFuncionarios();

//sintaxe método
var todoSalarioAcima2500 = funcionarios.All(f => f.Salario > 2500.00m);
var todosMaior21 = funcionarios.All(f => f.Idade > 21);
var todoNomeLetraA = funcionarios.All(f => f.Nome.Contains('a'));

Console.Write($"\nTodos os salários são > 2500? {todoSalarioAcima2500} \n" +
    $"Todos são maiores que 21 anos? {todosMaior21} \nTodos tem letra A no nome? {todoNomeLetraA}");

//sintaxe consulta

var resultado3 = (from f in funcionarios
                  select f).All(f => f.Salario > 2500);

Console.WriteLine($"\n\n{(resultado3 ? "Todos salários são > 2500" : "Nem todos são > 2500")}");

Console.WriteLine("\n");

var pessoas = FonteDados.GetPessoas();

var nomes = (from pessoa in pessoas
            where pessoa.Cachorros.All(pet => pet.Idade > 5)
            select pessoa.Nome);

foreach (var pessoa in nomes)
{
    Console.WriteLine(nomes);
}

Console.WriteLine("\n---Any---\n");

Console.WriteLine("C#, Java, Phyton, PHP, JavaScript, Go, ASP.NET, Node\n");
string[] cursos = { "C#", "Java", "Phyton", "PHP", "JavaScript", "Go", "ASP.NET", "Node" };

var existeCursos = cursos.Any();
var existeCursoMaior2 = cursos.Any(c => c.Length > 2);
var resultado4 = (from c in cursos
                 select c).Any(c => c.Contains('P'));
Console.WriteLine($"Existe cursos: {existeCursos}\nTem curso > 2: {existeCursoMaior2}\nTem curso com P: { resultado4}");


List<Cachorro> cachorros = new()
{
    new Cachorro { Nome = "Bilu", Idade = 6, Vacinado = true},
    new Cachorro{ Nome = "Pipoca", Idade = 3, Vacinado = false},
    new Cachorro { Nome = "Canelinha", Idade = 8, Vacinado = true}
};

bool naoVacinados = cachorros.Any(p => p.Idade > 2 && p.Vacinado == false);
Console.WriteLine($"\n{(naoVacinados ? "Existem" : "Não Existem")} cães com mais de 2 anos não vacinados");

Console.WriteLine("\n---Contains---\n");

var ressult = numeros.Contains(22);
Console.WriteLine($"Tem o número 22 na coleção? {ressult}\n");

List<Aluno> alunos = new List<Aluno>()
            {
            new Aluno() { Nome = "Maria", Pontos = 42 },
            new Aluno() { Nome = "Manoel", Pontos = 34 },
            new Aluno() { Nome = "Amanda", Pontos = 25 }
};

AlunoComparer comparer = new AlunoComparer();

var aluno1 = new Aluno() { Nome = "Maria", Pontos = 42 };
var resultado5 = alunos.Contains(aluno1, comparer);

var resultado6 = (from num in alunos
                  select num).Contains(aluno1, comparer);

Console.WriteLine($"{resultado5} {resultado6}");










Console.ReadKey();