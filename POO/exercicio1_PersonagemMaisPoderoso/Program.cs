using exercicio1_PersonagemMaisPoderoso;

List<Personagem> listaPersonagens = new List<Personagem>();

listaPersonagens.Add(new Personagem("Legolas", 700));
listaPersonagens.Add(new Personagem("Gandalf", 1000));
listaPersonagens.Add(new Personagem("Frodo", 200));
listaPersonagens.Add(new Personagem("Saruman", 2000));

Personagem.mostrarMaisPoderoso(listaPersonagens);

Console.WriteLine(Personagem.pegarMaisPoderoso(listaPersonagens));
