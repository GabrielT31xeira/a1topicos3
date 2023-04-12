using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace a1topicos3.Models
{
    public class Usuario
    {
        public int ID { get; set; }
        public string nome { get; set; }
        public string email { get; set; }
        public string numero_telefone { get; set; }
        public string documento { get; set; }

        public virtual CarteiraMotorista CarteiraMotorista { get; set;}
        public virtual Endereco Endereco{ get; set; }
        public virtual ICollection<Cartoes> Cartoes { get; set; }
        public virtual ICollection<Carro> Carros { get; set; }

    }
}