﻿// <auto-generated />
using Infraestructura;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Infraestructura.Migrations.Productos
{
    [DbContext(typeof(ProductosDbContext))]
    partial class ProductosDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Dominio.Entidades.Productos.Productos", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasColumnType("varchar(45)");

                    b.Property<int>("tipoId")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("tipoId");

                    b.ToTable("Productos");
                });

            modelBuilder.Entity("Dominio.Entidades.Productos.Tipo", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasColumnType("varchar(45)");

                    b.HasKey("id");

                    b.ToTable("Tipo");
                });

            modelBuilder.Entity("Dominio.Entidades.Productos.Productos", b =>
                {
                    b.HasOne("Dominio.Entidades.Productos.Tipo", "Tipo")
                        .WithMany("Productos")
                        .HasForeignKey("tipoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Tipo");
                });

            modelBuilder.Entity("Dominio.Entidades.Productos.Tipo", b =>
                {
                    b.Navigation("Productos");
                });
#pragma warning restore 612, 618
        }
    }
}
