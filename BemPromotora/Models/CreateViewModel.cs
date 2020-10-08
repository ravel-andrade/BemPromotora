using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BemPromotora.Models
{
    public class CreateViewModel
    {
        public Usuario usuario { get; set; }
        public List<PerguntaFormulario> perguntaFormulario { get; set; }
        public string[] perguntas;
        public string[,] opcoes;

        public CreateViewModel(Usuario usuario, List<PerguntaFormulario> perguntaFormulario)
        {
            this.usuario = usuario;
            this.perguntaFormulario = perguntaFormulario;
        }

        public CreateViewModel(Usuario usuario, List<PerguntaFormulario> perguntaFormulario, string[] perguntas, string[,] opcoes) : this(usuario, perguntaFormulario)
        {
            this.perguntas = perguntas;
            this.opcoes = opcoes;
        }

        public CreateViewModel()
        {
        }
    }
}
