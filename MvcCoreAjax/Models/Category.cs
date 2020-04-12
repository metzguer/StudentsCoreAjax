using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCoreAjax.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Display(Name ="Nombre")]
        [Required(ErrorMessage ="El nombre es un dato requerido")]
        [StringLength(50, MinimumLength =3, ErrorMessage ="El nombre debe tener de 3 a 50 caracteres")]
        public string Name { get; set; }
        [Display(Name = "Descripcion")]
        [StringLength(250, ErrorMessage ="El campo Descripcion es un texto entre  y 250 caracteres")]
        public string Description { get; set; }
        [Display(Name = "Estado")]
        [Required(ErrorMessage ="Asigna un estado de la categoria")]
        public Boolean Estado { get; set; }
    }
}
