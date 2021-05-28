using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace AccountApp.Shared.Models
{
    public class Balance
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BalanceId { get; set; }
        [Required]
        [Column(TypeName = "datetime")]
        public DateTime BalanceDate { get; set; } = DateTime.Now;
        [Required]
        [RegularExpression(@"^\d+.?\d{0,2}$", ErrorMessage = "Invalid Target Price; Maximum Two Decimal Points.")]
        public decimal BalanceAmount { get; set; }
        [Required]
        public int AccountId { get; set; }
        public Account Account { get; set; }
    }
}
