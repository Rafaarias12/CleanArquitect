using Aplicacion.Request;
using Aplicacion.Response.Usuarios;
using Aplicacion.Servicios.Usuarios;

namespace WebApi.Servicios
{
    public interface IUsuarios
    {
        public UserRequest login(LoginUser model);
    }
}
