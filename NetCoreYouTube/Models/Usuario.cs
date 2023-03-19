namespace NetCoreYouTube.Models
{
    public class Usuario
    {
        public string idUsuario { get; set; }
        public string usuario { get; set; }
        public string password { get; set; }
        public string rol { get; set; }


        public static List<Usuario> DB()
        {
            var list = new List<Usuario>()
            {
                new Usuario
                {
                    idUsuario = "1",
                    usuario = "Manuel",
                    password = "12345",
                    rol = "empleado",
                },
                new Usuario
                {
                    idUsuario = "2",
                    usuario = "Suky",
                    password = "12345",
                    rol = "administrador",
                },
                new Usuario
                {
                    idUsuario = "3",
                    usuario = "Poncho",
                    password = "12345",
                    rol = "asesor",
                }
            };
            return list;
        }
    }
}
