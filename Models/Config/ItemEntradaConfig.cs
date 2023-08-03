using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using sysestoque_alpha.Models;

namespace sysestoque_alpha.Models.Config {
	    public class ItemEntradaConfig : IEntityTypeConfiguration<ItemEntrada> {
		public void Configure(EntityTypeBuilder<ItemEntrada> builder) {
			builder.HasKey(ItemNIn => new { ItemNIn.NotaEntradaId, ItemNIn.ProdutoId });

			builder.HasOne(ItemNIn => ItemNIn.NotaEntrada)
					.WithMany(NIn => NIn.ItemEntrada)
					.HasForeignKey(ItemNIn => ItemNIn.NotaEntradaId);

			builder.HasOne(ItemNIn => ItemNIn.Produto)
					.WithMany(P => P.ItensEntrada)
					.HasForeignKey(ItemNIn => ItemNIn.ProdutoId);
		}
	}
}
