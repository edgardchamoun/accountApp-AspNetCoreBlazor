using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace AccountApp.Shared.Models
{
    public class Transaction
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TransactionId { get; set; }
        [Required]
        [RegularExpression(@"^-?\d{0,18}.?\d{0,2}$", ErrorMessage = "Invalid Target Price; Maximum Two Decimal Points.")]
        public decimal TransactionAmount { get; set; }
        [Required]
        [Column(TypeName = "datetime")]
        public DateTime TransactionDate { get; set; } = DateTime.Now;
        [Required]
        public int AccountId { get; set; }
        public Account Account { get; set; }
    }
}
