using Livraria.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Livraria.Infra.Data.Mappings
{
    public class LivroMapping : IEntityTypeConfiguration<Livro>
    {
        public void Configure(EntityTypeBuilder<Livro> builder)
        {

            builder.ToTable("Livro");
            builder.HasKey(c => c.LivroId);

            builder.Property(b => b.Genero)
            .HasColumnName("Genero")
            .HasColumnType("varchar(MAX)");

            builder.Property(b => b.Publicacao)
            .HasColumnName("Publicacao")
            .HasColumnType("date");

            builder.Property(b => b.Paginas)
            .HasColumnName("Paginas")
            .HasColumnType("int");


            builder.Property(b => b.Titulo)
            .HasColumnName("Titulo")
            .HasColumnType("varchar(MAX)");

            builder.Property(b => b.Autor)
            .HasColumnName("Autor")
            .HasColumnType("varchar(MAX)");

            builder.Property(b => b.Editora)
            .HasColumnName("Editora")
            .HasColumnType("varchar(MAX)");

            builder.Property(b => b.Descricao)
            .HasColumnName("Descricao")
            .HasColumnType("varchar(MAX)");


            builder.Ignore(b => b.ListaErros);
            builder.Ignore(b => b.Valido);


        }
    }
}
