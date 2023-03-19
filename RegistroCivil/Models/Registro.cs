namespace RegistroCivil.Models
{
    public class Registro
    {
        public int RegistroID { get; set; }
        public string NumeroIdentificacion { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public char Sexo { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public bool Monoparental { get; set; }
    }
}
