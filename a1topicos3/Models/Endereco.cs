using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Web;

namespace a1topicos3.Models
{
    public class Endereco
    {
        public int ID { get; set; }
        public string quadra { get; set; }
        public string rua { get; set; }
        public string lote { get; set; }
    }
}