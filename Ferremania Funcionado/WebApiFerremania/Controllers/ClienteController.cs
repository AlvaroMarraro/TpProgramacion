using FerremaniaBack.Dominio;
using FerremaniaBack.Servicios;
using FerremaniaBack.Servicios.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiFerremania.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private IClienteServicios service;


        

        // GET api/<ClientesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ClientesController>
        [HttpPost("consultar")]
        public IActionResult GetClientes(List<Cliente> lst)
        {
            if (lst == null || lst.Count == 0)

                return BadRequest("Se requiere una lista de parametros!");

            return Ok(service.getClientes(lst));
        }

        // PUT api/<ClientesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ClientesController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int codCliente)
        {
            if (codCliente == 0)
                return BadRequest("Id es requerido");
            return Ok(service.EliminarCliente(codCliente));
        }


    }
}
