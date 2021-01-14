using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GlobalGames.Data.Entidades
{
    public class UserLogin 
    {
        public int Id { get; set; }

        [MaxLength(100, ErrorMessage = "Limite de 100 caracteres")]
        [Required]
        [Display(Name = "Nome")]
        public string Name { get; set; }

        [Display(Name = "Image")]
        public string ImageUrl { get; set; }

        public User User { get; set; }
    }
}
