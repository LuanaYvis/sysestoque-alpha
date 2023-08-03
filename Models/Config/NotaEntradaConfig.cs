using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace sysestoque_alpha.Models.Config {
	internal class NotaEntradaConfig : IEntityTypeConfiguration<NotaEntrada> {
		public void Configure(EntityTypeBuilder<NotaEntrada> builder) {
			
			builder.HasMany(NIn => NIn.Produtos)
				.WithMany(Produto => Produto.NotasEntrada)
				.UsingEntity<ItemEntrada>();
		}
	}
}
