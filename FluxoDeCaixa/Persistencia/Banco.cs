using FluxoDeCaixa.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluxoDeCaixa.Persistencia
{
    public class Banco : DbContext
    {
        public virtual DbSet<Registro> Registros { get; set; }
    }
}
