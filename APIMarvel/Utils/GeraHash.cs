using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIMarvel.Utils
{
    public class GeraHash
    {
        public string gerar(string tstamp, string privateKey, string publicKey)
        {
            string hashgerado = MD5Hash.Hash.Content(tstamp + privateKey + publicKey);

            return hashgerado;
        }
    }
}
