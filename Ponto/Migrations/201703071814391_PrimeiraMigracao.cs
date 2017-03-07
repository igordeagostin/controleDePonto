namespace Ponto.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PrimeiraMigracao : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Departamentoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Funcionarios",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(unicode: false),
                        Cpf = c.String(unicode: false),
                        Senha = c.String(unicode: false),
                        Foto = c.Binary(),
                        CargaHorariaDiaria = c.Single(nullable: false),
                        CargaHorariaSemanal = c.Single(nullable: false),
                        Admissao = c.DateTime(nullable: false, precision: 0),
                        Demissao = c.DateTime(nullable: false, precision: 0),
                        Situacao = c.String(unicode: false),
                        Departamento_Id = c.Int(),
                        Funcao_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Departamentoes", t => t.Departamento_Id)
                .ForeignKey("dbo.Funcaos", t => t.Funcao_Id)
                .Index(t => t.Departamento_Id)
                .Index(t => t.Funcao_Id);
            
            CreateTable(
                "dbo.Funcaos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(unicode: false),
                        Departamento_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Departamentoes", t => t.Departamento_Id)
                .Index(t => t.Departamento_Id);
            
            CreateTable(
                "dbo.Historicoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Dia = c.DateTime(nullable: false, precision: 0),
                        HoraEntrada = c.DateTime(nullable: false, precision: 0),
                        HoraSaida = c.DateTime(nullable: false, precision: 0),
                        Funcionario_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Funcionarios", t => t.Funcionario_Id)
                .Index(t => t.Funcionario_Id);
            
            CreateTable(
                "dbo.Empresas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Razaosocial = c.String(unicode: false),
                        Cnpj = c.String(unicode: false),
                        Ie = c.String(unicode: false),
                        Endereco = c.String(unicode: false),
                        Numero = c.String(unicode: false),
                        Bairro = c.String(unicode: false),
                        Municipio = c.String(unicode: false),
                        Uf = c.String(unicode: false),
                        Cep = c.String(unicode: false),
                        Logo = c.Binary(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Feriadoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(unicode: false),
                        Data = c.DateTime(nullable: false, precision: 0),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Usuarios",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(unicode: false),
                        Login = c.String(unicode: false),
                        Senha = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Historicoes", "Funcionario_Id", "dbo.Funcionarios");
            DropForeignKey("dbo.Funcionarios", "Funcao_Id", "dbo.Funcaos");
            DropForeignKey("dbo.Funcaos", "Departamento_Id", "dbo.Departamentoes");
            DropForeignKey("dbo.Funcionarios", "Departamento_Id", "dbo.Departamentoes");
            DropIndex("dbo.Historicoes", new[] { "Funcionario_Id" });
            DropIndex("dbo.Funcaos", new[] { "Departamento_Id" });
            DropIndex("dbo.Funcionarios", new[] { "Funcao_Id" });
            DropIndex("dbo.Funcionarios", new[] { "Departamento_Id" });
            DropTable("dbo.Usuarios");
            DropTable("dbo.Feriadoes");
            DropTable("dbo.Empresas");
            DropTable("dbo.Historicoes");
            DropTable("dbo.Funcaos");
            DropTable("dbo.Funcionarios");
            DropTable("dbo.Departamentoes");
        }
    }
}
