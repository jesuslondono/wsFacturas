using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using wsFacturas.Models;
using wsFacturas.Models.Entities;

namespace wsFacturas.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class FacturaController : Controller
    {
        private readonly ILogger<FacturaController> _logger;
        private readonly PersistenceContext _context;
        FacturaModel model;

        public FacturaController(ILogger<FacturaController> logger, PersistenceContext context)
        {
            _logger = logger;
            _context = context;
            model = new FacturaModel(_context);
        }

        [HttpGet()]
        public JsonResult buscarFacturas()
        {
            var response = model.buscarFacturas();
            Response.StatusCode = 200;
            return new JsonResult(response);
        }

        [HttpPost]
        public void crearFactura([FromBody] Factura factura)
        {
            var response = model.crearFactura(factura);
            if (response > 0)
                Response.StatusCode = 200;
            else
                Response.StatusCode = 400;
        }

    }
}
