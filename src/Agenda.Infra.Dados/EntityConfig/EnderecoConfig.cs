using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;
using Agenda.Dominio.Entidades;

namespace Agenda.Infra.Dados.EntityConfig
{
    public class EnderecoConfig: EntityTypeConfiguration<Endereco>
    {
        public EnderecoConfig()
        {
            HasKey(e => e.EnderecoId);

            Property(e => e.Cep)
                .HasMaxLength(8)
                .IsFixedLength()
                .IsRequired()
                .HasColumnAnnotation("Index", new IndexAnnotation(new IndexAttribute()));

            Property(e => e.Logradouro)
                .HasMaxLength(150)
                .IsRequired();

            Property(e => e.Numero)
                .HasMaxLength(6)
                .IsRequired();

            Property(e => e.Complemento)
                .HasMaxLength(100);

            Property(e => e.Bairro)
                .HasMaxLength(80)
                .IsRequired();

            Property(e => e.Cidade)
                .HasMaxLength(80)
                .IsRequired();

            Property(e => e.Estado)
                .HasMaxLength(2)
                .IsRequired();

            ToTable("Enderecos");

        }
    }
}