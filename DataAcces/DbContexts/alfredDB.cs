using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAcces.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAcces.DbContexts
{
    public class alfredDB : DbContext
    {
        public alfredDB()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
        //entities
        public DbSet<AlfDocument> AlfDocuments { get; set; }
        public DbSet<CatalogoDeContrato> CatalogoDeContrato { get; set; }
        public DbSet<CatalogoDeServicio> CatalogoDeServicio { get; set; }
        public DbSet<CatalogoProducto> CatalogoProducto { get; set; }
        public DbSet<ConfigFecha> ConfigFechas { get; set; }
        public DbSet<Empresa> Courses { get; set; }
        public DbSet<FacturasHistorial> FacturasHistorial { get; set; }
        public DbSet<HistorialDeConsulta> HistorialDeConsulta { get; set; }
        public DbSet<TokenEnUso> TokenEnUso { get; set; }
        public DbSet<TokensHistorial> TokensHistorial { get; set; }
        public DbSet<CentroDeCobro> CentroDeCobro { get; set; }

    } 
}
