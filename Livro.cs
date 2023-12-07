// Definindo a classe Livro que herda de ItemBiblioteca
class Livro : ItemBiblioteca
{
    // Atributo adicional para armazenar o autor do livro
    public string Autor;

    // Construtor da classe Livro que chama o construtor da classe base (ItemBiblioteca)
    public Livro(int id, string Titulo, string autor) : base(id, Titulo)
    {
        // Inicializando o atributo Autor com o valor fornecido no construtor
        this.Autor = autor;
    }

    // Método para exibir a descrição interna do livro
    public void ExibirDescricaoInterna()
    {
        // Utilizando a propriedade Titulo da classe base e a propriedade DescricaoInterna
        Console.WriteLine($"Descrição Interna do Livro '{Titulo}': {DescricaoInterna}");
    }
}
