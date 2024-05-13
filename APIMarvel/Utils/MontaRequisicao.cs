using APIMarvel.Models;
using Microsoft.Extensions.Configuration;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIMarvel.Utils
{
    public class MontaRequisicao
    {
        private readonly IConfiguration Configuration;

        public MontaRequisicao(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IRestResponse Enviar(int id)
        {
            var req = new DadosRequisicao();

            req.Id = id.ToString();          
            req.Url = Configuration.GetSection("CONFIGAPI").GetSection("URL_BASE").Value;
            req.Path = Configuration.GetSection("CONFIGAPI").GetSection("CHARACTERS").Value;
            req.Metodo = "Method.GET";
            req.TimeStamp = Convert.ToDouble(Math.Truncate(DateTime.Now.Subtract(new DateTime(1970, 1, 1)).TotalSeconds)).ToString();
            req.ApiPrivatekey = Configuration.GetSection("CONFIGAPI").GetSection("APIPRIVATEKEY").Value;
            req.ApiPublickey = Configuration.GetSection("CONFIGAPI").GetSection("APIPUBLICKEY").Value;
            req.Hash = new GeraHash().gerar(req.TimeStamp.ToString(), req.ApiPrivatekey, req.ApiPublickey);

            if(id == 0)
            {
                var response = new Requisicao(Configuration).Get(req);
                return response;
            }
            else
            {
                var response = new Requisicao(Configuration).GetId(id, req);
                return response;
            }
            
        }
    }
}
