using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Pierwszy_projekt_na_serio.Data;
using Pierwszy_projekt_na_serio.Models.Information;
using Pierwszy_projekt_na_serio.Service.Client;

namespace Pierwszy_projekt_na_serio.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        private readonly IClientService _service;

        public ClientController(IClientService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetClients()
        {
            var result = await _service.GetClients();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetClient(int id)
        {
            var result = await _service.GetClient(id);
            return Ok(result);
        }

        [HttpPut]
        public async Task<IActionResult> EditClient(ClientInformation clientInformation)
        {
            await _service.EditClient(clientInformation);
            return Ok("Nastąpiła zmiana w użytkowniku");
        }
       
        [HttpPost]
        public async Task<IActionResult> AddClient(ClientInformation clientInformation)
        {
            await _service.AddClient(clientInformation);
            return Ok("Pomyślnie dodano użykownika");
        }
    }
}