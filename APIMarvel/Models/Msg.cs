using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIMarvel.Models
{
    public class Msg
    {
        public int Status { get; set; }
        public string Mensagem { get; set; }
        public string Detalhes { get; set; }
        public string Copyright { get; set; }
    }
}
