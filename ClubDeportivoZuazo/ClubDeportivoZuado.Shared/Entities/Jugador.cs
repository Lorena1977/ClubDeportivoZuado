using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubDeportivoZuado.Shared.Entities
{
    public class Jugador
    {
        public int Id { get; set; }

        [Display(Name = "Nombre")]
        [MaxLength(100, ErrorMessage = "El campo {0} no puede tener más de {1} caracteres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string Name { get; set; } = null!;

        [Display(Name = "Apellidos")]
        [MaxLength(150, ErrorMessage = "El campo {0} no puede tener más de {1} caracteres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string Apellidos { get; set; } = null!;

        [Display(Name = "DNI")]
        [MaxLength(9, ErrorMessage = "El DNI no puede tener más de {1} caracteres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string DNI { get; set; } = null!;

        [Display(Name = "Año de nacimiento")]
        [Range(1900, 2026, ErrorMessage = "El año de nacimiento debe estar entre {1} y {2}.")]
       
        public int AñoNacimiento { get; set; }

        [Display(Name = "Teléfono")]
        [MaxLength(20, ErrorMessage = "El teléfono no puede tener más de {1} caracteres.")]
        public string? Telefono { get; set; }

        [Display(Name = "Correo electrónico")]
        [MaxLength(150, ErrorMessage = "El correo no puede tener más de {1} caracteres.")]
        [EmailAddress(ErrorMessage = "Introduce un correo electrónico válido.")]
        public string? Mail { get; set; }

        [Display(Name = "Puesto")]
        [MaxLength(50, ErrorMessage = "El puesto no puede tener más de {1} caracteres.")]
        public string? Puesto { get; set; }
    }

}
