namespace a1topicos3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Telefone",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ddd = c.String(),
                        telefone = c.String(),
                        Usuario_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Usuario", t => t.Usuario_ID)
                .Index(t => t.Usuario_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Telefone", "Usuario_ID", "dbo.Usuario");
            DropIndex("dbo.Telefone", new[] { "Usuario_ID" });
            DropTable("dbo.Telefone");
        }
    }
}
