using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace ws_Tepic.Models
{
    [DataContract]
    public class EntBusquedaFolios
    {
        [DataMember(Name = "Folio")]
        public string Folio { get; set; }
    }
}