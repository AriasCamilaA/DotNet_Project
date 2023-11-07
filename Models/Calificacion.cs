namespace DotNet_Project.Models
{
    public class Calificacion
    {
        public int Id { get; set; }
        public int? EstrellasCalificacíon { get; set; }
        public string ComentarioCalificacion { get; set; }
        public string EmpresaProveedor {  get; set; }
        public int TelefonoProveedor { get; set; }
    }
}
