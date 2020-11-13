using System;
using System.ComponentModel.DataAnnotations;

namespace Entity
{
    public class Vacuna
    {
        public string TipoDeDocumentov { get; set; }
        
        [Key]
        public string Identificacionv {get;set;}
        public string Nombrev {get;set;}
        public DateTime FechaDeNacimientov {get;set;}
        public string InstitucionEducativav {get;set;}
        public string NombreAcudientev {get;set;}

        public string NombreVacuna { get; set; }
        public DateTime FechaVacuna { get; set; }
        public int EdadVacuna { get; set; }

        public void CalcularEdadVacuna(){

            EdadVacuna = FechaVacuna.Year-FechaDeNacimientov.Year;
        }
    }
}
