using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperadorQuantificacao
{


    public class AlunoComparer : IEqualityComparer<Aluno>
    {
        public bool Equals(Aluno x, Aluno y)
        {
            if (object.ReferenceEquals(x, y)) 
                return true;
            if (x is null || y is null) 
                return false;
            return x.Nome == y.Nome && x.Pontos == y.Pontos;
        }
        public int GetHashCode(Aluno obj) 
        { 
            if (obj is null) 
                return 0;
            int NomeHashCode = obj.Nome == null ? 0 : obj.Nome.GetHashCode();
            int PontosHashCode = obj.Pontos.GetHashCode();
            return NomeHashCode ^ PontosHashCode;
        }

    }
}
