namespace APIMensajeria.Manager
{
    using APIMensajeria.DTO;
    using ClienteRabbit;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>
    /// Manager de consumos.
    /// </summary>
    public class ConsumoManager
    {
        private RabbitMqClient rabbitMqClient;

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="rabbitClient">Cliente de Rabbit.</param>
        public ConsumoManager(RabbitMqClient rabbitClient)
        {
            this.rabbitMqClient = rabbitClient;
        }

        public ConsumoOutDTO EncolarConsumo(ClienteRabbit.Consumo consumo)
        {
            Consumo cons = rabbitMqClient.EncolarMessage(consumo);

            ConsumoOutDTO consumoDto = new ConsumoOutDTO();
            consumoDto.Code = "201";
            consumoDto.Object = consumo;

            return consumoDto;
        }

    }
}
