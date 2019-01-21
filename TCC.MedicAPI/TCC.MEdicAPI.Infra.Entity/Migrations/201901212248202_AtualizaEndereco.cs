namespace TCC.MEdicAPI.Infra.Entity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AtualizaEndereco : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Enderecoes", "Paciente_ID", c => c.Int());
            CreateIndex("dbo.Enderecoes", "Paciente_ID");
            AddForeignKey("dbo.Enderecoes", "Paciente_ID", "dbo.Pacientes", "ID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Enderecoes", "Paciente_ID", "dbo.Pacientes");
            DropIndex("dbo.Enderecoes", new[] { "Paciente_ID" });
            DropColumn("dbo.Enderecoes", "Paciente_ID");
        }
    }
}
