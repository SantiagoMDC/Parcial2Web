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
    public class VacunaController : ControllerBase
    {
        private readonly VacunaService _vacunaService;
        public IConfiguration Configuration { get; }
        public VacunaController(Parcial2WebContext context)
        {
            
            _vacunaService = new VacunaService(context);
        }
	private Vacuna MapearVacuna(VacunaInputModel vacunaInput)
        {
            var vacuna = new Vacuna
            {
                TipoDeDocumentov = vacunaInput.TipoDeDocumentov,
            Identificacionv = vacunaInput.Identificacionv,
            Nombrev = vacunaInput.Nombrev,
            FechaDeNacimientov = vacunaInput.FechaDeNacimientov,
            InstitucionEducativav = vacunaInput.InstitucionEducativav,
            NombreAcudientev = vacunaInput.NombreDeAcudientev,
            NombreVacuna = vacunaInput.NombreVacuna,
            FechaVacuna = vacunaInput.FechaVacuna,
            EdadVacuna = vacunaInput.EdadVacuna
            };
            return vacuna;
        }

       [HttpGet]
        public IEnumerable<VacunaViewModel> Gets()
        {
            var vacunas = _vacunaService.ConsultarTodos().Select(p=>new VacunaViewModel(p));
            return vacunas;
        }

        [HttpPost]
        public ActionResult<VacunaViewModel> Post(VacunaInputModel vacunaInput)
        {
            Vacuna vacuna = MapearVacuna(vacunaInput);
            var response = _vacunaService.Guardar(vacuna);
            if (response.Error) 
            {
                return BadRequest(response.Mensaje);
            }
            return Ok(response.Vacuna);
        }

        

        
    }
}