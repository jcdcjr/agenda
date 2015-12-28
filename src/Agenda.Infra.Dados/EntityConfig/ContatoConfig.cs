using System.Data.Entity.ModelConfiguration;
using Agenda.Dominio.Entidades;

namespace Agenda.Infra.Dados.EntityConfig
{
    public class ContatoConfig: EntityTypeConfiguration<Contato>
    {
        public ContatoConfig()
        {
            HasKey(c => c.ContatoId);

            Property(c => c.Nome)
                .HasMaxLength(50)
                .IsRequired();

            Property(c => c.Sobrenome)
                .HasMaxLength(100)
                .IsRequired();

            Property(c => c.Ativo)
                .IsRequired();

            Property(c => c.DataCadastro)
                .IsRequired();

            Property(c => c.DataNascimento)
                .IsRequired();

            Property(c => c.Sexo)
                .IsRequired();

            HasMany(c => c.Enderecos)
                .WithMany()
                .Map(ce =>
                {
                    ce.MapLeftKey("ContatoId");
                    ce.MapRightKey("EnderecoId");
                    ce.ToTable("ContatoEndereco");
                });

            ToTable("Contatos");
        }
    }
}