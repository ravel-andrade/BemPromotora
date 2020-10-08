using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BemPromotora.Models
{
    public class Opcoes
    {
        public int Id { get; set; }
        public string opcao { get; set; }
        public int PerguntaFormularioId { get; set; }

        public Opcoes()
        {
        }

        public Opcoes(int id, string opcao)
        {
            Id = id;
            this.opcao = opcao;
        }
    }
}
