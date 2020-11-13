using System;
using System.ComponentModel.DataAnnotations;

namespace Entity
{
    public class Persona
    {
        public string TipoDeDocumento { get; set; }
        
        [Key]
        public string Identificacion {get;set;}
        public string Nombre {get;set;}
        public DateTime FechaDeNacimiento {get;set;}
        public string InstitucionEducativa {get;set;}
        public string NombreAcudiente {get;set;}
    }
}
