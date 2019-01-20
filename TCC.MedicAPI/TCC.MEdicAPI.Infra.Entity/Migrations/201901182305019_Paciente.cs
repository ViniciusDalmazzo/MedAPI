namespace TCC.MEdicAPI.Infra.Entity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Paciente : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Pacientes", "RG", c => c.String());
            AddColumn("dbo.Pacientes", "CPF", c => c.String());
            DropColumn("dbo.Pacientes", "DataDeNascimento");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Pacientes", "DataDeNascimento", c => c.DateTime(nullable: false));
            DropColumn("dbo.Pacientes", "CPF");
            DropColumn("dbo.Pacientes", "RG");
        }
    }
}
