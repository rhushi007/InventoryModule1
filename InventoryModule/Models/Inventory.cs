//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace InventoryModule.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    public partial class Inventory
    {
        public int InventoryId { get; set; }
        [DisplayName("Inventory Name")]
        [Required]
        public string InventoryName { get; set; }
        public Nullable<int> Quantity { get; set; }
        public string Description { get; set; }
        [DisplayName("Inventory Image Path")]
        [Required]
        public string InventoryImage { get; set; }
        public Nullable<double> Price { get; set; }
    }
}
