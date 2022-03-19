using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using wsFacturas.Models.Entities;

namespace wsFacturas.Models
{
    public class FacturaModel
    {
        private readonly PersistenceContext _context;

        public FacturaModel(PersistenceContext context)
        {
            _context = context;
        }

        public List<Factura> buscarFacturas()
        {
            return _context.facturas.ToList();
        }

        internal int crearFactura(Factura factura)
        {
            _context.facturas.Add(factura);
            return _context.SaveChanges();
        }
    }
}
