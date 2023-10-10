using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infraestructura;
using Aplicacion.Request;
using Aplicacion.Response.Usuarios;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using Aplicacion.Tools;

namespace Aplicacion.Servicios.Usuarios
{
    public class UsuariosServices
    {
        public UsuariosServices()
        {
            
        }

        public UserRequest login(LoginUser model)
        {
            UserRequest userresponse = new UserRequest();

            using(UsuariosDbContext db = new UsuariosDbContext())
            {
                string spassword = Encript.GetSHA256(model.password);

                var usuario = db.Usuarios.Where(d => d.Usuario == model.usuario &&
                d.Contraseña == spassword).FirstOrDefault();
                if (usuario == null) return null;
                userresponse.username = model.usuario;

            }

            return userresponse;
        }

        


    }
}
