//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Emlak.Entities
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;

    [DataContract]
    public partial class Daire
    {
        [DataMember]
        public int DaireId { get; set; }
        [DataMember]
        public string DaireAdı { get; set; }
        [DataMember]
        public Nullable<int> DaireSayısı { get; set; }
    }
}
