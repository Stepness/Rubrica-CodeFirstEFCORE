using System.ComponentModel.DataAnnotations;

namespace PlayGround_Dependency_Injection.Models
{
    public class Contatto
    {
        [Display(Name = "Id Contatto")]
        public int ContattoID { get; set; }
        [Display(Name = "Nome")]
        public string nome { get; set; } = "";
        [Display(Name = "Cognome")]
        public string cognome { get; set; } = "";
        [Display(Name = "Numero Di Telefono")]
        public string numeroDiTelefono { get; set; } = "";
    }
}