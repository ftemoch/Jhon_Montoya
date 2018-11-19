namespace ParcialFinal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialModel1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.LIBROS", "Titulo_Libro", c => c.String(nullable: false, maxLength: 255));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.LIBROS", "Titulo_Libro", c => c.String());
        }
    }
}
