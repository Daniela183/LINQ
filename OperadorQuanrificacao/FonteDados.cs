﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace OperadorQuantificacao
{
    public class FonteDados
    {
        public static List<Pessoa> GetPessoas()
        {
            List<Pessoa> pessoas = new List<Pessoa>
            {
                new Pessoa
                {
                    Nome = "Maria",
                    Cachorros = new Cachorro[] {
                    new Cachorro { Nome = "Bilu", Idade = 10},
                    new Cachorro{ Nome = "Pipoca", Idade = 14},
                    new Cachorro { Nome = "Negão", Idade = 6}}},
            new Pessoa
            {
                Nome = "Fernando",
                Cachorros = new Cachorro[] {
                new Cachorro { Nome = "Canelinha", Idade = 1 } }
            },
            new Pessoa
            {
                Nome = "Amanda",
                Cachorros = new Cachorro[] {
                new Cachorro { Nome = "Bisteca", Idade = 8 } } } 
            };
            return pessoas;
         }
        public static List<Funcionario> GetFuncionarios()
        {
            List<Funcionario> funcionarios = new()
            {
                new Funcionario() { Nome = "Maria", Idade = 42, Salario = 3290.55m },
                new Funcionario() { Nome = "Manoel", Idade = 34, Salario = 4125.45m },
                new Funcionario() { Nome = "Amanda", Idade = 21, Salario = 5123.99m },
                new Funcionario() { Nome = "Carlos", Idade = 18, Salario = 6200.50m },
                new Funcionario() { Nome = "Alicia", Idade = 15, Salario = 4099.11m },
            };
            return funcionarios;
        }
    }
}

