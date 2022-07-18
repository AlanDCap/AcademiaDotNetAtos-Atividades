using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AtosProjetoFinal.Models
{
    [Table("Armor")]
    public class Armor
    {
        [Key]
        public int armorID { get; set; }
        [Display(Name = "Armadura")]
        public string armorName { get; set; }
        [Display(Name = "Tipo")]
        public string armorGroup { get; set; }
        [Display(Name = "Peso")]
        public int armorBulk { get; set; }
        [Display(Name = "Proteção")]
        public int armorProtectionValue { get; set; }
        [Display(Name = "Descrição")]
        public string armorDescription { get; set; }
    }
}
