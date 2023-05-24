using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks; 

namespace BinsaTest.Models
{
    public class Clientes
    {
        [Key]
        public int Id { get; set; }
        [Required,MaxLength(40)]
        [DisplayName("Nombre")]
        public string Nombre { get; set; }
        [MaxLength(40)]
        [DisplayName("Domicilio")]
        public string? Domicilio { get; set; }
        [MaxLength(5)]
        [DisplayName("Código Postal")]
        public string? CodigoPostal { get; set; }
        [MaxLength(40)]
        [DisplayName("Población")]
        public string? Poblacion { get; set; }
    }
}
