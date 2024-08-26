// aula 246
using PaginacaoSkipTake;
using System.Xml;

Console.WriteLine("Paginação com Skip e Take");

int RegistrarPorPagina = 5;
int NumeroPagina;

do
{
    Console.Write("\nInforme o nº da página entre 1 e 4: ");

    if (int.TryParse(Console.ReadLine(), out NumeroPagina))
    {
        if (NumeroPagina > 0 && NumeroPagina < 5)
        {
            var alunos = Aluno.GetAlunos()
                .Skip((NumeroPagina - 1) * RegistrarPorPagina)
                .Take(RegistrarPorPagina).ToList();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\nPág. " + NumeroPagina);
            Console.ResetColor();

            foreach (var aluno in alunos)
            {
                Console.WriteLine($"Id: {aluno.Id}\t Nome: {aluno.Nome}\t Curso: {aluno.Curso}");
            }
        }
        else
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nInforme um nº válido");
            Console.ResetColor();

    }
    else
    {
        Console.WriteLine("\nInforme um nº válido");
    }
} while (true);


//Console.ReadKey();