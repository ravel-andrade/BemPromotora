using BemPromotora.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BemPromotora.Data
{
    public class SeedingService
    {
        private BemPromotoraContext _context;

        public SeedingService(BemPromotoraContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if(_context.PerguntaFormulario.Any() || _context.Opcoes.Any())
            {
                return;
            }

            Opcoes o1 = new Opcoes(1, "Até 30 Anos");
            Opcoes o2 = new Opcoes(2, "De 30 a 50 anos");
            Opcoes o3 = new Opcoes(3, "De 50 a 65 anos");
            Opcoes o4 = new Opcoes(4, "Acima de 65 anos");
            Opcoes o5 = new Opcoes(5, "INSS");
            Opcoes o6 = new Opcoes(6, "SIAPE");
            Opcoes o7 = new Opcoes(7, "Forças Armadas");
            Opcoes o8 = new Opcoes(8, "Outros");
            Opcoes o9 = new Opcoes(9, "Até 2 SM");
            Opcoes o10 = new Opcoes(10, "De 2 a 4 SM");
            Opcoes o11 = new Opcoes(11, "De 4 a 6 SM");
            Opcoes o12 = new Opcoes(12, "Acima de 6 SM");
            Opcoes o13 = new Opcoes(13, "Pagar contar");
            Opcoes o14 = new Opcoes(14, "Reforma da casa");
            Opcoes o15 = new Opcoes(15, "Compra de Carro");
            Opcoes o16 = new Opcoes(16, "Outras");

            List<Opcoes> list1 = new List<Opcoes>();
            List<Opcoes> list2 = new List<Opcoes>();
            List<Opcoes> list3 = new List<Opcoes>();
            List<Opcoes> list4 = new List<Opcoes>();

            list1.Add(o1);
            list1.Add(o2);
            list1.Add(o3);
            list1.Add(o4);
            list2.Add(o5);
            list2.Add(o6);
            list2.Add(o7);
            list2.Add(o8);
            list3.Add(o9);
            list3.Add(o10);
            list3.Add(o11);
            list3.Add(o12);
            list4.Add(o13);
            list4.Add(o14);
            list4.Add(o15);
            list4.Add(o16);

            PerguntaFormulario p1 = new PerguntaFormulario(1, "Qual sua faixa de idade:", list1);
            PerguntaFormulario p2 = new PerguntaFormulario(2, "Qual seu convênio:", list2);
            PerguntaFormulario p3 = new PerguntaFormulario(3, "Qual sua faixa salarial:", list3);
            PerguntaFormulario p4 = new PerguntaFormulario(4, "Por que você realizou o empréstimo:", list4);


            _context.Opcoes.AddRange(o1,o2,o3,o4,o5,o6,o7,o8,o9,o10,o11,o12,o13,o14,o15,o16);
            _context.PerguntaFormulario.AddRange(p1, p2, p3, p4);
            _context.SaveChanges();
        }
    }
}
