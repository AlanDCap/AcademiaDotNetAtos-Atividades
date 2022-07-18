using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AtosProjetoFinal.Models
{
    [Table("Character")]
    public class Character
    {
        [Key]
        public int characterID { get; set; }
        [Display(Name = "Nome")]
        public string characterName { get; set; }
        [Display(Name = "Experiência")]
        public int expPoints { get; set; }
        [Display(Name = "Descrição")]
        public string description { get; set; }
        [Display(Name = "Histórico")]
        public string background { get; set; }

        [Display(Name = "Ancestralidade")]
        public int ancestryID { get; set; }
        [Display(Name = "Sub-classe")]
        public int roleID { get; set; }
        [Display(Name = "Classe")]
        public int classID { get; set; }

        //trecho adicionado para facilitar o acesso a estes modelos na view details na pasta Character
        //a pasta details atua como a ficha principal e agrupa todas as informações associadas à personagem 

        public virtual Ancestry Ancestry { get; set; }
        public virtual Role Role { get; set; }
        public virtual Class Class{ get; set; }
        public virtual CharAttributes CharAttributes { get; set; }
        public virtual List<CharWeapon> CharWeapon { get; set; }
        public virtual List<CharArmor> CharArmor { get; set; }
        public virtual List<CharItem> CharItem{ get; set; }

    }
}
