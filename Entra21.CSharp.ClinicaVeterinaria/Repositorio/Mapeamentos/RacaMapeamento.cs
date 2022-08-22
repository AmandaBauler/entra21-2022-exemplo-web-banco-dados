﻿using Entra21.CSharp.ClinicaVeterinaria.Repositorio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Entra21.CSharp.ClinicaVeterinaria.Repositorio.Mapeamentos
{
    //DB First: Criar uma aplicação onde o banco de dados ja existe
    //Code First: Criando um banco de dados apartir de uma aplicação existente
    //Seed: alimentando o banco de dados com registros 
    //Migration: representação do mapeamento que sera aplicado no banco de dados 
    //Mapeamento: representação da entidade em tabelas, colunas, indices...
    internal class RacaMapeamento : IEntityTypeConfiguration<Raca>
    {
        public void Configure(EntityTypeBuilder<Raca> builder)
        {
            builder.ToTable("racas");

            builder.Property(x => x.Id).HasColumnName("id");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Especie)
                .HasColumnType("VARCHAR")
                .HasMaxLength(100)
                .IsRequired()
                .HasColumnName("especie"); //NOT NULL

            builder.Property(x => x.Nome)
                .HasColumnType("VARCHAR")
                .HasMaxLength(38)
                .IsRequired()
                .HasColumnName("nome");
        }
    }
}
