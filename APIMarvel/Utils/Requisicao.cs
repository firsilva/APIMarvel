using APIMarvel.Models;
using Microsoft.Extensions.Configuration;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIMarvel.Utils
{
    public class Requisicao
    {
        private readonly IConfiguration _configuration;

        public Requisicao(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public IRestResponse Get(DadosRequisicao req)
        {

            var request = new RestRequest(req.Path, Method.GET);
            request.AddQueryParameter("ts", req.TimeStamp);
            request.AddQueryParameter("apikey", req.ApiPublickey);
            request.AddQueryParameter("hash", req.Hash);
            var client = new RestClient(req.Url);

            IRestResponse response = client.Execute(request);

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
                return response;
            else
                throw new Exception(response.Content);

        }


        public IRestResponse GetId(int id, DadosRequisicao req)
        {
            var request = new RestRequest(req.Path, Method.GET);
            request.AddQueryParameter("id", req.Id);
            request.AddQueryParameter("ts", req.TimeStamp);
            request.AddQueryParameter("apikey", req.ApiPublickey);
            request.AddQueryParameter("hash", req.Hash);
            var client = new RestClient(req.Url);

            IRestResponse response = client.Execute(request);

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
                return response;
            else
                throw new Exception(response.Content);
        }
    }
}

