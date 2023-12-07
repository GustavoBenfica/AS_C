
// Criando uma instância da classe Biblioteca
Biblioteca biblioteca = new();

// Criando instâncias da classe Livro com diferentes parâmetros
Livro livro1 = new(1, "O matador", "Colen Hoover");
Livro livro2 = new(2, "Diario de um banana", "Santiago Steves");
Livro livro3 = new(3, "Destrua esse Diario", "Helena Steinmetz");

// Adicionando os livros à biblioteca
biblioteca.AdicionarItem(livro1);
biblioteca.AdicionarItem(livro3);
biblioteca.AdicionarItem(livro2);

// Buscando um livro por título e exibindo uma mensagem
ItemBiblioteca livroEncontrado = biblioteca.BuscarItemPorTitulo("Diario de um banana");

        if (livroEncontrado != null)
        {
            Console.WriteLine($"Livro encontrado por título: {livroEncontrado.Titulo}");
        }
        else
        {
            Console.WriteLine("Livro não encontrado por título.");
        }

// Buscando um livro por ID e exibindo uma mensagem
ItemBiblioteca livroEncontradoPorId = biblioteca.BuscarItemPorId(3);

        if (livroEncontradoPorId != null)
        {
            Console.WriteLine($"Livro encontrado por ID: {livroEncontradoPorId.Id}");
        }
        else
        {
            Console.WriteLine("Livro não encontrado por ID.");
        }

// Exibindo informações dos livros e suas descrições internas
Console.WriteLine($"{livro1.Id}  {livro1.Titulo} {livro1.Autor}");
Console.WriteLine($"{livro2.Id}  {livro2.Titulo} {livro2.Autor}");
Console.WriteLine($"{livro3.Id}  {livro3.Titulo} {livro3.Autor}");

livro1.ExibirDescricaoInterna();
livro2.ExibirDescricaoInterna();
livro3.ExibirDescricaoInterna();
