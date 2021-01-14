using System.ComponentModel.DataAnnotations;


namespace GlobalGames.Data.Entidades
{
    public class Contactos
    {
        public int Id { get; set; }

        [Display(Name = "Nome")]
        public string Name { get; set; }

        [Display(Name = "Apelido")]
        public string LastName { get; set; }

        [Display(Name = "Morada")]
        public string Address { get; set; }

        [Display(Name = "Email")]
        public string Email { get; set; }

        [Display(Name = "Mensagem")]
        public string msg { get; set; }
    }
}
