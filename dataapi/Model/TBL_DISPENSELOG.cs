using System;
using System.ComponentModel.DataAnnotations;

namespace dataapi.Model
{
    public class TBL_DISPENSELOG
    {
        [Key]
        [Required]
        public Guid DISPENSELOGID { get; set; }
        public Decimal Amount { get; set; }
        public string Unit { get; set; }
        public string Type { get; set; }
        [Required]
        public DateTime CreatedDate { get; set; }
    }
}
