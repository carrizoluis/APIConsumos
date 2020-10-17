using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using APIMensajeria.Manager;
using ClienteRabbit;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace APIMensajeria.Controllers
{
    [Route("api/consumo")]
    [ApiController]
    public class ConsumoMessageController : ControllerBase
    {
        private ConsumoManager consumoManager;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="consumoManager">Manager de consumo</param>
        public ConsumoMessageController(ConsumoManager consumoManager)
        {
            this.consumoManager = consumoManager;
        }

        [HttpPost]
        [Route("")]
        public IActionResult AgregarConsumo(Consumo consumo)
        {
            
            return Ok(consumoManager.EncolarConsumo(consumo));
        }

    }
}
