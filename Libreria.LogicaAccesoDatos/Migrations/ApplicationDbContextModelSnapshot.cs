﻿// <auto-generated />
using System;
using System.Collections.Generic;
using Libreria.LogicaAccesoDatos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Libreria.LogicaAccesoDatos.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("GeneroLibro", b =>
                {
                    b.Property<int>("GenerosId")
                        .HasColumnType("int");

                    b.Property<int>("LibroId")
                        .HasColumnType("int");

                    b.HasKey("GenerosId", "LibroId");

                    b.HasIndex("LibroId");

                    b.ToTable("LibroGenero", (string)null);
                });

            modelBuilder.Entity("Libreria.LogicaNegocio.Entidades.Auditoria", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Accion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Entidad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EntidadId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<string>("Observaciones")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Auditorias");
                });

            modelBuilder.Entity("Libreria.LogicaNegocio.Entidades.Autor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("NacionalidadId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("NacionalidadId");

                    b.ToTable("Autores");
                });

            modelBuilder.Entity("Libreria.LogicaNegocio.Entidades.DetalleVenta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Cantidad")
                        .HasColumnType("int");

                    b.Property<int>("LibroId")
                        .HasColumnType("int");

                    b.Property<decimal>("PrecioUnidad")
                        .HasPrecision(18, 4)
                        .HasColumnType("decimal(18,4)");

                    b.Property<int?>("VentaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("LibroId");

                    b.HasIndex("VentaId");

                    b.ToTable("DetalleVentas");
                });

            modelBuilder.Entity("Libreria.LogicaNegocio.Entidades.Genero", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("EdadMinima")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Generos");
                });

            modelBuilder.Entity("Libreria.LogicaNegocio.Entidades.Libro", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AutorId")
                        .HasColumnType("int");

                    b.Property<string>("Portada")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Precio")
                        .HasPrecision(18, 4)
                        .HasColumnType("decimal(18,4)");

                    b.Property<string>("TipoDeLibro")
                        .IsRequired()
                        .HasMaxLength(13)
                        .HasColumnType("nvarchar(13)");

                    b.ComplexProperty<Dictionary<string, object>>("Titulo", "Libreria.LogicaNegocio.Entidades.Libro.Titulo#TituloLibro", b1 =>
                        {
                            b1.IsRequired();

                            b1.Property<string>("Titulo")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("TituloOriginal")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");
                        });

                    b.HasKey("Id");

                    b.HasIndex("AutorId");

                    b.ToTable("Libros");

                    b.HasDiscriminator<string>("TipoDeLibro").HasValue("Libro");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("Libreria.LogicaNegocio.Entidades.Pais", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Codigo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Paises");
                });

            modelBuilder.Entity("Libreria.LogicaNegocio.Entidades.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Cargo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("Estado")
                        .HasColumnType("bit");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Rol")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("Libreria.LogicaNegocio.Entidades.Venta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ClienteId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<int>("VendedorId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.HasIndex("VendedorId");

                    b.ToTable("Ventas");
                });

            modelBuilder.Entity("Libreria.LogicaNegocio.Entidades.Ebook", b =>
                {
                    b.HasBaseType("Libreria.LogicaNegocio.Entidades.Libro");

                    b.Property<string>("Formato")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Size")
                        .HasPrecision(18, 4)
                        .HasColumnType("decimal(18,4)");

                    b.HasDiscriminator().HasValue("Ebook");
                });

            modelBuilder.Entity("Libreria.LogicaNegocio.Entidades.Fisico", b =>
                {
                    b.HasBaseType("Libreria.LogicaNegocio.Entidades.Libro");

                    b.Property<int>("CantidadPaginas")
                        .HasColumnType("int");

                    b.Property<int>("Stock")
                        .HasColumnType("int");

                    b.HasDiscriminator().HasValue("LibroFisico");
                });

            modelBuilder.Entity("GeneroLibro", b =>
                {
                    b.HasOne("Libreria.LogicaNegocio.Entidades.Genero", null)
                        .WithMany()
                        .HasForeignKey("GenerosId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Libreria.LogicaNegocio.Entidades.Libro", null)
                        .WithMany()
                        .HasForeignKey("LibroId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Libreria.LogicaNegocio.Entidades.Autor", b =>
                {
                    b.HasOne("Libreria.LogicaNegocio.Entidades.Pais", "Nacionalidad")
                        .WithMany()
                        .HasForeignKey("NacionalidadId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.OwnsOne("Libreria.LogicaNegocio.VO.Compartidos.NombreCompleto", "NombreCompleto", b1 =>
                        {
                            b1.Property<int>("AutorId")
                                .HasColumnType("int");

                            b1.Property<string>("Apellido")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)")
                                .HasColumnName("Apellido");

                            b1.Property<string>("Nombre")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)")
                                .HasColumnName("Nombre");

                            b1.HasKey("AutorId");

                            b1.ToTable("Autores");

                            b1.WithOwner()
                                .HasForeignKey("AutorId");
                        });

                    b.Navigation("Nacionalidad");

                    b.Navigation("NombreCompleto")
                        .IsRequired();
                });

            modelBuilder.Entity("Libreria.LogicaNegocio.Entidades.DetalleVenta", b =>
                {
                    b.HasOne("Libreria.LogicaNegocio.Entidades.Libro", "Libro")
                        .WithMany()
                        .HasForeignKey("LibroId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Libreria.LogicaNegocio.Entidades.Venta", null)
                        .WithMany("Carrito")
                        .HasForeignKey("VentaId");

                    b.Navigation("Libro");
                });

            modelBuilder.Entity("Libreria.LogicaNegocio.Entidades.Libro", b =>
                {
                    b.HasOne("Libreria.LogicaNegocio.Entidades.Autor", "Autor")
                        .WithMany()
                        .HasForeignKey("AutorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Autor");
                });

            modelBuilder.Entity("Libreria.LogicaNegocio.Entidades.Usuario", b =>
                {
                    b.OwnsOne("Libreria.LogicaNegocio.VO.Compartidos.NombreCompleto", "NombreCompleto", b1 =>
                        {
                            b1.Property<int>("UsuarioId")
                                .HasColumnType("int");

                            b1.Property<string>("Apellido")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)")
                                .HasColumnName("Apellido");

                            b1.Property<string>("Nombre")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)")
                                .HasColumnName("Nombre");

                            b1.HasKey("UsuarioId");

                            b1.ToTable("Usuario");

                            b1.WithOwner()
                                .HasForeignKey("UsuarioId");
                        });

                    b.Navigation("NombreCompleto")
                        .IsRequired();
                });

            modelBuilder.Entity("Libreria.LogicaNegocio.Entidades.Venta", b =>
                {
                    b.HasOne("Libreria.LogicaNegocio.Entidades.Usuario", "Cliente")
                        .WithMany()
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Libreria.LogicaNegocio.Entidades.Usuario", "Vendedor")
                        .WithMany()
                        .HasForeignKey("VendedorId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Cliente");

                    b.Navigation("Vendedor");
                });

            modelBuilder.Entity("Libreria.LogicaNegocio.Entidades.Venta", b =>
                {
                    b.Navigation("Carrito");
                });
#pragma warning restore 612, 618
        }
    }
}
