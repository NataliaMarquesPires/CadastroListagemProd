using ProvaOakTecnologia;

List<Produto> produtos = new();
Produto produto;
int opcao;

do {
    produto = new Produto();
    Console.WriteLine("Digite o Nome do Produto: ");
    produto.Nome = Console.ReadLine();
    Console.WriteLine("Digite a Descrição do Produto: ");
    produto.Descricao = Console.ReadLine();

    //Validacao preco
    while (true) {
        Console.WriteLine("Digite o Valor do Produto: ");
        if (decimal.TryParse(Console.ReadLine(), out decimal valor)) {
            produto.Valor = valor;
            break;
        }
        else
            Console.WriteLine("Valor inválido. Digite um número!");
    }

    Console.WriteLine("Quantidade de produto em estoque:");
    produto.QtdEstoque = int.Parse(Console.ReadLine());

    produtos.Add(produto);

    //Ordenar e exibir produtos
    List<Produto> produtosOrdenados = produtos.OrderByDescending(p => p.Valor).ToList();
    Console.WriteLine("Lista de Produtos ordenadas por valor:");
    foreach (Produto p in produtosOrdenados) {
        Console.WriteLine($"O Produto {p.Nome} - Valor: R${p.Valor} - Quantidade no Estoque: {p.QtdEstoque} ");
    }
    Console.WriteLine("");
    Console.WriteLine("Deseja adcionar um novo produto? 1 para Sim ou 2 para não");
    try { 
        opcao = int.Parse(Console.ReadLine());
    } 
    catch(FormatException)
    {
        Console.WriteLine("Opção inválida: Digite 1 para Sim ou 2 para Não");
        opcao = int.Parse(Console.ReadLine());
    }
} while(opcao == 1);
