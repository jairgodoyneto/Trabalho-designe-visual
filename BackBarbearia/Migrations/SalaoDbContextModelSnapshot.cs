﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Salao.Data;

#nullable disable

namespace Salao.Migrations
{
    [DbContext(typeof(SalaoDbContext))]
    partial class SalaoDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.11");

            modelBuilder.Entity("HorarioLivre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("AgendaId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Horario")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("AgendaId");

                    b.ToTable("HorarioLivre");
                });

            modelBuilder.Entity("Salao.Models.Agenda", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("BarbeiroId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("BarbeiroId");

                    b.ToTable("Agenda");
                });

            modelBuilder.Entity("Salao.Models.AtendimentoAgendado", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("AgendaId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ClienteId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("Horario")
                        .HasColumnType("TEXT");

                    b.Property<int>("ServicoId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("AgendaId");

                    b.HasIndex("ClienteId");

                    b.HasIndex("ServicoId");

                    b.ToTable("AtendimentoAgendado");
                });

            modelBuilder.Entity("Salao.Models.AtendimentoAvulso", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("ClienteId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ServicoId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.HasIndex("ServicoId");

                    b.ToTable("AtendimentoAvulso");
                });

            modelBuilder.Entity("Salao.Models.Barbeiro", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Unidadeid")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("Unidadeid");

                    b.ToTable("Barbeiro");
                });

            modelBuilder.Entity("Salao.Models.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Cliente");
                });

            modelBuilder.Entity("Salao.Models.Servico", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<float>("Custo")
                        .HasColumnType("REAL");

                    b.Property<string>("Descricao")
                        .HasColumnType("TEXT");

                    b.Property<int>("Duracao")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nome")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Servico");
                });

            modelBuilder.Entity("Salao.Models.UnidadeAtendimento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("Cep")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Endereco")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("UnidadeAtendimento");
                });

            modelBuilder.Entity("HorarioLivre", b =>
                {
                    b.HasOne("Salao.Models.Agenda", null)
                        .WithMany("Horarios")
                        .HasForeignKey("AgendaId");
                });

            modelBuilder.Entity("Salao.Models.Agenda", b =>
                {
                    b.HasOne("Salao.Models.Barbeiro", "Barbeiro")
                        .WithMany()
                        .HasForeignKey("BarbeiroId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Barbeiro");
                });

            modelBuilder.Entity("Salao.Models.AtendimentoAgendado", b =>
                {
                    b.HasOne("Salao.Models.Agenda", null)
                        .WithMany("Atendimentos")
                        .HasForeignKey("AgendaId");

                    b.HasOne("Salao.Models.Cliente", "Cliente")
                        .WithMany()
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Salao.Models.Servico", "Servico")
                        .WithMany()
                        .HasForeignKey("ServicoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");

                    b.Navigation("Servico");
                });

            modelBuilder.Entity("Salao.Models.AtendimentoAvulso", b =>
                {
                    b.HasOne("Salao.Models.Cliente", "Cliente")
                        .WithMany()
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Salao.Models.Servico", "Servico")
                        .WithMany()
                        .HasForeignKey("ServicoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");

                    b.Navigation("Servico");
                });

            modelBuilder.Entity("Salao.Models.Barbeiro", b =>
                {
                    b.HasOne("Salao.Models.UnidadeAtendimento", "Unidade")
                        .WithMany()
                        .HasForeignKey("Unidadeid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Unidade");
                });

            modelBuilder.Entity("Salao.Models.Agenda", b =>
                {
                    b.Navigation("Atendimentos");

                    b.Navigation("Horarios");
                });
#pragma warning restore 612, 618
        }
    }
}
