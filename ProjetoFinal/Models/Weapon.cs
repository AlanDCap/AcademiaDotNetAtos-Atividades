using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AtosProjetoFinal.Models
{
    [Table("Weapon")]
    public class Weapon
    {
        [Key]
        public int weaponID { get; set; }
        [Display(Name = "Arma")]
        public string weaponName { get; set; }
        [Display(Name = "Grupo")]
        public string weaponGroup { get; set; }
        [Display(Name = "Tipo de Dano")]
        public string weapongDmgType { get; set; }
        [Display(Name = "Alcance")]
        public string weaponRange { get; set; }
        [Display(Name = "Descrição")]
        public string weaponDescription { get; set; }
    }
}
