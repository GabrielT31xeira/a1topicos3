using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace a1topicos3.Models
{
    public class Carro
    {
        public int ID { get; set; }
        public string placa { get; set; }
        public string marca { get; set; }
        public string modelo { get; set; }
        public string cor { get; set; }
        public string tipo_carro { get; set; }
        public string portas { get; set; }
    }
}