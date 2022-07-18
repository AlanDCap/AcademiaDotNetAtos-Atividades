namespace AtosProjetoFinal.Models.ViewModels
{
    //viewModel utilizada para relacionar atributos e personagens,
    //recebe uma lista de personagens, dos quais o usuário pode escolher um
    //e a model de atributos
    public class AttributesViewModel
    {
        public CharAttributes CharAttributes { get; set; }
        public List<Character>? Characters { get; set; }
        
        public AttributesViewModel()
        {

        }
    }
}
