using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Teste.Volvo.Gerenciamento.Models;
using Teste.Volvo.Gerenciamento.Services.Interfaces;

namespace Teste.Volvo.Gerenciamento.Controllers
{
    [Route("Api/{controller}")]
    public class TruckController : Controller
    {
        public readonly ITruckService _service;
        public TruckController(ITruckService service)
        {
            _service = service;
        }


        [HttpGet("List")]
        public async Task<ActionResult> List()
        {
            try
            {
                return Ok(await _service.GetTruckList());
            }
            catch
            {
                throw new Exception("Erro adiquirindo lista de caminhões");
            }
        }


        [HttpPost("Edit")]
        public async Task<ActionResult> Edit([FromBody] Truck truck)
        {
            try
            {
                return Ok(await _service.EditTruck(truck));
            }
            catch
            {
                var verbo = truck.Id == Guid.Empty ? "Adicionando" : "Editando" ;
                throw new Exception($"Erro {verbo} Caminhão");
            }
        }


        [HttpPost("Delete")]
        public async Task<ActionResult> Delete([FromBody] Guid Id)
        {
            try
            {
                return Ok(await _service.DeleteTruck(Id));
            }
            catch
            {
                throw new Exception("Erro deletando Caminhão");
            }
        }
    }
}
