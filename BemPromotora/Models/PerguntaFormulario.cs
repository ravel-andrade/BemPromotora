using BemPromotora.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BemPromotora.Models
{
    public class PerguntaFormulario : IComparable
    {
        public int Id { get; set; }
        public string Pergunta { get; set; }
        public IEnumerable<Opcoes> Opcoes { get; set; }

        public PerguntaFormulario()
        {
        }

        public PerguntaFormulario(int id, string pergunta, IEnumerable<Opcoes> opcoes)
        {
            Id = id;
            Pergunta = pergunta;
            Opcoes = opcoes;
        }

        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }
    }
}
