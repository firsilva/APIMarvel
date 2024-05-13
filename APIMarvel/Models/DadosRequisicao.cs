using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIMarvel.Models
{
    public class DadosRequisicao
    {
        public string Id { get; set; }
        public string TimeStamp { get; set; }
        public string Metodo { get; set; }
        public string Url { get; set; }
        public string Path { get; set; }
        public string ApiPublickey { get; set; }
        public string ApiPrivatekey { get; set; }
        public string Hash { get; set; }

    }
}
