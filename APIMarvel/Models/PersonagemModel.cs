using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIMarvel.Models
{
    /// <summary>
    /// Modelo geral do retorno dos dados
    /// </summary>
    public class PersonagemModel
    {
        public int code { get; set; }
        public string copyright { get; set; }
        public string attributionText { get; set; }
        public string attributionHTML { get; set; }
        public string etag { get; set; }
        public data data { get; set; }
    }

    /// <summary>
    /// Local onde possui os results/personagens
    /// </summary>
    public class data
    {
        public int offset { get; set; }
        public int limit { get; set; }
        public int total { get; set; }
        public int count { get; set; }
        public List<results> results { get; set; }
    }

    /// <summary>
    /// Lista de personagens
    /// </summary>
    public class results
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string modified { get; set; }
        public sub comics { get; set; }
        public sub series { get; set; }
        public sub stories { get; set; }
        public sub events { get; set; }
    }

    /// <summary>
    /// Conteúdo de comics, series, stories e events
    /// </summary>
    public class sub
    {
        public List<items> items { get; set; }
    }

    /// <summary>
    /// Conteúdo do Item
    /// </summary>
    public class items
    {
        public string resourceURI { get; set; }
        public string name { get; set; }
    }
}
