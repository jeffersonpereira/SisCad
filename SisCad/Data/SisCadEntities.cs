using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Objects;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace SisCadLibrary.Data
{
    public partial class SisCadEntities : DbContext
    {
        public SisCadEntities(string connection)
            :base(connection)
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove <PluralizingTableNameConvention>();
        }
        
        public DbSet<cargo> cargo { get; set; }
        public DbSet<centro_custo> centro_custo { get; set; }
        public DbSet<departamento> departamento { get; set; }
        public DbSet<empresa> empresa { get; set; }
        public DbSet<ferias> ferias { get; set; }
        public DbSet<funcionario> funcionario { get; set; }
        public DbSet<movimentacao> movimentacao { get; set; }
        public DbSet<setor> setor { get; set; }
        public DbSet<municipio> municipio { get; set; }
        public DbSet<usuario> usuario { get; set; }

     }
}
