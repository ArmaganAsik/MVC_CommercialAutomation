using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCOnlineTicariOtomasyon.Models.Entities
{
    public class SalesTransaction
    {
        [Key]
        public int SalesTransactionId { get; set; }
        public DateTime TransactionDate { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal TotalPrice { get; set; }
        public ICollection<Product> Products { get; set; }
        public ICollection<CurrentAccount> CurrentAccounts { get; set; }
        public Employee Employee { get; set; }
    }
}