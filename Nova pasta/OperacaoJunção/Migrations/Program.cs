//aula 240 - 241
using OperacaoJunção;

Console.WriteLine("Operação de junção - Join e GroupJoin");

//static void PopularDataBase()
//{
//    using (var contexto = new AppDBContext())
//    {
//        try
//        {
//            SeedDatabase.PopulaDB(contexto);
//            Console.WriteLine("Concluido com sucesso");
//        }
//        catch (Exception ex) {
//            Console.WriteLine("Erro: " + ex.Message);
//        }
//    }
//}

//static void ExemploInnerJoin()
//{
//    using (var contexto = new AppDBContext())
//    {
//        var innerJoin = contexto.Funcionario        //outer data source
//            .Join(
//                 contexto.Setor,                            //inner data source
//                    funcionario => funcionario.SetorId,     //inner key selector
//                    setor => setor.SetorId,                 //outer key selector
//                    (funcionario, Setor) => new             //projetando dados em vonjunto
//                      {
//                          NomeFuncionario = funcionario.FuncionarioNome,
//                          CargoFuncionario = funcionario.FuncionarioCargo,
//                          NomeSetor = setor.SetorNome,
//                      }).ToList();

//        Console.WriteLine("Funcionário Cargo Setor");
//        foreach (var funcionario in innerJoin)
//        {
//            Console.WriteLine($"{funcionario.NomeFuncionario} " +
//                $"{funcionario.CargoFuncionario}" +
//                $"{funcionario.NomeSetor}");
//        }
//    }
//}
//static void ExemploLeftJoin()
//{
//    using (var contexto = new AppDBContext())
//    {
//        var leftJoin = (from f in contexto.Funcionario 
//                        join s in contexto.Setor
//                         on f.SetorId equals s.SetorId
//                         into FunciSetorGrupo
//                         from setor in FunciSetorGrupo.DefautIfEmpty()
//                         select new
//                         {
//                             NomeFuncionario = funcionario.FuncionarioNome,
//                             CargoFuncionario = funcionario.FuncionarioCargo,
//                             NomeSetor = setor.SetorNome,
//                         }).ToList();

//        Console.WriteLine("Funcionário Cargo Setor");
//        foreach (var funcionario in leftJoin)
//        {
//            Console.WriteLine($"{funcionario.NomeFuncionario} " +
//                $"{funcionario.CargoFuncionario}" +
//                $"{funcionario.NomeSetor}");
//        }
//    }
//}
//static void ExemploRightJoin()
//{
//    using (var contexto = new AppDBContext())
//    {
//        var rightJoin = (from s in contexto.Setor
//                        join f in contexto.Funcionario 
//                        on s.SetorId equals f.SetorId
//                        into SetorFunciGrupo
//                        from funcionario in SetorFunciGrupo.DefautIfEmpty()
//                        select new
//                        {
//                            NomeFuncionario = funcionario.FuncionarioNome,
//                            CargoFuncionario = funcionario.FuncionarioCargo,
//                            NomeSetor = s.SetorNome,
//                        }).ToList();

//        Console.WriteLine("Funcionário Cargo Setor");
//        foreach (var funcionario in rightJoin)
//        {
//            Console.WriteLine($"{funcionario.NomeFuncionario} " +
//                $"{funcionario.CargoFuncionario}" +
//                $"{funcionario.NomeSetor}");
//        }
//    }
//}
//static void ExemploFullJoin()
//{
//    using (var contexto = new AppDBContext())
//    {
//        var leftJoin = from f in contexto.Funcionario
//                       join s in contexto.Setor on f.SetorId equals s.SetorId
//                       into set
//                       from setor in set.DefautIfEmpty()
//                       select new
//                       {
//                           Nome = f.FuncionarioNome,
//                           Cargo = f.FuncionarioCargo,
//                           Setor = setor.SetorNome,
//                       };
//        var rightJoin = from f in contexto.Setor
//                       join s in contexto.Funcionario  on f.SetorId equals s.SetorId
//                       into funci
//                       from setor in funci.DefautIfEmpty()
//                       select new
//                       {
//                           Nome = f.FuncionarioNome,
//                           Cargo = f.FuncionarioCargo,
//                           Setor = setor.SetorNome,
//                       };
//        var fullJoin = leftJoin.Union(rightJoin);
//    }
//}

//static void ExemploCrossJoin()
//{
//    using (var contexto = new AppDBContext())
//    {
//        var crossJoin = from f in contexto.Funcionario
//                        from s in contexto.Setor
//                        select new
//                        {
//                            Nome = f.FuncionarioNome,
//                            Cargo = f.FuncionarioCargo,
//                            Setor = s.SetorNome,
//                        };
//        Console.WriteLine("Funcionário Cargo Setor");
//        foreach (var result in crossJoin)
//        {
//            Console.WriteLine(result.Nome + result.Cargo + result.Setor);
//        }
//    }
//}
//static void ExemploGroupJoin()
//{
//    using (var contexto = new AppDBContext())
//    {
//        var groupJoin = contexto.Setores
//            .GroupJoin(contexto.Funcionario,
//            s => s.SetorId, f => f.SetorId,
//            (f, funcionarioGrupo) => new
//            {
//                Funcionario = funcionarioGrupo,
//                NomeSetor = f.NomeSetor,
//            }).ToList();
//        foreach (var grupo in groupJoin)
//        {
//            Console.WriteLine(grupo.NomeSetor);
//            foreach( var func in grupo.FuncionarioGrupo)
//            {
//                Console.WriteLine(func.FuncionarioNome);
//            }
//            Console.ReadLine();
//        }
//    }
//}