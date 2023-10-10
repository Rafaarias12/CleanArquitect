using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApi.Servicios;
using Aplicacion.Response.Usuarios;
using Aplicacion.Request;
using WebApi.Models.Request;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.Extensions.Options;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : Controller
    {
        // GET: UserController

        private IUsuarios _userServices;

        private readonly AppSettings appSettings;

        public UserController(IUsuarios userServices, IOptions<AppSettings> _appSettings)
        {
            _userServices = userServices;
            appSettings = _appSettings.Value;
        }

        [HttpPost("login")]
        public IActionResult Autentificar([FromBody] LoginUser model)
        {
            Requests rpta = new Requests();
            UserRequest user = new UserRequest();
            string clave = "";
            
            user = _userServices.login(model);

            if(user != null)
            {
                rpta.mensaje = "Usuario o Contraseña Incorrecta";
                return BadRequest(rpta);
            }
            else
            {
                clave = GetToken(user);
                user.token = clave;
                return Ok(user);
            }
        }

        private string GetToken(UserRequest usuario)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            

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
            return tokenHandler.WriteToken(token);
            //return rpta;
        }

    }
}
