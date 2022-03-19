using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace wsFacturas.Models.Entities
{
    public class Factura
    {
        [Key]
        public int IDFACTURA { get; set; }
        public string NUMEROFACTURA { get; set; }
        public DateTime FECHA { get; set; }
        public int TIPODEPAGO { get; set; }
        public string DOCUMENTOCLIENTE { get; set; }
        public string NOMBRECLIENTE { get; set; }
        public int SUBTOTAL { get; set; }
        public double DESCUENTO { get; set; }
        public int IVA { get; set; }
        public int TOTALDESCUENTO { get; set; }
        public int TOTALIMPUESTO { get; set; }
        public int TOTAL { get; set; }
    }
}
