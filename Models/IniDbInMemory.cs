using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace wsFacturas.Models
{
    public static class IniDbInMemory
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var _context = new PersistenceContext(serviceProvider.GetRequiredService<DbContextOptions<PersistenceContext>>()))
            {
                if (_context.facturas.Any())
                    return;

                _context.facturas.Add(
                    new Entities.Factura
                    {
                        IDFACTURA = 1,
                        NUMEROFACTURA = "18032002-000001",
                        FECHA = DateTime.Now,
                        TIPODEPAGO = 1,
                        DOCUMENTOCLIENTE = "80171786",
                        NOMBRECLIENTE = "Jesús Antonio Londoño Muñoz",
                        SUBTOTAL = 120000,
                        DESCUENTO = 0,
                        IVA = 19,
                        TOTALDESCUENTO = 0,
                        TOTALIMPUESTO = 22800,
                        TOTAL = 142800
                    });
                _context.facturas.Add(
                    new Entities.Factura
                    {
                        IDFACTURA = 2,
                        NUMEROFACTURA = "19032002-000001",
                        FECHA = DateTime.Now,
                        TIPODEPAGO = 1,
                        DOCUMENTOCLIENTE = "1123303596",
                        NOMBRECLIENTE = "Andrea Valeria Palacios Enriquez",
                        SUBTOTAL = 60000,
                        DESCUENTO = 0,
                        IVA = 19,
                        TOTALDESCUENTO = 0,
                        TOTALIMPUESTO = 11400,
                        TOTAL = 71400
                    });
                _context.SaveChanges();
            }
        }
    }
}
