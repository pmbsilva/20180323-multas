using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Multas.Models
{
    public class MultasDb : DbContext
    {
        // construtor da classe
        public MultasDb() : base("MultasDbConnectionString")
        {
            // Package Manager Console
            // PM> Enable-Migrations -EnableAutomaticMigrations
            // PM> Update-Database -Verbose
        }

        // identificar as tabelas da base de dados
        public virtual DbSet<Multas> Multas { get; set; }
        public virtual DbSet<Condutores> Condutores { get; set; }
        public virtual DbSet<Viaturas> Viaturas { get; set; }
        public virtual DbSet<Agentes> Agente { get; set; }


    }
}