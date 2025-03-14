﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperacaoJunção
{ 
    //Entidade principal (pai)
    public class Funcionario
    {
        public int FuncionarioId { get; set; }
        [MaxLength(80)]
        public string FuncionarioNome { get; set; } = null;
        [MaxLength(80)]
        public string FuncionarioCargo { get; set; } = null;
        public int? SetorId { get; set; }
    }
}
