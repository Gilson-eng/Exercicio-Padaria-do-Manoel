using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Dominio.Models
{
    public partial class ApplicationContext : DbContext
    {
        private static ApplicationContext Db;
        

        private ApplicationContext()
        {
        }

        private ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {

         }

        public static ApplicationContext GetInstance()
        {
            if (Db == null)
            {
                Db = new ApplicationContext();

            }
            return Db;
        }


        public virtual DbSet<TbCategorium> TbCategoria { get; set; }
        public virtual DbSet<TbComandum> TbComanda { get; set; }
        public virtual DbSet<TbItemComandum> TbItemComanda { get; set; }
        public virtual DbSet<TbMovimento> TbMovimentos { get; set; }
        public virtual DbSet<TbPerfil> TbPerfils { get; set; }
        public virtual DbSet<TbProduto> TbProdutos { get; set; }
        public virtual DbSet<TbUnidadeMedidum> TbUnidadeMedida { get; set; }
        public virtual DbSet<TbUsuario> TbUsuarios { get; set; }
        public IEnumerable<object> TbPerfil { get; internal set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseMySQL("server=mysql746.umbler.com;port=41890;database=padaria_poo;user=pooii2022;password=2022pooii;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TbCategorium>(entity =>
            {
                entity.HasKey(e => e.Idcategoria)
                    .HasName("PRIMARY");

                entity.ToTable("TB_Categoria");

                entity.Property(e => e.Idcategoria)
                    .HasColumnType("int(11)")
                    .HasColumnName("IDCategoria");

                entity.Property(e => e.Descricao)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TbComandum>(entity =>
            {
                entity.HasKey(e => e.Idcomanda)
                    .HasName("PRIMARY");

                entity.ToTable("TB_Comanda");

                entity.Property(e => e.Idcomanda)
                    .HasColumnType("int(11)")
                    .HasColumnName("IDComanda");
            });

            modelBuilder.Entity<TbItemComandum>(entity =>
            {
                entity.HasKey(e => e.IditemComanda)
                    .HasName("PRIMARY");

                entity.ToTable("TB_Item_Comanda");

                entity.HasIndex(e => e.Idcomanda, "FK_Comanda");

                entity.HasIndex(e => e.Idproduto, "FK_Produto");

                entity.Property(e => e.IditemComanda)
                    .HasColumnType("int(11)")
                    .HasColumnName("IDItemComanda");

                entity.Property(e => e.Idcomanda)
                    .HasColumnType("int(11)")
                    .HasColumnName("IDComanda");

                entity.Property(e => e.Idproduto)
                    .HasColumnType("int(11)")
                    .HasColumnName("IDProduto");

                entity.Property(e => e.Quantidade).HasColumnType("decimal(10,2)");

                entity.Property(e => e.ValorUnitario).HasColumnType("decimal(10,2)");

                entity.HasOne(d => d.IdcomandaNavigation)
                    .WithMany(p => p.TbItemComanda)
                    .HasForeignKey(d => d.Idcomanda)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Comanda");

                entity.HasOne(d => d.IdprodutoNavigation)
                    .WithMany(p => p.TbItemComanda)
                    .HasForeignKey(d => d.Idproduto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Produto");
            });

            modelBuilder.Entity<TbMovimento>(entity =>
            {
                entity.HasKey(e => e.Idmovimento)
                    .HasName("PRIMARY");

                entity.ToTable("TB_Movimento");

                entity.HasIndex(e => e.Idusuario, "FK_User");

                entity.Property(e => e.Idmovimento)
                    .HasColumnType("int(11)")
                    .HasColumnName("IDMovimento");

                entity.Property(e => e.Descricao)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Idusuario)
                    .HasColumnType("int(11)")
                    .HasColumnName("IDUsuario");

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Valor).HasColumnType("decimal(10,2)");

                entity.HasOne(d => d.IdusuarioNavigation)
                    .WithMany(p => p.TbMovimentos)
                    .HasForeignKey(d => d.Idusuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_User");
            });

            modelBuilder.Entity<TbPerfil>(entity =>
            {
                entity.HasKey(e => e.Idperfil)
                    .HasName("PRIMARY");

                entity.ToTable("TB_Perfil");

                entity.Property(e => e.Idperfil)
                    .HasColumnType("int(11)")
                    .HasColumnName("IDPerfil");

                entity.Property(e => e.Descricao)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TbProduto>(entity =>
            {
                entity.HasKey(e => e.Idproduto)
                    .HasName("PRIMARY");

                entity.ToTable("TB_Produtos");

                entity.HasIndex(e => e.Idcategoria, "FK_Categoria");

                entity.HasIndex(e => e.IdunidadeMedida, "FK_UnidadeMedida");

                entity.Property(e => e.Idproduto)
                    .HasColumnType("int(11)")
                    .HasColumnName("IDProduto");

                entity.Property(e => e.CodigoDeBarras)
                    .IsRequired()
                    .HasMaxLength(15);

                entity.Property(e => e.Descricao)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.Idcategoria)
                    .HasColumnType("int(11)")
                    .HasColumnName("IDCategoria");

                entity.Property(e => e.IdunidadeMedida)
                    .HasColumnType("int(11)")
                    .HasColumnName("IDUnidadeMedida");

                entity.Property(e => e.Quantidade).HasColumnType("decimal(10,2)");

                entity.Property(e => e.QuantidadeMinima).HasColumnType("decimal(10,2)");

                entity.Property(e => e.ValorUnitario).HasColumnType("decimal(10,2)");

                entity.HasOne(d => d.IdcategoriaNavigation)
                    .WithMany(p => p.TbProdutos)
                    .HasForeignKey(d => d.Idcategoria)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Categoria");

                entity.HasOne(d => d.IdunidadeMedidaNavigation)
                    .WithMany(p => p.TbProdutos)
                    .HasForeignKey(d => d.IdunidadeMedida)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UnidadeMedida");
            });

            modelBuilder.Entity<TbUnidadeMedidum>(entity =>
            {
                entity.HasKey(e => e.IdunidadeMedida)
                    .HasName("PRIMARY");

                entity.ToTable("TB_UnidadeMedida");

                entity.Property(e => e.IdunidadeMedida)
                    .HasColumnType("int(11)")
                    .HasColumnName("IDUnidadeMedida");

                entity.Property(e => e.Descricao)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<TbUsuario>(entity =>
            {
                entity.HasKey(e => e.Idusuario)
                    .HasName("PRIMARY");

                entity.ToTable("TB_Usuario");

                entity.HasIndex(e => e.Idperfil, "FK_Perfil");

                entity.Property(e => e.Idusuario)
                    .HasColumnType("int(11)")
                    .HasColumnName("IDUsuario");

                entity.Property(e => e.Idperfil)
                    .HasColumnType("int(11)")
                    .HasColumnName("IDPerfil");

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.Senha)
                    .IsRequired()
                    .HasMaxLength(15);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.HasOne(d => d.IdperfilNavigation)
                    .WithMany(p => p.TbUsuarios)
                    .HasForeignKey(d => d.Idperfil)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Perfil");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
