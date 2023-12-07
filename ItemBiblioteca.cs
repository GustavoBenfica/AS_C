// Definindo uma classe abstrata chamada ItemBiblioteca
abstract class ItemBiblioteca
{
    // Propriedade pública para o ID do item na biblioteca
    public int Id { get; set; }

    // Propriedade pública para o título do item na biblioteca
    public string Titulo { get; set; }

    // Campo protegido para armazenar a descrição interna do item
    protected string DescricaoInterna;

    // Construtor da classe ItemBiblioteca
    public ItemBiblioteca(int id, string Titulo)
    {
        // Inicializando a descrição interna com um valor padrão
        DescricaoInterna = "descrição padrão";

        // Inicializando as propriedades Id e Titulo com os valores fornecidos no construtor
        this.Id = id;
        this.Titulo = Titulo;
    }
}
