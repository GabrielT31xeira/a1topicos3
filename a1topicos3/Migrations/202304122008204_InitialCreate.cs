namespace a1topicos3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Carro",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        placa = c.String(),
                        marca = c.String(),
                        modelo = c.String(),
                        cor = c.String(),
                        tipo_carro = c.String(),
                        portas = c.String(),
                        Usuario_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Usuario", t => t.Usuario_ID)
                .Index(t => t.Usuario_ID);
            
            CreateTable(
                "dbo.CarteiraMotorista",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        validade = c.String(),
                        numero_registro = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Cartoes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        tipo_cartao = c.String(),
                        numero = c.String(),
                        cvc = c.String(),
                        validade = c.String(),
                        Usuario_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Usuario", t => t.Usuario_ID)
                .Index(t => t.Usuario_ID);
            
            CreateTable(
                "dbo.Endereco",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        quadra = c.String(),
                        rua = c.String(),
                        lote = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Usuario",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        nome = c.String(),
                        email = c.String(),
                        numero_telefone = c.String(),
                        documento = c.String(),
                        CarteiraMotorista_ID = c.Int(),
                        Endereco_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.CarteiraMotorista", t => t.CarteiraMotorista_ID)
                .ForeignKey("dbo.Endereco", t => t.Endereco_ID)
                .Index(t => t.CarteiraMotorista_ID)
                .Index(t => t.Endereco_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Usuario", "Endereco_ID", "dbo.Endereco");
            DropForeignKey("dbo.Cartoes", "Usuario_ID", "dbo.Usuario");
            DropForeignKey("dbo.Usuario", "CarteiraMotorista_ID", "dbo.CarteiraMotorista");
            DropForeignKey("dbo.Carro", "Usuario_ID", "dbo.Usuario");
            DropIndex("dbo.Usuario", new[] { "Endereco_ID" });
            DropIndex("dbo.Usuario", new[] { "CarteiraMotorista_ID" });
            DropIndex("dbo.Cartoes", new[] { "Usuario_ID" });
            DropIndex("dbo.Carro", new[] { "Usuario_ID" });
            DropTable("dbo.Usuario");
            DropTable("dbo.Endereco");
            DropTable("dbo.Cartoes");
            DropTable("dbo.CarteiraMotorista");
            DropTable("dbo.Carro");
        }
    }
}
