//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LMS.Data.Entity
{
    #pragma warning disable 1573
    using System;
    using System.Collections.Generic;
    using LighTake.Infrastructure.Seedwork;
    
    public partial class DeliveryDeviation : Entity
    {
        public virtual int DeviationID { get; set; }
        public virtual string VenderName { get; set; }
        public virtual string VenderCode { get; set; }
        public virtual Nullable<int> VenderId { get; set; }
        public virtual Nullable<int> ShippingmethodID { get; set; }
        public virtual string ShippingmethodName { get; set; }
        public virtual Nullable<int> DeviationType { get; set; }
        public virtual Nullable<decimal> DeviationValue { get; set; }
        public virtual Nullable<decimal> DeviationRate { get; set; }
        public virtual System.DateTime CreatedOn { get; set; }
        public virtual string CreatedBy { get; set; }
        public virtual System.DateTime LastUpdatedOn { get; set; }
        public virtual string LastUpdatedBy { get; set; }
    }
}