using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BuyAndCount.Models
{
    public class Expense
    {
        [Key]

        public int Id { get; set; }
        [DisplayName("Enpense")]
        [Required]
        public string ExpenseName { get; set; }
        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "Amount must be moreThan 0")]
        public int Amount { get; set; }
        

        [DisplayName ("Expense Type")]
        public int ExpenseTypeId { get; set; }

        [ForeignKey("ExpenseTypeId")]
        public virtual ExpenseType ExpenseType { get; set;}
    }


}
