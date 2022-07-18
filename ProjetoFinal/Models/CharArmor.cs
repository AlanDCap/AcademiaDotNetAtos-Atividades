using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AtosProjetoFinal.Models
{
    [Table("CharArmor")]
    public class CharArmor
    {
        [Key]
        public int charArmorID { get; set; }
        public virtual Character Character { get; set; }
        public virtual Armor Armor { get; set; }

        
        [Display(Name = "Personagem")]
        public int characterID { get; set; }
        [Display(Name = "Armadura")]
        public int armorID { get; set; }

        public CharArmor()
        {

        }
    }
}
