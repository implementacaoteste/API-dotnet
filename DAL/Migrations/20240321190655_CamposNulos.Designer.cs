﻿// <auto-generated />
using DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DAL.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240321190655_CamposNulos")]
    partial class CamposNulos
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.3");

            modelBuilder.Entity("GrupoUsuarioPermissao", b =>
                {
                    b.Property<int>("GrupoUsuarioListId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("PermissaoListId")
                        .HasColumnType("INTEGER");

                    b.HasKey("GrupoUsuarioListId", "PermissaoListId");

                    b.HasIndex("PermissaoListId");

                    b.ToTable("GrupoUsuarioPermissao");
                });

            modelBuilder.Entity("GrupoUsuarioUsuario", b =>
                {
                    b.Property<int>("GrupoUsuarioListId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("UsuarioListId")
                        .HasColumnType("INTEGER");

                    b.HasKey("GrupoUsuarioListId", "UsuarioListId");

                    b.HasIndex("UsuarioListId");

                    b.ToTable("GrupoUsuarioUsuario");
                });

            modelBuilder.Entity("Models.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Fone")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Cliente");
                });

            modelBuilder.Entity("Models.GrupoUsuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("GrupoUsuario");
                });

            modelBuilder.Entity("Models.Permissao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Descricao")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Permissao");
                });

            modelBuilder.Entity("Models.Produto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<double>("Estoque")
                        .HasColumnType("REAL");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<double>("Preco")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.ToTable("Produto");
                });

            modelBuilder.Entity("Models.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("GrupoUsuarioPermissao", b =>
                {
                    b.HasOne("Models.GrupoUsuario", null)
                        .WithMany()
                        .HasForeignKey("GrupoUsuarioListId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Models.Permissao", null)
                        .WithMany()
                        .HasForeignKey("PermissaoListId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("GrupoUsuarioUsuario", b =>
                {
                    b.HasOne("Models.GrupoUsuario", null)
                        .WithMany()
                        .HasForeignKey("GrupoUsuarioListId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Models.Usuario", null)
                        .WithMany()
                        .HasForeignKey("UsuarioListId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
