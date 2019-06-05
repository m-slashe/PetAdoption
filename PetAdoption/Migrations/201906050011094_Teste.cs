namespace PetAdoption.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Teste : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Abrigoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Especies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Pets",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        DataDeNascimento = c.DateTime(nullable: false),
                        Historia = c.String(),
                        IdSexo = c.Int(nullable: false),
                        IdRaca = c.Int(nullable: false),
                        IdEspecie = c.Int(nullable: false),
                        IdPorte = c.Int(nullable: false),
                        IdAbrigo = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Abrigoes", t => t.IdAbrigo, cascadeDelete: true)
                .ForeignKey("dbo.Especies", t => t.IdEspecie, cascadeDelete: true)
                .ForeignKey("dbo.Portes", t => t.IdPorte, cascadeDelete: true)
                .ForeignKey("dbo.Racas", t => t.IdRaca, cascadeDelete: true)
                .ForeignKey("dbo.Sexoes", t => t.IdSexo, cascadeDelete: true)
                .Index(t => t.IdSexo)
                .Index(t => t.IdRaca)
                .Index(t => t.IdEspecie)
                .Index(t => t.IdPorte)
                .Index(t => t.IdAbrigo);
            
            CreateTable(
                "dbo.Portes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Sexoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Pets", "IdSexo", "dbo.Sexoes");
            DropForeignKey("dbo.Pets", "IdRaca", "dbo.Racas");
            DropForeignKey("dbo.Pets", "IdPorte", "dbo.Portes");
            DropForeignKey("dbo.Pets", "IdEspecie", "dbo.Especies");
            DropForeignKey("dbo.Pets", "IdAbrigo", "dbo.Abrigoes");
            DropIndex("dbo.Pets", new[] { "IdAbrigo" });
            DropIndex("dbo.Pets", new[] { "IdPorte" });
            DropIndex("dbo.Pets", new[] { "IdEspecie" });
            DropIndex("dbo.Pets", new[] { "IdRaca" });
            DropIndex("dbo.Pets", new[] { "IdSexo" });
            DropTable("dbo.Sexoes");
            DropTable("dbo.Portes");
            DropTable("dbo.Pets");
            DropTable("dbo.Especies");
            DropTable("dbo.Abrigoes");
        }
    }
}
