using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using Aplicacao02.Models;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Portabilidade_Projeto.DAL
{
    public class BancoDados : DbContext
    {

        public BancoDados() : base("name=BancoDados")
        {
        }

        public DbSet<Produto> Produto { get; set; }
        public DbSet<Fornecedor> Fornecedor { get; set; }

        // Evita pluralização dos nomes da variavel DbSet. Ex: Produto'es'
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

    }

}