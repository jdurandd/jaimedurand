using SistemaKardexInventario.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace SistemaKardexInventario.UI.Controllers
{
    public class ListaVentasController : Controller
    {
        // GET: Categorias
        public ActionResult Index()
        {
            var Listadocategoria = Lista();
            ViewBag.TotalRegistros = Listadocategoria.Count;
            return View(Listadocategoria);
        }

        public List<ListaVentas> Lista()
        {
            using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["SqlConecction"].ToString())) 
            {
                SqlCommand cmd = new SqlCommand("usp_ListarVentas", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                List<ListaVentas> lista = new List<ListaVentas>();
                ListaVentas ent;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleResult);
                while (dr.Read())
                {
                    ent = new ListaVentas();
                    //int IdCategoria_index = dr.GetOrdinal("IdCategoria");
                    ent.nomCliente = dr.GetString(2).Trim();
                    ent.apellClilente = dr.GetString(3).Trim();
                    ent.codArticulo = dr.GetString(4).Trim();
                    ent.desArticulo = dr.GetString(5).Trim();
                    ent.fecVenta = dr.GetDateTime(8);
                    ent.dni = dr.GetString(9);
                    ent.codigoCaja = dr.GetString(10);
                    ent.codigoTicket = dr.GetString(14);
                    ent.numCelular = dr.GetString(12);
                    ent.ImeioSimCard = dr.GetString(11);
                    ent.precio = dr.GetDecimal(13);
                    lista.Add(ent);
                }

                return lista;
                
            }


        }
            
    }
}