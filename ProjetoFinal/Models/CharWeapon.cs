using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AtosProjetoFinal.Models
{
    [Table("CharWeapon")]
    public class CharWeapon
    {
        [Key]
        public int charWeaponID { get; set; }
        public virtual Character Character { get; set; }
        public virtual Weapon Weapon { get; set; }
        [Display(Name = "Personagem")]
        public int characterID { get; set; }
        [Display(Name = "Arma")]
        public int weaponID { get; set; }
    }
}
