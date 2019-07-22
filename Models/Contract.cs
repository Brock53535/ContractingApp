using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ContractingApp.Models
{
    public class Contract
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        [Required(ErrorMessage = "Id is required")]
        public int ContractId { get; set; }

        [Required(ErrorMessage = "Id is required")]
        public int ProviderId { get; set; }

        [Required(ErrorMessage = "Contract Name is required")]
        public string ContractName { get; set; }

        [Required(ErrorMessage = "Date is required")]
        public DateTime EffectiveDate {get;set;}

        [Required(ErrorMessage = "Date is required")]
        public DateTime TerminationDate { get; set; }

        //public Provider Provider { get; set; }

        //public ICollection<Provider> Providers { get; set; }
    }
}
