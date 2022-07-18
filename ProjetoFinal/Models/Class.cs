using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AtosProjetoFinal.Models
{
    [Table("Class")]
    public class Class
    {
        [Key]
        public int classID { get; set; }
        [Display(Name = "Classe")]
        public string className { get; set; }
        [Display(Name = "Habilidade nível 1")]
        public string level1_ability { get; set; }
        [Display(Name = "Habilidade nível 2")]
        public string level2_ability { get; set; }
        [Display(Name = "Habilidade nível 3")]
        public string level3_ability { get; set; }
    }
}
