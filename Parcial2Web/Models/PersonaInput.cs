using Entity;
using System;
namespace Parcial2Web.Models
{
    public class PersonaInputModel
    {
        public string TipoDeDocumento { get; set; }
        public string Identificacion { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaDeNacimiento { get; set; }
        public string InstitucionEducativa { get; set; }
        public string NombreDeAcudiente { get; set; }
    
    }

    public class PersonaViewModel : PersonaInputModel
    {
        public PersonaViewModel()
        {

        }
        public PersonaViewModel(Persona persona)
        {
            TipoDeDocumento = persona.TipoDeDocumento;
            Identificacion = persona.Identificacion;
            Nombre = persona.Nombre;
            FechaDeNacimiento = persona.FechaDeNacimiento;
            InstitucionEducativa = persona.InstitucionEducativa;
            NombreDeAcudiente = persona.NombreAcudiente;
        }
    }
}