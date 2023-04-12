using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace a1topicos3.Models
{
    public class Cartoes
    {
        public int ID { get; set; }
        public string tipo_cartao { get; set; }
        public string numero { get; set; }
        public string cvc { get; set; }
        public string validade { get; set; }

    }
}