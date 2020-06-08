using System.ComponentModel.DataAnnotations;

namespace PlayGround_Dependency_Injection.Models
{
    public class Contatto
    {
        public int ContattoID { get; set; }
        public string nome { get; set; } = "";
        public string cognome { get; set; } = "";
        public string numeroDiTelefono { get; set; } = "";
    }
}