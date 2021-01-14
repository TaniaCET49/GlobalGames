using System;
using System.ComponentModel.DataAnnotations;

namespace GlobalGames.Data.Entidades
{
    public class Inscricoes
    {
        public int Id { get; set; }

        [Display(Name = "Nome")]
        public string Name { get; set; }


        [Display(Name = "Morada")]
        public string Address { get; set; }


        [Display(Name = "Data de Nascimento")]
        public DateTime Birthday { get; set; }

        [Display(Name = "Imagem")]
        public string ImageUrl { get; set; }
    }
}
