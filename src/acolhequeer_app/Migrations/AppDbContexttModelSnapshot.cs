﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using acolhequeer.Models;

#nullable disable

namespace acolhequeer_app.Migrations
{
    [DbContext(typeof(AppDbContextt))]
    partial class AppDbContexttModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("acolhequeer.Models.Veiculo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AnoFabricacao")
                        .HasColumnType("int");

                    b.Property<int>("AnoModelo")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Placa")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Veiculos");
                });

            modelBuilder.Entity("acolhequeer_app.Models.AgendaQuarto", b =>
                {
                    b.Property<int>("reserva_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("reserva_id"));

                    b.Property<string>("check_in")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("check_out")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("data_reserva")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("instituicao_id")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("observacao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("usuario_id")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("reserva_id");

                    b.ToTable("AgendamentoQuarto");
                });

            modelBuilder.Entity("acolhequeer_app.Models.Instituicao", b =>
                {
                    b.Property<int>("instituicao_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("instituicao_id"));

                    b.Property<bool>("adm_validacao")
                        .HasColumnType("bit");

                    b.Property<bool>("bool_atd")
                        .HasColumnType("bit");

                    b.Property<string>("cnpj")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("endereco_bairro")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("endereco_cep")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("endereco_cidade")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("endereco_estado")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("endereco_numero")
                        .HasColumnType("int");

                    b.Property<string>("endereco_rua")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("n_vagas")
                        .HasColumnType("int");

                    b.Property<string>("nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("pix_doacao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("qtd_disponibilidade")
                        .HasColumnType("int");

                    b.Property<string>("senha")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("telefone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("instituicao_id");

                    b.ToTable("Instituicao");
                });

            modelBuilder.Entity("acolhequeer_app.Models.Usuario", b =>
                {
                    b.Property<int>("Usuario_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Usuario_id"));

                    b.Property<bool>("Bool_admin")
                        .HasColumnType("bit");

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Endereco_bairro")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Endereco_cep")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Endereco_cidade")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Endereco_estado")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Endereco_logradouro")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Endereco_numero")
                        .HasColumnType("int");

                    b.Property<int>("Idade")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome_social")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Usuario_id");

                    b.ToTable("Usuarios");
                });
#pragma warning restore 612, 618
        }
    }
}
