namespace Gestion.Model
{
    public class Contacto
    {
        public int ContactoId { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; } = String.Empty;
        public string Email { get; set; } = String.Empty;
    }
}
