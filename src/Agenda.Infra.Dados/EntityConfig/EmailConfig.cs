using System.Data.Entity.ModelConfiguration;
using Agenda.Dominio.Entidades;

namespace Agenda.Infra.Dados.EntityConfig
{
    public class EmailConfig: EntityTypeConfiguration<Email>
    {
        public EmailConfig()
        {
            HasKey(e => e.EmailId);

            Property(e => e.TipoEmail)
                .IsRequired();

            Property(e => e.Mail)
                .HasMaxLength(80)
                .IsRequired();

            HasRequired(e => e.Contato)
                .WithMany(c => c.Emails)
                .HasForeignKey(e => e.ContatoId);

            ToTable("Emails");
        }
    }
}