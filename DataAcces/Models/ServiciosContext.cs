using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DataAcces.Models;

public partial class ServiciosContext : DbContext
{
    public ServiciosContext()
    {
    }

    public ServiciosContext(DbContextOptions<ServiciosContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AlfDocument> AlfDocuments { get; set; }

    public virtual DbSet<AspNetRole> AspNetRoles { get; set; }

    public virtual DbSet<AspNetRoleClaim> AspNetRoleClaims { get; set; }

    public virtual DbSet<AspNetUser> AspNetUsers { get; set; }

    public virtual DbSet<AspNetUserClaim> AspNetUserClaims { get; set; }

    public virtual DbSet<AspNetUserLogin> AspNetUserLogins { get; set; }

    public virtual DbSet<AspNetUserToken> AspNetUserTokens { get; set; }

    public virtual DbSet<BitacoraVisitum> BitacoraVisita { get; set; }

    public virtual DbSet<CatalogoDeContrato> CatalogoDeContratos { get; set; }

    public virtual DbSet<CatalogoDeProcedimento> CatalogoDeProcedimentos { get; set; }

    public virtual DbSet<CatalogoDeServicio> CatalogoDeServicios { get; set; }

    public virtual DbSet<CatalogoProducto> CatalogoProductos { get; set; }

    public virtual DbSet<CentroDeCobro> CentroDeCobros { get; set; }

    public virtual DbSet<ConfigFecha> ConfigFechas { get; set; }

    public virtual DbSet<Empresa> Empresas { get; set; }

    public virtual DbSet<FacturasHistorial> FacturasHistorials { get; set; }

    public virtual DbSet<GeneEmail> GeneEmails { get; set; }

    public virtual DbSet<HistorialDeConsulta> HistorialDeConsultas { get; set; }

    public virtual DbSet<ProveedoresServicio> ProveedoresServicios { get; set; }

    public virtual DbSet<RegistroRepositorio> RegistroRepositorios { get; set; }

    public virtual DbSet<TokenEnUso> TokenEnUsos { get; set; }

    public virtual DbSet<TokensHistorial> TokensHistorials { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseNpgsql("Server=10.0.0.3;Database=servicios;User Id=postgres;Password=Adm1n1Nt3gro2022;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AlfDocument>(entity =>
        {
            entity.HasKey(e => e.IdDocument).HasName("alf_document_pkey");

            entity.ToTable("alf_document", "alfred");

            entity.Property(e => e.IdDocument)
                .UseIdentityAlwaysColumn()
                .HasColumnName("id_document");
            entity.Property(e => e.DescripcionAnulacion)
                .HasColumnType("character varying")
                .HasColumnName("descripcion_anulacion");
            entity.Property(e => e.Direccion)
                .HasColumnType("character varying")
                .HasColumnName("direccion");
            entity.Property(e => e.DocumentoPago)
                .HasColumnType("character varying")
                .HasColumnName("documento_pago");
            entity.Property(e => e.Estado)
                .HasColumnType("character varying")
                .HasColumnName("estado");
            entity.Property(e => e.FechaCheque).HasColumnName("fecha_cheque");
            entity.Property(e => e.FechaDocumento).HasColumnName("fecha_documento");
            entity.Property(e => e.FormaPago)
                .HasColumnType("character varying")
                .HasColumnName("forma_pago");
            entity.Property(e => e.IdCliente)
                .HasColumnType("character varying")
                .HasColumnName("id_cliente");
            entity.Property(e => e.IdEmpresa).HasColumnName("id_empresa");
            entity.Property(e => e.IdFactura).HasColumnName("id_factura");
            entity.Property(e => e.Moneda)
                .HasColumnType("character varying")
                .HasColumnName("moneda");
            entity.Property(e => e.Nit)
                .HasColumnType("character varying")
                .HasColumnName("nit");
            entity.Property(e => e.NoFactura)
                .HasColumnType("character varying")
                .HasColumnName("no_factura");
            entity.Property(e => e.Nombre)
                .HasColumnType("character varying")
                .HasColumnName("nombre");
            entity.Property(e => e.NombreBanco)
                .HasColumnType("character varying")
                .HasColumnName("nombre_banco");
            entity.Property(e => e.NumeroBoleta)
                .HasColumnType("character varying")
                .HasColumnName("numero_boleta");
            entity.Property(e => e.NumeroCheque)
                .HasColumnType("character varying")
                .HasColumnName("numero_cheque");
            entity.Property(e => e.NumeroContrato)
                .HasColumnType("character varying")
                .HasColumnName("numero_contrato");
            entity.Property(e => e.Observaciones)
                .HasColumnType("character varying")
                .HasColumnName("observaciones");
            entity.Property(e => e.PrecioConImpuestos)
                .HasColumnType("character varying")
                .HasColumnName("precio_con_impuestos");
            entity.Property(e => e.TipoCambio).HasColumnName("tipo_cambio");
            entity.Property(e => e.TipoDocumento)
                .HasColumnType("character varying")
                .HasColumnName("tipo_documento");
            entity.Property(e => e.ValorBoleta).HasColumnName("valor_boleta");
            entity.Property(e => e.ValorCheque).HasColumnName("valor_cheque");
            entity.Property(e => e.ValorDocumento).HasColumnName("valor_documento");
            entity.Property(e => e.ValorEfectivo).HasColumnName("valor_efectivo");
            entity.Property(e => e.ValorExencionIva).HasColumnName("valor_exencion_iva");
            entity.Property(e => e.ValorRetencionIsr).HasColumnName("valor_retencion_isr");
            entity.Property(e => e.ValorRetencionIva).HasColumnName("valor_retencion_iva");
            entity.Property(e => e.ValorTc).HasColumnName("valor_tc");
            entity.Property(e => e.Vendedor)
                .HasColumnType("character varying")
                .HasColumnName("vendedor");
        });

        modelBuilder.Entity<AspNetRole>(entity =>
        {
            entity.HasIndex(e => e.NormalizedName, "RoleNameIndex").IsUnique();
        });

        modelBuilder.Entity<AspNetRoleClaim>(entity =>
        {
            entity.HasIndex(e => e.RoleId, "IX_AspNetRoleClaims_RoleId");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.Role).WithMany(p => p.AspNetRoleClaims).HasForeignKey(d => d.RoleId);
        });

        modelBuilder.Entity<AspNetUser>(entity =>
        {
            entity.HasIndex(e => e.NormalizedEmail, "EmailIndex");

            entity.HasIndex(e => e.NormalizedUserName, "UserNameIndex").IsUnique();

            entity.HasMany(d => d.Roles).WithMany(p => p.Users)
                .UsingEntity<Dictionary<string, object>>(
                    "AspNetUserRole",
                    r => r.HasOne<AspNetRole>().WithMany().HasForeignKey("RoleId"),
                    l => l.HasOne<AspNetUser>().WithMany().HasForeignKey("UserId"),
                    j =>
                    {
                        j.HasKey("UserId", "RoleId");
                        j.HasIndex(new[] { "RoleId" }, "IX_AspNetUserRoles_RoleId");
                    });
        });

        modelBuilder.Entity<AspNetUserClaim>(entity =>
        {
            entity.HasIndex(e => e.UserId, "IX_AspNetUserClaims_UserId");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.User).WithMany(p => p.AspNetUserClaims).HasForeignKey(d => d.UserId);
        });

        modelBuilder.Entity<AspNetUserLogin>(entity =>
        {
            entity.HasKey(e => new { e.LoginProvider, e.ProviderKey });

            entity.HasIndex(e => e.UserId, "IX_AspNetUserLogins_UserId");

            entity.HasOne(d => d.User).WithMany(p => p.AspNetUserLogins).HasForeignKey(d => d.UserId);
        });

        modelBuilder.Entity<AspNetUserToken>(entity =>
        {
            entity.HasKey(e => new { e.UserId, e.LoginProvider, e.Name });

            entity.HasOne(d => d.User).WithMany(p => p.AspNetUserTokens).HasForeignKey(d => d.UserId);
        });

        modelBuilder.Entity<BitacoraVisitum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("bitacora_visita_pkey");

            entity.ToTable("bitacora_visita", "procedimientos_integro");

            entity.Property(e => e.Id)
                .UseIdentityAlwaysColumn()
                .HasColumnName("id");
            entity.Property(e => e.Email)
                .HasColumnType("character varying")
                .HasColumnName("email");
            entity.Property(e => e.NombreProcedimiento)
                .HasColumnType("character varying")
                .HasColumnName("nombre_procedimiento");
            entity.Property(e => e.Url)
                .HasColumnType("character varying")
                .HasColumnName("url");
        });

        modelBuilder.Entity<CatalogoDeContrato>(entity =>
        {
            entity.HasKey(e => e.IdContrato).HasName("catalogo_de_contrato_pkey");

            entity.ToTable("catalogo_de_contrato", "alfred");

            entity.Property(e => e.IdContrato)
                .UseIdentityAlwaysColumn()
                .HasColumnName("id_contrato");
            entity.Property(e => e.CcNav)
                .HasColumnType("character varying")
                .HasColumnName("cc_nav");
            entity.Property(e => e.NombreContrato)
                .HasColumnType("character varying")
                .HasColumnName("nombre_contrato");
            entity.Property(e => e.TipoContrato)
                .HasColumnType("character varying")
                .HasColumnName("tipo_contrato");
        });

        modelBuilder.Entity<CatalogoDeProcedimento>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("catalogo_de_procedimentos_pkey");

            entity.ToTable("catalogo_de_procedimentos", "procedimientos_integro");

            entity.Property(e => e.Id)
                .UseIdentityAlwaysColumn()
                .HasColumnName("id");
            entity.Property(e => e.Nombre)
                .HasColumnType("character varying")
                .HasColumnName("nombre");
            entity.Property(e => e.Url)
                .HasColumnType("character varying")
                .HasColumnName("url");
        });

        modelBuilder.Entity<CatalogoDeServicio>(entity =>
        {
            entity.HasKey(e => e.IdAlfred).HasName("catalogo_de_servicios_pkey");

            entity.ToTable("catalogo_de_servicios", "alfred");

            entity.Property(e => e.IdAlfred).HasColumnName("id_alfred");
            entity.Property(e => e.CcNav)
                .HasColumnType("character varying")
                .HasColumnName("cc_nav");
            entity.Property(e => e.Descripcion)
                .HasColumnType("character varying")
                .HasColumnName("descripcion");
            entity.Property(e => e.Nombre)
                .HasColumnType("character varying")
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<CatalogoProducto>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_catalogo_prod");

            entity.ToTable("catalogo_productos", "alfred");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Descripcion)
                .HasColumnType("character varying")
                .HasColumnName("descripcion");
            entity.Property(e => e.IdFactura).HasColumnName("id_factura");
            entity.Property(e => e.TypoDocumento)
                .HasColumnType("character varying")
                .HasColumnName("typo_documento");
        });

        modelBuilder.Entity<CentroDeCobro>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("centro_de_cobro", "alfred");

            entity.Property(e => e.CentroCobro)
                .HasColumnType("character varying")
                .HasColumnName("centro_cobro");
            entity.Property(e => e.CodigoCentroCobro)
                .HasColumnType("character varying")
                .HasColumnName("codigo_centro_cobro");
            entity.Property(e => e.CodigoProyecto)
                .HasColumnType("character varying")
                .HasColumnName("codigo_proyecto");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasColumnName("id");
        });

        modelBuilder.Entity<ConfigFecha>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("config_fecha", "alfred");

            entity.Property(e => e.Espesifica)
                .HasColumnType("character varying")
                .HasColumnName("espesifica");
            entity.Property(e => e.FechaFinal)
                .HasColumnType("character varying")
                .HasColumnName("fecha_final");
            entity.Property(e => e.FechaInicial)
                .HasColumnType("character varying")
                .HasColumnName("fecha_inicial");
        });

        modelBuilder.Entity<Empresa>(entity =>
        {
            entity.HasKey(e => e.IdEmpresa).HasName("pk_empresa");

            entity.ToTable("empresas", "alfred");

            entity.Property(e => e.IdEmpresa)
                .ValueGeneratedNever()
                .HasColumnName("id_empresa");
            entity.Property(e => e.Empresa1)
                .HasColumnType("character varying")
                .HasColumnName("empresa");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
        });

        modelBuilder.Entity<FacturasHistorial>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_fac_hist");

            entity.ToTable("facturas_historial", "alfred");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Codclientenav)
                .HasColumnType("character varying")
                .HasColumnName("codclientenav");
            entity.Property(e => e.FechaFactura)
                .HasDefaultValueSql("now()")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_factura");
            entity.Property(e => e.FechaSincronizacion)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha_sincronizacion");
            entity.Property(e => e.IdCliente).HasColumnName("id_cliente");
            entity.Property(e => e.IdEmpresa).HasColumnName("id_empresa");
            entity.Property(e => e.IdFactura).HasColumnName("id_factura");
            entity.Property(e => e.Numfacturanav)
                .HasColumnType("character varying")
                .HasColumnName("numfacturanav");

            entity.HasOne(d => d.IdEmpresaNavigation).WithMany(p => p.FacturasHistorials)
                .HasForeignKey(d => d.IdEmpresa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_fac_empresa");
        });

        modelBuilder.Entity<GeneEmail>(entity =>
        {
            entity.HasKey(e => e.EmailId).HasName("Gene_Emails_pkey");

            entity.ToTable("gene_emails", "repositorio");

            entity.Property(e => e.EmailId)
                .UseIdentityAlwaysColumn()
                .HasColumnName("email_id");
            entity.Property(e => e.Email)
                .HasColumnType("character varying")
                .HasColumnName("email");
            entity.Property(e => e.TipoCorreo).HasColumnName("tipo_correo");
            entity.Property(e => e.Usuario)
                .HasColumnType("character varying")
                .HasColumnName("usuario");
        });

        modelBuilder.Entity<HistorialDeConsulta>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_historial");

            entity.ToTable("historial_de_consultas", "alfred");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CantidadDeDatosSincronizados)
                .HasColumnType("character varying")
                .HasColumnName("cantidad_de_datos_sincronizados");
            entity.Property(e => e.Estado)
                .HasColumnType("character varying")
                .HasColumnName("estado");
            entity.Property(e => e.Mensaje)
                .HasColumnType("character varying")
                .HasColumnName("mensaje");
            entity.Property(e => e.TipoDeConsulta)
                .HasColumnType("character varying")
                .HasColumnName("tipo_de_consulta");
        });

        modelBuilder.Entity<ProveedoresServicio>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("proveedores_servicio_pkey");

            entity.ToTable("proveedores_servicio", "repositorio");

            entity.Property(e => e.Id)
                .UseIdentityAlwaysColumn()
                .HasColumnName("id");
            entity.Property(e => e.IdNav)
                .HasColumnType("character varying")
                .HasColumnName("id_nav");
            entity.Property(e => e.Nombre)
                .HasColumnType("character varying")
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<RegistroRepositorio>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("registro_repositorio_pkey");

            entity.ToTable("registro_repositorio", "repositorio");

            entity.Property(e => e.Id)
                .UseIdentityAlwaysColumn()
                .HasColumnName("id_");
            entity.Property(e => e.CorreoProveedor)
                .HasColumnType("character varying")
                .HasColumnName("correo_proveedor");
            entity.Property(e => e.Factura)
                .HasColumnType("character varying")
                .HasColumnName("factura");
            entity.Property(e => e.FecIngreso).HasColumnName("fec_ingreso");
            entity.Property(e => e.FechaFactura)
                .HasComment("fecha de la factura")
                .HasColumnName("fecha_factura");
            entity.Property(e => e.IndEstado)
                .HasMaxLength(1)
                .HasColumnName("ind_estado");
            entity.Property(e => e.OrdCompra)
                .HasColumnType("character varying")
                .HasColumnName("ord_compra");
            entity.Property(e => e.OrdenNo)
                .HasColumnType("character varying")
                .HasColumnName("orden_no");
            entity.Property(e => e.PathFactura)
                .HasColumnType("character varying")
                .HasColumnName("path_factura");
            entity.Property(e => e.PathOrdCompra)
                .HasColumnType("character varying")
                .HasColumnName("path_ord_compra");
            entity.Property(e => e.Proveedor)
                .HasColumnType("character varying")
                .HasColumnName("proveedor");
            entity.Property(e => e.Total).HasColumnName("total");
        });

        modelBuilder.Entity<TokenEnUso>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_token_actual");

            entity.ToTable("token_en_uso", "alfred");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Token)
                .HasColumnType("character varying")
                .HasColumnName("token");
        });

        modelBuilder.Entity<TokensHistorial>(entity =>
        {
            entity.ToTable("tokens_historial", "alfred");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Fecha)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fecha");
            entity.Property(e => e.IndEstado).HasColumnName("ind_estado");
            entity.Property(e => e.Token).HasColumnName("token");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
