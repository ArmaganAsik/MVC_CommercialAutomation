using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVCOnlineTicariOtomasyon.Models.Entities
{
    public class Invoice
    {
        [Key]
        public int InvoiceId { get; set; }

        [Column(TypeName = "Char")]
        [StringLength(1)]
        public string InvoiceSerialNumber { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(6)]
        public string InvoiceSequenceNumber { get; set; }
        public DateTime InvoiceDate { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(60)]
        public string TaxOffice { get; set; }
        public DateTime InvoiceTime { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string Recipient { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string Sender { get; set; }
        public ICollection<InvoiceItem> InvoiceItems { get; set; }
    }
}