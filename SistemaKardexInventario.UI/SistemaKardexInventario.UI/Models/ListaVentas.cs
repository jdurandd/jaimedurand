using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SistemaKardexInventario.UI.Models
{
    public class ListaVentas
    {
        //public Int32 IdCategoria { get; set; }
        //public string nombreCategoria { get; set; }
        //public string Descripcion { get; set; }
        //public Byte Imagen { get; set; }

        public string nroDocumento { get; set; }
        public string tipDocumento { get; set; }
        public string nomCliente { get; set; }
        public string apellClilente { get; set; }
        public string codArticulo { get; set; }
        public string desArticulo { get; set; }
        public int cantArticulo { get; set; }
        public decimal TotalVenta { get; set; }
        public DateTime fecVenta { get; set; }
        public string dni { get; set; }
        public string codigoCaja {get;set;}
        public string codigoTicket { get; set; }
        public string numCelular { get; set; }
        public string ImeioSimCard { get; set; }
        public decimal precio { get; set; }

    }
}