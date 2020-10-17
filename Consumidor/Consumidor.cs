using ClienteRabbit;
using System;
using System.Collections.Generic;
using System.Text;

namespace Consumidor
{
    public class Consumidor
    {
        public void Consumir()
        {
            RabbitMqClient cliente = new RabbitMqClient();
            cliente.consumir();
        }
    }
}
