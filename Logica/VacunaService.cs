using System;
using Datos;
using Entity;
using System.Collections.Generic;
using System.Linq;

namespace Logica
{
    public class VacunaService
    {
        private readonly Parcial2WebContext _context;
        

        public VacunaService(Parcial2WebContext context)
        {
            _context = context;
        }

        public class GuardarVacunaResponse
        {
            public GuardarVacunaResponse(Vacuna vacuna)
            {
                Error = false;
                Vacuna = vacuna;
            }

            public GuardarVacunaResponse(string mensaje)
            {
                Error = true;
                Mensaje = mensaje;
            }

            public bool Error { get; set; }
            public string Mensaje { get; set; }
            public Vacuna Vacuna { get; set; }
        }

        public GuardarVacunaResponse Guardar(Vacuna vacuna)
        {
            try
            {
                _context.vacunas.Add(vacuna);
                
                _context.SaveChanges();
                return new GuardarVacunaResponse(vacuna);
               
            }
            catch (Exception e)
            {
                return new GuardarVacunaResponse($"Error de la Aplicacion: {e.Message}");
            }
            
        }

        public List<Vacuna> ConsultarTodos()
        {
            
            List<Vacuna> vacunas = _context.vacunas.ToList();
           
            return vacunas;
        }

    }
}