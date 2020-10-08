using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BemPromotora.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string FaixaIdade { get; set; }
        public string Convenio { get; set; }
        public string FaixaSalarial { get; set; }
        public string MotivoEmprestimo { get; set; }

        public Usuario() { }

        public Usuario(int id, string faixaIdade, string convenio, string faixaSalarial, string motivoEmprestimo)
        {
            Id = id;
            FaixaIdade = faixaIdade;
            Convenio = convenio;
            FaixaSalarial = faixaSalarial;
            MotivoEmprestimo = motivoEmprestimo;
        }
    }
}
