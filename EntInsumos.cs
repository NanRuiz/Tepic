using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace ws_Tepic.Models
{
    [DataContract]
    public class EntInsumos
    {
        [DataMember(Name = "Cantidad")]
        public int Cantidad { get; set; }
        [DataMember(Name = "Claveinsumo")]
        public string Clave { get; set; }
      // [DataMember(Name = "Lote")]
        public string sLote { get; set; }
      //  [DataMember(Name = "Codigo Barras")]
        public string sBarras { get; set; }
        //[DataMember(Name = "Caducidad")]
        public DateTime dCad { get; set; }
        public string sFolioExt { get; set; }
        public string sFolio { get; set; }
    }
}