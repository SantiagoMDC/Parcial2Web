using Entity;
using System;
namespace Parcial2Web.Models
{
    public class VacunaInputModel
    {
        public string TipoDeDocumentov { get; set; }
        public string Identificacionv { get; set; }
        public string Nombrev { get; set; }
        public DateTime FechaDeNacimientov { get; set; }
        public string InstitucionEducativav { get; set; }
        public string NombreDeAcudientev { get; set; }
        public string NombreVacuna { get; set; }
        public DateTime FechaVacuna { get; set; }
        public int EdadVacuna { get; set; }
    
    }

    public class VacunaViewModel : VacunaInputModel
    {
        public VacunaViewModel( )
        {

        }
        public VacunaViewModel(Vacuna vacuna)
        {
            TipoDeDocumentov = vacuna.TipoDeDocumentov;
            Identificacionv = vacuna.Identificacionv;
            Nombrev = vacuna.Nombrev;
            FechaDeNacimientov = vacuna.FechaDeNacimientov;
            InstitucionEducativav = vacuna.InstitucionEducativav;
            NombreDeAcudientev = vacuna.NombreAcudientev;
            NombreVacuna = vacuna.NombreVacuna;
            FechaVacuna = vacuna.FechaVacuna;
            EdadVacuna = vacuna.EdadVacuna;
        }
    }
}