using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluxoDeCaixa.Models
{
    [Table(name:"Registros")]
    public class Registro
    {
        public long Id { get; set; }
        public string Descricao { get; set; }
        public DateTime Data { get; set; }
        public float Valor { get; set; }
    }
}
