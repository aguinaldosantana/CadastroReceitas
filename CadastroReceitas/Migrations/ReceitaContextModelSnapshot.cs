// <auto-generated />
using System;
using CadastroReceitas.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CadastroReceitas.Migrations
{
    [DbContext(typeof(ReceitaContext))]
    partial class ReceitaContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.13");

            modelBuilder.Entity("CadastroReceitas.Models.ReceitaModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime?>("Data")
                        .IsRequired()
                        .HasColumnType("datetime");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("varchar(30)");

                    b.Property<double>("Valor")
                        .HasColumnType("double");

                    b.HasKey("Id");

                    b.ToTable("Receitas");
                });
#pragma warning restore 612, 618
        }
    }
}
