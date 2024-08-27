using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistance
{
    internal class ItemDbContextConfiguration : IEntityTypeConfiguration<Item>
    {
        public void Configure(EntityTypeBuilder<Item> builder)
        {
            builder.HasKey(x => x.Id);
        }
    }
}
