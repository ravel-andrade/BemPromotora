using BemPromotora.Data;
using BemPromotora.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace BemPromotora.Services
{
    public class UserServices
    {

        private readonly BemPromotoraContext _context;
        

        public UserServices(BemPromotoraContext context)
        {
            _context = context;

        }

        public CreateViewModel getPerguntas()
        {
            var contentPerguntas =  _context.PerguntaFormulario.ToList();
            var contentOpcoes =  _context.Opcoes.ToList();
            if(contentPerguntas==null || contentOpcoes == null)
            {
                throw new Exception(); 
            }
            foreach(PerguntaFormulario pergunta in contentPerguntas)
            {
                foreach(Opcoes opcao in contentOpcoes)
                {
                    if(opcao.Id == pergunta.Id)
                    {

                        pergunta.Opcoes.Append(opcao);
                    }
                }
            }

            Usuario usuario = new Usuario();
            CreateViewModel viewModel = new CreateViewModel(usuario, contentPerguntas);
            return viewModel;
        }

        public  CreateViewModel Converte(CreateViewModel viewModel)
        {
            int countPerguntas = 0;
            int countOpcoes = 0;

            string[] viewPerguntas= new string[viewModel.perguntaFormulario.Count()];
            string[,] viewOpcoes= new string[viewModel.perguntaFormulario.Count(),4];

                foreach(PerguntaFormulario pergunta in viewModel.perguntaFormulario)
                {
                    viewPerguntas[countPerguntas] = pergunta.Pergunta;
                    
                    foreach(Opcoes opcoes in pergunta.Opcoes)
                    {
                    viewOpcoes[countPerguntas, countOpcoes] = opcoes.opcao;
                    
                        countOpcoes++;
                    
                    }
                countOpcoes = 0;
                countPerguntas++;
            }

            CreateViewModel view = new CreateViewModel(viewModel.usuario, viewModel.perguntaFormulario, viewPerguntas, viewOpcoes);

            return view;
        }
    }
}
