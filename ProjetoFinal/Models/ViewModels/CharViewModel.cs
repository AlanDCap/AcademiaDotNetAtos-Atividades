namespace AtosProjetoFinal.Models.ViewModels
{
    //viewModel utilizada para criação de personagens, recebe uma lista de ancestralidades,
    //sub-classes e classe, e a model de personagem dos quais o usuário precisa escolher dentre 
    //opções de ancestralidades, sub-classes e classes existentes no banco. 
    public class CharViewModel
    {
        public Character Character { get; set; }
        public List<Ancestry>? Ancestry { get; set; }
        public List<Role> Role { get; set; }
        public List<Class> Class { get; set; }

        public CharViewModel()
        {

        }
        
    }
}
