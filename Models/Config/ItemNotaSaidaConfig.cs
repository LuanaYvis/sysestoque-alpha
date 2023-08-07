using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace sysestoque_alpha.Models.Config {
	internal class ItemNotaSaidaConfig : IEntityTypeConfiguration<ItemSaida> {
		public void Configure(EntityTypeBuilder<ItemSaida> builder) {
			builder.HasKey(ItemNIn => new { ItemNIn.NotaSaidaId, ItemNIn.ProdutoId });

			builder.HasOne(ItemNIn => ItemNIn.NotaSaida)
					.WithMany(NIn => NIn.ItensSaida)
					.HasForeignKey(ItemNIn => ItemNIn.NotaSaidaId);

			builder.HasOne(ItemNIn => ItemNIn.produto)
					.WithMany(P => P.ItensSaida)
					.HasForeignKey(ItemNIn => ItemNIn.ProdutoId);
		}
	}
}
