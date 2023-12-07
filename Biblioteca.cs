// Definindo a classe Biblioteca
class Biblioteca
{
    // Lista privada para armazenar os itens na biblioteca
    private List<ItemBiblioteca> colecao;

    // Construtor da classe Biblioteca, inicializa a colecao como uma nova lista vazia
    public Biblioteca()
    {
        colecao = new List<ItemBiblioteca>();
    }

    // Método para adicionar um item à colecao da biblioteca
    public void AdicionarItem(ItemBiblioteca item)
    {
        colecao.Add(item);
    }

    // Método para remover um item da colecao da biblioteca
    public void RemoverItem(ItemBiblioteca item)
    {
        colecao.Remove(item);
    }

    // Método para buscar um item por título na colecao da biblioteca
    public ItemBiblioteca BuscarItemPorTitulo(string titulo)
    {
        // Utiliza o método Find da List para encontrar o item pelo título
        return colecao.Find(item => item.Titulo == titulo);
    }

    // Método para buscar um item por ID na colecao da biblioteca
    public ItemBiblioteca BuscarItemPorId(int id)
    {
        // Utiliza o método Find da List para encontrar o item pelo ID
        return colecao.Find(item => item.Id == id);
    }
}
