using a1topicos3.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace a1topicos3.DAL
{
    public class CarroContext : DbContext
    {
        public CarroContext() : base("CarroContext") { }

        public DbSet<Carro> carros { get; set; }
        public DbSet<CarteiraMotorista> carteiraMotoristas { get; set; }
        public DbSet<Cartoes> Cartoes { get; set; }
        public DbSet<Endereco> enderecos { get; set; }
        public DbSet<Usuario> usuarios { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}