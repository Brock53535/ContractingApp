using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ContractingApp.Models
{
    public class Provider
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int ProviderId { get; set; }

        public int ContractId { get; set; }

        [Required]
        [Display(Name = "Provider Name")]
        [StringLength(50)]
        public string ProviderName { get; set; }

        [Required]
        [StringLength(2)]
        [StateArray(ErrorMessage = "Invalid state")]
        public string State { get; set; }

        [Required]
        [StringLength(50)]
        public string Location { get; set; }

        public string Type { get; set; }

        //public Contract Contract { get; set; }

        //public ICollection<Contract> Contracts { get; set; }
    }
}
