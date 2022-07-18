using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AtosProjetoFinal.Models
{
    [Table("CharAttibutes")]
    public class CharAttributes
    {
        [Key]
        public int charAttributesID { get; set; }
        [Display(Name = "Físico")]
        public int physique { get; set; }
        [Display(Name = "Destreza")]
        public int dexterity { get; set; }
        [Display(Name = "Inteligência")]
        public int intelligence { get; set; }
        [Display(Name = "Percepção")]
        public int perception { get; set; }
        [Display(Name = "Carisma")]
        public int charisma { get; set; }
        [Display(Name = "Convicção")]
        public int conviction { get; set; }
        [Display(Name = "Evasão")]
        public int evasion { get; set; }
        [Display(Name = "Bloqueio")]
        public int block { get; set; }
        [Display(Name = "Def. Mág.")]
        public int magic_def { get; set; }
        [Display(Name = "Estamina")]
        public int stamina { get; set; }
        [Display(Name = "Espírito")]
        public int spirit { get; set; }
        [Display(Name = "Reputação")]
        public int reputation { get; set; }
        
        public virtual Character Character { get; set; }

        [Display(Name = "Personagem")]
        public int characterID { get; set; }

        public CharAttributes()
        {

        }
        /// <summary>
        /// Construtor utilizado para criar a relação entre personagem e valores de 
        /// atributo, os valores de atributos secundários são derivados dos valores primários. 
        /// Os valores de id precisam ser passados adiante para que não gere 
        /// conflito de foreign key no momento de registrar no banco.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="physique"></param>
        /// <param name="dexterity"></param>
        /// <param name="intelligence"></param>
        /// <param name="perception"></param>
        /// <param name="charisma"></param>
        /// <param name="conviction"></param>
        public CharAttributes(int id, int physique, int dexterity, int intelligence, int perception, int charisma, int conviction)
        {
            this.characterID = id;
            this.physique = physique;
            this.dexterity = dexterity;
            this.intelligence = intelligence;
            this.perception = perception;
            this.charisma = charisma;
            this.conviction = conviction;
            this.evasion = dexterity + perception;
            this.block = physique + conviction;
            this.magic_def = intelligence + charisma;
            this.stamina = physique + dexterity;
            this.spirit = intelligence + perception;
            this.reputation = charisma + conviction;
        }
        /// <summary>
        /// Construtor utilizado para alterar valores de atributo de uma determinada personagem, 
        /// os valores de atributos secundários são recalculados a partir dos novos valores primários. 
        /// Novamente as id de character e charAttribute precisam ser passadas para evitar conflito de 
        /// foreign key no momento de registrar as alterações
        /// </summary>
        /// <param name="charAttId"></param>
        /// <param name="id"></param>
        /// <param name="physique"></param>
        /// <param name="dexterity"></param>
        /// <param name="intelligence"></param>
        /// <param name="perception"></param>
        /// <param name="charisma"></param>
        /// <param name="conviction"></param>
        public CharAttributes(int charAttId, int id, int physique, int dexterity, int intelligence, int perception, int charisma, int conviction)
        {
            this.charAttributesID = charAttId;
            this.characterID = id;
            this.physique = physique;
            this.dexterity = dexterity;
            this.intelligence = intelligence;
            this.perception = perception;
            this.charisma = charisma;
            this.conviction = conviction;
            this.evasion = dexterity + perception;
            this.block = physique + conviction;
            this.magic_def = intelligence + charisma;
            this.stamina = physique + dexterity;
            this.spirit = intelligence + perception;
            this.reputation = charisma + conviction;
        }
    }
}
