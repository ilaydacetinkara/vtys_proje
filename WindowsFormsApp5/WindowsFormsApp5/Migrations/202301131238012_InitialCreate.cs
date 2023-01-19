namespace WindowsFormsApp5.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Uruns",
                c => new
                    {
                        urun_kod = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.urun_kod);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Uruns");
        }
    }
}
