namespace AtosProjetoFinal.Models.ViewModels
{
    //viewModel utilizada para relacionar armas, armaduras e itens a personagens, recebe uma lista 
    //de personagens, armas, armaduras e itens, e utiliza as models charWeapon, charArmor, charItem
    //para relacionar as pk e fk dos equipamentos e personagens
    public class EquipmentViewModel
    {
        public CharWeapon? CharWeapon { get; set; }
        public CharArmor? CharArmor { get; set; }
        public CharItem? CharItem { get; set; }

        public List<Character>? Characters { get; set; }
        public List<Weapon>? Weapons{ get; set; }
        public List<Armor>? Armors { get; set; }
        public List<Item>? Items { get; set; }
    }
}
