namespace TCC.MEdicAPI.Infra.Entity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AtualizaEndereco2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Enderecoes", "Paciente_ID", "dbo.Pacientes");
            DropIndex("dbo.Enderecoes", new[] { "Paciente_ID" });
            RenameColumn(table: "dbo.Enderecoes", name: "Paciente_ID", newName: "PacienteId");
            AlterColumn("dbo.Enderecoes", "PacienteId", c => c.Int(nullable: false));
            CreateIndex("dbo.Enderecoes", "PacienteId");
            AddForeignKey("dbo.Enderecoes", "PacienteId", "dbo.Pacientes", "ID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Enderecoes", "PacienteId", "dbo.Pacientes");
            DropIndex("dbo.Enderecoes", new[] { "PacienteId" });
            AlterColumn("dbo.Enderecoes", "PacienteId", c => c.Int());
            RenameColumn(table: "dbo.Enderecoes", name: "PacienteId", newName: "Paciente_ID");
            CreateIndex("dbo.Enderecoes", "Paciente_ID");
            AddForeignKey("dbo.Enderecoes", "Paciente_ID", "dbo.Pacientes", "ID");
        }
    }
}
