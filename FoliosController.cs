using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ws_Tepic.Models;

namespace ws_Tepic.Controllers
{
    public class FoliosController : ApiController
    {
        // GET: api/Folios/5
        public EntRespuestaFolios Solicitud(EntBusquedaFolios rEntrada)
        {
            EntRespuesta rReg = new EntRespuesta();
            EntRespuestaFolios resp = new EntRespuestaFolios();
            DatTepic oDat = new DatTepic();
            string sCaracter = "~";            
            resp = Procesa(sCaracter + rEntrada.Folio);
            return resp;
        }

        private EntRespuestaFolios Procesa(string Folio)
        {
            EntRespuestaFolios rRes = new EntRespuestaFolios();
            DatTepic oDat = new DatTepic();
            // Aquí hay que procesar la información y validar lo necesario

            rRes.RespuestaMensaje = "Éxito, Las claves recibidas son las siguientes:";
            rRes.Folio = Folio.Replace("~", "");

            int cantidad = 0;
            string clave = string.Empty;
            string sLote = string.Empty;
            DateTime dCadu = DateTime.Now;
            EntInsumos insumoAdd = new EntInsumos();
            EntInsumos[] ins;

            //Recupero el resultado correspondiente
            List<EntInsumos> oRes = new List<EntInsumos>();

            oRes = oDat.oRes(Folio);
            if (oRes.Count < 1)
            {

                rRes.RespuestaMensaje = "Atención, el folio solicitado no se encuentra registrado, verifique e intente de nuevo.";
            }
            else
            {
                rRes.Folio = oRes.FirstOrDefault().sFolio;
                rRes.fechaRecepcion = oRes.FirstOrDefault().dCad;
                rRes.Insumos = oRes.ToArray();
            }


            return rRes;
        }


    }
}
