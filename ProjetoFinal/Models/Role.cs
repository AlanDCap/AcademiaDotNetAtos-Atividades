using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AtosProjetoFinal.Models
{
    [Table("Role")]
    public class Role
    {
        [Key]
        public int roleID { get; set; }
        [Display(Name = "Sub-Classe")]
        public string roleName { get; set; }
        [Display(Name = "Traço 1")]
        public string trait1 { get; set; }
        [Display(Name = "Traço 2")]
        public string trait2 { get; set; }
        [Display(Name = "Traço 3")]
        public string trait3 { get; set; }
    }
}
