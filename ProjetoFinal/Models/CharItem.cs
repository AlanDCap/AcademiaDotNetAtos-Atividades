using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AtosProjetoFinal.Models
{
    [Table("CharItem")]
    public class CharItem
    {
        [Key]
        public int charItemID { get; set; }

        public virtual Character Character { get; set; }
        public virtual Item Item { get; set; }
        [Display(Name = "Personagem")]
        public int characterID { get; set; }
        [Display(Name = "Item")]
        public int itemID { get; set; }

        public CharItem()
        {

        }
    }
}
