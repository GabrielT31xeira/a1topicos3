namespace a1topicos3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Usuario", "senha", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Usuario", "senha");
        }
    }
}
