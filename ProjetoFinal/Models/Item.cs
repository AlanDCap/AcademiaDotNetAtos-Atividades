using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AtosProjetoFinal.Models
{
    [Table("Item")]
    public class Item
    {
        [Key]
        public int itemID { get; set; }
        [Display(Name = "Item")]
        public string itemName { get; set; }
        [Display(Name = "Grupo")]
        public string itemGroup { get; set; }
        [Display(Name = "Peso")]
        public int itemBulk { get; set; }
        [Display(Name = "Descrição")]
        public string itemDescription { get; set; }
    }
}
