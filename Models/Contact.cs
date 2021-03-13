using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AmarinAssignmenmentMVC.Models
{
    public class Contact
    {
        [Key]
        public int ContactID { get; set; }
        public int Phone { get; set; }
        public int CustomerID { get; set; }
        [ForeignKey("CustomerID")]
        public Customer Customer { get; set; }
        public int MessageID { get; set; }
        [ForeignKey("MessageID")]
        public Message Message { get; set; }
    }
}
