using Aplicacion.Request;
using Aplicacion.Response.Usuarios;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using WebApi.Servicios;

namespace WebApi.Models.Request
{
    public class Token : IToken
    {
        private readonly AppSettings appSettings;
        public Token(IOptions<AppSettings> _appSettings)
        {
            appSettings = _appSettings.Value;
        }


        private Respuesta GetToken(UserRequest usuario)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            Respuesta rpta = new Respuesta();

            var llave = Encoding.ASCII.GetBytes(appSettings.Secreto);
            var tokenDescription = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(
                    new Claim[]
                    {
                        
                        new Claim(ClaimTypes.NameIdentifier, usuario.username)
                    }
                 ),
                Expires = DateTime.UtcNow.AddDays(60),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(llave), SecurityAlgorithms.HmacSha256)
            };
            var token = tokenHandler.CreateToken(tokenDescription);
            rpta.token = tokenHandler.WriteToken(token);
            return rpta;
        }
    }
}
