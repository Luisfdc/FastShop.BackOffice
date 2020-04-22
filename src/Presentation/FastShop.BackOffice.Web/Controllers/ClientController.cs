using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FastShop.BackOffice.Application.Contracts;
using FastShop.BackOffice.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FastShop.BackOffice.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        private readonly IClientApplication _clientApplication;

        public ClientController(IClientApplication clientApplication)
        {
            _clientApplication = clientApplication;
        }


        [HttpGet,Route("{cpf}")]
        public async Task<ActionResult<Client>> GetClient(string cpf)
        {
            return _clientApplication.Get(cpf);
        }

    }
}