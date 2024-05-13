using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using APIMarvel.Utils;
using APIMarvel.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RestSharp;
using Microsoft.Extensions.Configuration;

namespace APIMarvel.Controllers
{
    [Produces("application/json")]
    [Route("api/marvel/[controller]")]
    [ApiController]
    public class PersonagensController : ControllerBase
    {
        private readonly IConfiguration Configuration;

        public PersonagensController(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        /// <summary>
        /// Responsável por listar os personagens da Marvel
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult<PersonagemModel> Get()
        {
            try
            {
                var response = new MontaRequisicao(Configuration).Enviar(0);
                return JsonConvert.DeserializeObject<PersonagemModel>(response.Content);
            }
            catch (Exception b)
            {
                return BadRequest(JsonConvert.DeserializeObject<Object>(b.Message));
            }
        }

        /// <summary>
        /// Responsável por listar um personagem da Marvel de acordo com o ID
        /// </summary>
        /// <returns></returns>
        [HttpGet("{id}")]
        public ActionResult<PersonagemModel> Get(int id)
        {
            try
            {
                var response = new MontaRequisicao(Configuration).Enviar(id);
                return JsonConvert.DeserializeObject<PersonagemModel>(response.Content);
            }
            catch (Exception b)
            {
                return BadRequest(JsonConvert.DeserializeObject<Object>(b.Message));
            }
        }

        /// <summary>
        /// Responsável por imprimir arquivo .txt na Raiz do projeto com os personagens da Marvel
        /// </summary>
        /// <returns></returns>
        [HttpGet("imprimir")]
        public ActionResult<string> GetImprimir()
        {
            try
            {
                var response = new MontaRequisicao(Configuration).Enviar(0);
                var result = JsonConvert.DeserializeObject<PersonagemModel>(response.Content);
                new Imprimir().arquivo(result);

                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    var obj = JsonConvert.SerializeObject(new Msg
                    {
                        Status = 200,
                        Mensagem = "OK",
                        Detalhes = "Arquivo gerado na Raiz do projeto com todos os personagens",
                        Copyright = "© 2021 MARVEL"
                    });
                    return (obj);
                }
                else
                {
                    throw new Exception(response.Content);
                }
            }
            catch (Exception b)
            {
                return BadRequest(JsonConvert.DeserializeObject<Object>(b.Message));
            }

        }

        /// <summary>
        /// Responsável por imprimir arquivo .txt na Raiz do projeto um personagem da Marvel de acordo com Id escolhido
        /// </summary>
        /// <returns></returns>
        [HttpGet("imprimir/{id}")]
        public ActionResult<string> GetImprimirId(int id)
        {
            try
            {
                var response = new MontaRequisicao(Configuration).Enviar(id);
                var result = JsonConvert.DeserializeObject<PersonagemModel>(response.Content);
                new Imprimir().arquivo(result);

                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    var obj = JsonConvert.SerializeObject(new Msg
                    {
                        Status = 200,
                        Mensagem = "OK",
                        Detalhes = "Arquivo gerado na Raiz do projeto com o Personagem Id =" + id,
                        Copyright = "© 2021 MARVEL"
                    });
                    return (obj);
                }else
                {
                    throw new Exception(response.Content);
                }
            }
            catch (Exception b)
            {
                return BadRequest(JsonConvert.DeserializeObject<Object>(b.Message));
            }
        }

        // Não utilizados
        /*
        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
        */
    }
}
