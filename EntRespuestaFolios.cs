using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace ws_Tepic.Models
{
    [DataContract]
    public class EntRespuestaFolios
    {
        [DataMember(Name = "Folio")]
        public string Folio { get; set; }
        //  [DataMember(Name = "Folio Externo")]
        [DataMember(Name = "Respuesta Mensaje")]
        public string RespuestaMensaje { get; set; }
        [DataMember(Name = "Fecha Registro")]
        public DateTime fechaRecepcion { get; set; }
        public string FolioExterno { get; set; }
        [DataMember(Name = "Insumos")]
        public EntInsumos[] Insumos { get; set; }
    }
}