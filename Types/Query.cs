namespace hc_5893.Types;

public class Query
{
    [UseProjection]
    public IQueryable<UsuarioModel> GetUsuarios(AppDbContext context) =>
        context.Set<UsuarioModel>();

    public IQueryable<UsuarioModel> GetUsuarios2(AppDbContext context) =>
        context.Set<UsuarioModel>();
}