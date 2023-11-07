using System.ComponentModel.DataAnnotations;

namespace DotNet_Project.Models
{
    public class Usuario
    {
        [Key]
        public int NoDocumento { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int Celular { get; set; }
        public int Nombre { get; set; }
        public int Apellido { get; set; }
        public Rol Rol { get; set; }
    }
}
