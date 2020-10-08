using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BemPromotora.Models;

namespace BemPromotora.Data
{
    public class BemPromotoraContext : DbContext
    {
        public BemPromotoraContext (DbContextOptions<BemPromotoraContext> options)
            : base(options)
        {
        }

        public DbSet<BemPromotora.Models.Usuario> Usuario { get; set; }
        public DbSet<BemPromotora.Models.Opcoes> Opcoes { get; set; }
        public DbSet<BemPromotora.Models.PerguntaFormulario> PerguntaFormulario { get; set; }
    }
}
