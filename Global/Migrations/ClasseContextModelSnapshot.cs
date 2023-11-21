﻿// <auto-generated />
using System;
using Global.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Global.Migrations
{
    [DbContext(typeof(ClasseContext))]
    partial class ClasseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Global.Models.AtualizacaoSaudePub", b =>
                {
                    b.Property<int>("AtualizacaoSaudePubId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AtualizacaoSaudePubId"));

                    b.Property<DateTime>("DataInfoSaude")
                        .HasColumnType("datetime2");

                    b.Property<string>("Descricao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Titulo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UsuarioId")
                        .HasColumnType("int");

                    b.HasKey("AtualizacaoSaudePubId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("AtualizacaoSaudePubs");
                });

            modelBuilder.Entity("Global.Models.DadosSuplementaresUsr", b =>
                {
                    b.Property<int>("DadosSuplementaresUsrId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DadosSuplementaresUsrId"));

                    b.Property<decimal>("Altura")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Idade")
                        .HasColumnType("int");

                    b.Property<decimal>("Peso")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Sexo")
                        .HasColumnType("int");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("int");

                    b.HasKey("DadosSuplementaresUsrId");

                    b.HasIndex("UsuarioId")
                        .IsUnique();

                    b.ToTable("TB_DADOS_SUPLE_USR");
                });

            modelBuilder.Entity("Global.Models.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<decimal>("Altura")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("AtSaudePubId")
                        .HasColumnType("int");

                    b.Property<string>("HabitosSaude")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Idade")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Peso")
                        .HasColumnType("decimal(18,2)");

                    b.Property<bool>("PraticaEsporte")
                        .HasColumnType("bit");

                    b.Property<decimal>("TempoSono")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("AtSaudePubId");

                    b.ToTable("TB_USUARIO");
                });

            modelBuilder.Entity("Global.Models.UsuarioAtualizacaoSaudePub", b =>
                {
                    b.Property<int>("AtSaudePubId")
                        .HasColumnType("int");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("int");

                    b.Property<int?>("AtualizacaoSaudePubId")
                        .HasColumnType("int");

                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<int?>("UsuarioId1")
                        .HasColumnType("int");

                    b.HasKey("AtSaudePubId", "UsuarioId");

                    b.HasIndex("AtualizacaoSaudePubId");

                    b.HasIndex("UsuarioId");

                    b.HasIndex("UsuarioId1");

                    b.ToTable("TB_Usuario_Atualizacao_Saude_Pub");
                });

            modelBuilder.Entity("Global.Models.AtualizacaoSaudePub", b =>
                {
                    b.HasOne("Global.Models.Usuario", null)
                        .WithMany("ListaAtualizacaoPub")
                        .HasForeignKey("UsuarioId");
                });

            modelBuilder.Entity("Global.Models.DadosSuplementaresUsr", b =>
                {
                    b.HasOne("Global.Models.Usuario", "Usuario")
                        .WithOne("DadosSuplementares")
                        .HasForeignKey("Global.Models.DadosSuplementaresUsr", "UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("Global.Models.Usuario", b =>
                {
                    b.HasOne("Global.Models.AtualizacaoSaudePub", "AtSaudePub")
                        .WithMany()
                        .HasForeignKey("AtSaudePubId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AtSaudePub");
                });

            modelBuilder.Entity("Global.Models.UsuarioAtualizacaoSaudePub", b =>
                {
                    b.HasOne("Global.Models.AtualizacaoSaudePub", "AtualizacaoObj")
                        .WithMany("ListaUsuarioAtualizacaoSaudePub")
                        .HasForeignKey("AtSaudePubId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Global.Models.AtualizacaoSaudePub", null)
                        .WithMany("ListaAtualizacao")
                        .HasForeignKey("AtualizacaoSaudePubId");

                    b.HasOne("Global.Models.Usuario", "UsuarioObj")
                        .WithMany("ListaUsuarioAtualizacaoSaudePub")
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Global.Models.Usuario", null)
                        .WithMany("ListaUsuarioAtPub")
                        .HasForeignKey("UsuarioId1");

                    b.Navigation("AtualizacaoObj");

                    b.Navigation("UsuarioObj");
                });

            modelBuilder.Entity("Global.Models.AtualizacaoSaudePub", b =>
                {
                    b.Navigation("ListaAtualizacao");

                    b.Navigation("ListaUsuarioAtualizacaoSaudePub");
                });

            modelBuilder.Entity("Global.Models.Usuario", b =>
                {
                    b.Navigation("DadosSuplementares");

                    b.Navigation("ListaAtualizacaoPub");

                    b.Navigation("ListaUsuarioAtPub");

                    b.Navigation("ListaUsuarioAtualizacaoSaudePub");
                });
#pragma warning restore 612, 618
        }
    }
}
