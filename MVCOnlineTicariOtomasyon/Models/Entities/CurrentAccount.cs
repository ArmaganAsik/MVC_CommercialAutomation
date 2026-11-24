using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVCOnlineTicariOtomasyon.Models.Entities
{
    public class CurrentAccount
    {
        [Key]
        public int CurrentAccountId { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string CurrentAccountName { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string CurrentAccountSurname { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(15)]
        public string CurrentAccountCity { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(50)]
        public string CurrentAccountMail { get; set; }
        public SalesTransaction SalesTransaction { get; set; }
    }
}