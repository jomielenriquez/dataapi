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
        [Required]
        public DateTime CreatedDate { get; set; }
    }
}
