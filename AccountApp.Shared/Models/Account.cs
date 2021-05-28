using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace AccountApp.Shared.Models
{
    public class Account
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AccountId { get; set; }
        [Required]
        [StringLength(100, ErrorMessage = "Length should be less than 100 characters")]
        public string LocalAccountNumber { get; set; }
        [Required]
        [RegularExpression("^[A-Z]{2}[0-9]{2}(?:[ ]?[0-9]{4}){4}(?:[ ]?[0-9]{1,2})?$", ErrorMessage = "Invalid IBAN. Start with 2 letters then 2 digits, then add 4 groups of 4 digits.")]
        public string IBAN { get; set; }
        [Required]
        [StringLength(100, ErrorMessage = "Length should be less than 100 characters")]
        public string BankName { get; set; }
        [Required]
        [StringLength(3, ErrorMessage = "Length should be less than 3 characters")]
        public string Currency { get; set; }
    }
}
