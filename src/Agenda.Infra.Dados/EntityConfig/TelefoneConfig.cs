using System.Data.Entity.ModelConfiguration;
using Agenda.Dominio.Entidades;

namespace Agenda.Infra.Dados.EntityConfig
{
    public class TelefoneConfig: EntityTypeConfiguration<Telefone>
    {
        public TelefoneConfig()
        {
            HasKey(t => t.TelefoneId);

            Property(t => t.TipoTelefone)
                .IsRequired();

            Property(t => t.Fone)
                .HasMaxLength(16)
                .IsRequired();

            Property(t => t.Ramal)
                .HasMaxLength(4);

            HasRequired(t => t.Contato)
                .WithMany(c => c.Telefones)
                .HasForeignKey(t => t.ContatoId);

            ToTable("Telefones");
        }
    }
}