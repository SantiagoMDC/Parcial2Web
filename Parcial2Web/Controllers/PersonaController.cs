using System;
using System.Collections.Generic;
using System.Linq;
using Logica;
using Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Parcial2Web.Models;
using Datos;

namespace Parcial2Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonaController : ControllerBase
    {
        private readonly PersonaService _personaService;
        public IConfiguration Configuration { get; }
        public PersonaController(Parcial2WebContext context)
        {
            
            _personaService = new PersonaService(context);
        }
	private Persona MapearPersona(PersonaInputModel personaInput)
        {
            var persona = new Persona
            {
                TipoDeDocumento = personaInput.TipoDeDocumento,
            Identificacion = personaInput.Identificacion,
            Nombre = personaInput.Nombre,
            FechaDeNacimiento = personaInput.FechaDeNacimiento,
            InstitucionEducativa = personaInput.InstitucionEducativa,
            NombreAcudiente = personaInput.NombreDeAcudiente
            };
            return persona;
        }

       [HttpGet]
        public IEnumerable<PersonaViewModel> Gets()
        {
            var personas = _personaService.ConsultarTodos().Select(p=> new PersonaViewModel(p));
            return personas;
        }

        [HttpPost]
        public ActionResult<PersonaViewModel> Post(PersonaInputModel personaInput)
        {
            Persona persona = MapearPersona(personaInput);
            var response = _personaService.Guardar(persona);
            if (response.Error) 
            {
                return BadRequest(response.Mensaje);
            }
            return Ok(response.Persona);
        }

        

        
    }
}