using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Pierwszy_projekt_na_serio.Data;
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
    }
}