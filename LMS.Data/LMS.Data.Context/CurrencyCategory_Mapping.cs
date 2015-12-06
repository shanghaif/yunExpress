//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LMS.Data.Context
{
    #pragma warning disable 1573
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Common;
    using System.Data.Entity;
    using System.Data.Entity.ModelConfiguration;
    using System.Data.Entity.Infrastructure;
    
    using LMS.Data.Entity;
    
    
    internal partial class CurrencyCategory_Mapping : EntityTypeConfiguration<CurrencyCategory>
    {
        public CurrencyCategory_Mapping()
        {                        
              this.HasKey(t => t.ID);        
              this.ToTable("CurrencyCategories");
              this.Property(t => t.ID).HasColumnName("ID");
              this.Property(t => t.CurrencyCategoryCode).HasColumnName("CurrencyCategoryCode").HasMaxLength(10);
              this.Property(t => t.CurrencyCategoryName).HasColumnName("CurrencyCategoryName").HasMaxLength(50);
              this.Property(t => t.IsDefault).HasColumnName("IsDefault");
              this.Property(t => t.IncomeRate).HasColumnName("IncomeRate");
              this.Property(t => t.SpendingRate).HasColumnName("SpendingRate");
              this.Property(t => t.CreatedOn).HasColumnName("CreatedOn");
              this.Property(t => t.CreatedBy).HasColumnName("CreatedBy").HasMaxLength(50);
              this.Property(t => t.LastUpdatedOn).HasColumnName("LastUpdatedOn");
              this.Property(t => t.LastUpdatedBy).HasColumnName("LastUpdatedBy").HasMaxLength(50);
              this.Property(t => t.Status).HasColumnName("Status");
         }
    }
}