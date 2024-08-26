using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperadoresElementos
{
    public class Filmes
    {
        public string? Titulo {  get; set; }
        public int Avaliação { get; set; }
        public Filmes(string? titulo, int avaliação)
        {
            Titulo = titulo;
            Avaliação = avaliação;
        }
        public Filmes() { }
    }
}
