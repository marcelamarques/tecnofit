using System.Data.Entity.ModelConfiguration;
using TesteTecnofit.Domain;

namespace TesteTecnofit.Data.EntityConfig
{
    public class ClienteConfiguration : EntityTypeConfiguration<Cliente>
    {
        public ClienteConfiguration()
        {
            HasKey(c => c.ClienteId);

            Property(p => p.Nome).IsRequired().HasMaxLength(150);

            Property(p => p.Sobrenome).IsRequired().HasMaxLength(150);

            Property(e => e.Email).IsRequired();
        }
    }
}
