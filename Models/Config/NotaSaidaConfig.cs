using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using sysestoque_alpha.Models;

namespace sysestoque_alpha.Models.Config {
	public class NotaSaidaConfig : IEntityTypeConfiguration<NotaSaida> {
		public void Configure(EntityTypeBuilder<NotaSaida> builder) {

			builder.HasMany(NOut => NOut.produtos)
				.WithMany(Produto => Produto.NotaSaida)
				.UsingEntity<ItemSaida>();
		}
	}
}
