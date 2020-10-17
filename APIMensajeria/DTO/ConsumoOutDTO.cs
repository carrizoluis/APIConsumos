using ClienteRabbit;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace APIMensajeria.DTO
{
    public class ConsumoOutDTO
    {

        /// <summary>
        /// Codigo de salida.
        /// </summary>
        [JsonPropertyName("Code")]
        public string Code { get; set; }

        /// <summary>
        /// Mensaje de consumo.
        /// </summary>
        [JsonPropertyName("Object")]
        public Consumo Object { get; set; }
    }
}
