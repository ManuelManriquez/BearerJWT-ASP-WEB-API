using System.Security.Claims;

namespace NetCoreYouTube.Models
{
    public class Jwt
    {
        public string key { get; set; }
        public string Issuer { get; set; }
        public string Audience { get; set; }
        public string Subject { get; set; }


        public static dynamic validarToken(ClaimsIdentity identity)
        {
            try
            {
                if (identity.Claims.Count() == 0)
                {
                    return new
                    {
                        status = "success",
                        message = "Token is not valid!"
                    };
                }

                var id = identity.Claims.FirstOrDefault(x => x.Type == "id").Value;
                //var id = identity.Claims.FirstOrDefault(x => x.Type == "id").Value;

                Usuario usuario = Usuario.DB().FirstOrDefault(x => x.idUsuario == id);

                return new
                {
                    status = "success",
                    data = new { usuario = usuario },
                };

            }
            catch (Exception e)
            {

                return new
                {
                    status = "error",
                    message = "Catch" + e.Message
                };
            }
        }
    }
}
