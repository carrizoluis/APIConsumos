using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClienteRabbit
{
    public class Consumo
    {
        /// <summary>
        /// Tipo de consumo.
        /// </summary>
        [JsonProperty(@"TipoConsumo")]
        public string TipoConsumo { get; set; }

        /// <summary>
        /// Importe del consumo.
        /// </summary>
        [JsonProperty(@"Importe")]
        public double Importe { get; set; }
    }
}
