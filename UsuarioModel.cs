using System.Text.Json;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace hc_5893;

public class UsuarioModel
{
    public string Codigo { get; set; } = Guid.NewGuid().ToString();
    public JsonDocument? Data { get; set; }
}

public class UsuarioModelConfig : IEntityTypeConfiguration<UsuarioModel>
{
    public void Configure(EntityTypeBuilder<UsuarioModel> builder)
    {
        builder.ToTable("usuario");

        builder.HasKey(x => x.Codigo);

        builder.Property(x => x.Codigo)
            .HasColumnName("usua_cd_usuario");

        builder.Property(x => x.Data)
            .HasColumnName("usua_json_data");
    }
}
