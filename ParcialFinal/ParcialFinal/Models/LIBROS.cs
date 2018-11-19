using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ParcialFinal.Models
{
    public class LIBROS
    {
       [Key] public  int ID_Libro { get; set; }
        [Required]
        [StringLength(255)]
        public string Titulo_Libro { get; set; }
        public string Autor_Libro { get; set; }
        public int ISBN_Libro { get; set; }
      
    }
}