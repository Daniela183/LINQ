//aula 239
using OperadoresAgrupamento;

Console.WriteLine("Operadores de agrupamento");
Console.WriteLine("---Agrupamento por Idade---");

var alunos = FonteDados.GetAlunos();

//sintaxe método
var grupos = alunos.GroupBy(a => a.Idade).OrderBy(c => c.Key);

//sintaxe consulta 
var grupos2 = from a in alunos
             group a by a.Idade into grupo
             orderby grupo.Key
             select grupo;

//intera em cada grupo
foreach (var grupo in grupos)
{
    Console.WriteLine($"\nIdade:  {grupo.Key} alunos: {grupo.Count()}");
    //intera a cada aluno
    foreach (var aluno in grupo)
    {
        Console.WriteLine($"\t{aluno.Nome} - {aluno.Curso} - {aluno.Sexo}");
    }
}

Console.WriteLine("\n---Agrupamento por Sexo---");

//sintaxe método
var gruposS = alunos.GroupBy(a => a.Sexo).OrderBy(d => d.Key);

//sintaxe consulta 
var gruposS2 = from a in alunos
              group a by a.Sexo;

//intera em cada grupo
foreach (var grupo1 in gruposS)
{
    Console.WriteLine($"\nSexo:  {grupo1.Key} alunos: {grupo1.Count()}");
    //intera a cada aluno
    foreach (var aluno in grupo1)
    {
        Console.WriteLine($"\t{aluno.Nome} - {aluno.Curso} - {aluno.Sexo}");
    }
}

Console.WriteLine("\n---Agrupamento por Curso---");

//sintaxe método
var gruposC = alunos.GroupBy(a => a.Curso)
    //ordena baseado na chave curso
    .OrderBy(d => d.Key)
    .Select(std => new
    {
        Key = std.Key,
        //ordena baseado no nome
        Alunos = std.OrderBy(x => x.Nome)
    });


//intera em cada grupo
foreach (var grupoC in gruposC)
{
    Console.WriteLine($"\n{grupoC.Key} (alunos: {grupoC.Alunos.Count()})");
    //intera a cada aluno
    foreach (var aluno in grupoC.Alunos)
    {
        Console.WriteLine($"\t{aluno.Nome} - {aluno.Idade} - {aluno.Sexo}");
    }
}

Console.WriteLine("\n---Agrupamento por Curso e Sexo---");

//sintaxe método
var grupos3 = alunos.GroupBy(x => new {x.Curso, x.Sexo})
    //ordena baseado na chave curso
    .OrderByDescending(d => d.Key.Curso)
    .ThenBy(d => d.Key.Sexo)
    .Select(g => new
                   {
                       Curso = g.Key.Curso,
                       Sexo = g.Key.Sexo,
                       //ordena baseado no nome
                       Alunos = g.OrderBy(x => x.Nome)
                   });


//intera em cada grupo
foreach (var grupo3 in grupos3)
{
    Console.WriteLine($"\n{grupo3.Curso} - {grupo3.Sexo} (alunos: {grupo3.Alunos.Count()})");
    //intera a cada aluno
    foreach (var aluno in grupo3.Alunos)
    {
        Console.WriteLine($"\t{aluno.Nome} - {aluno.Idade} - {aluno.Sexo}");
    }
}

Console.WriteLine("\n---Agrupamento por ToLookUp---");

//sintaxe método
var gruposT= alunos.ToLookup(x => x.Curso);

//intera em cada grupo
foreach (var grupo4 in gruposT)
{
    Console.WriteLine($"\n{grupo4.Key} ({grupo4.Count()})");
    //intera a cada aluno
    foreach (var aluno in grupo4)
    {
        Console.WriteLine($"\t{aluno.Nome} - {aluno.Idade} - {aluno.Sexo}");
    }
}
Console.ReadKey();