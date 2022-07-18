using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AtosProjetoFinal.Models
{
    [Table("Ancestry")]
    public class Ancestry
    {
        [Key]
        public int ancestryID { get; set; }
        [Display(Name = "Ancestralidade")]
        public string ancestryName { get; set; }
        [Display(Name = "Traço 1")]
        public string trait1 { get; set; }
        [Display(Name = "Traço 2")]
        public string trait2 { get; set; }
        [Display(Name = "Traço 3")]
        public string trait3 { get; set; }

    }
}
