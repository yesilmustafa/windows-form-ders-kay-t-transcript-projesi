namespace A8CFManyToMany.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class a1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Dersler",
                c => new
                    {
                        DersID = c.Int(nullable: false, identity: true),
                        DersAdi = c.String(nullable: false, maxLength: 50),
                        Kredi = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.DersID);
            
            CreateTable(
                "dbo.DersOgrencileri",
                c => new
                    {
                        DersID = c.Int(nullable: false),
                        OgrenciID = c.Int(nullable: false),
                        KayitTarihi = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => new { t.DersID, t.OgrenciID })
                .ForeignKey("dbo.Dersler", t => t.DersID, cascadeDelete: true)
                .ForeignKey("dbo.Ogrenciler", t => t.OgrenciID, cascadeDelete: true)
                .Index(t => t.DersID)
                .Index(t => t.OgrenciID);
            
            CreateTable(
                "dbo.Ogrenciler",
                c => new
                    {
                        OgrenciID = c.Int(nullable: false, identity: true),
                        Ad = c.String(nullable: false, maxLength: 20),
                        Soyad = c.String(nullable: false, maxLength: 30),
                        DogumTarihi = c.DateTime(nullable: false, storeType: "date"),
                        Cinsiyet = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.OgrenciID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.DersOgrencileri", "OgrenciID", "dbo.Ogrenciler");
            DropForeignKey("dbo.DersOgrencileri", "DersID", "dbo.Dersler");
            DropIndex("dbo.DersOgrencileri", new[] { "OgrenciID" });
            DropIndex("dbo.DersOgrencileri", new[] { "DersID" });
            DropTable("dbo.Ogrenciler");
            DropTable("dbo.DersOgrencileri");
            DropTable("dbo.Dersler");
        }
    }
}
