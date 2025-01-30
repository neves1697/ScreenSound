namespace Exercicios.Ex08_Dicionarios_Estoque;
/*
02 - Criar um programa que gerencie o estoque de uma loja. Utilize um dicionário para armazenar produtos e suas quantidades em estoque e 
mostre, a partir do nome de um produto, sua quantidade em estoque. 

#### Passos ###
- Criar um dicionário para produtos(string, int)
- Criar função para exibir os produtos e quantidade em estoque
- Criar função para exibir o produto procurado e seu estoque
*/

public class Estoque
{
    Dictionary<string, List<int>> listaProdutos = new Dictionary<string, List<int>>();

    public void CadastrarProdutos()
    {
        //Console.Clear();
        Console.Write("Digite o produto: ");
        string produto = Console.ReadLine()!;
        listaProdutos.Add(produto, new List<int>());
    }

    public void ValidaListaVaza(Dictionary<string, List<int>> listaRecebida)
    {
        if (listaRecebida.Count == 0)
        {
            Console.Clear();
            Console.WriteLine("Lista vazia...\n" +
                "Cadastre produtos\n");
            Console.WriteLine("Cadastrar produtos?\n" +
                "1 - Sim\n" +
                "2 - Não\n");
            int opcao = int.Parse(Console.ReadLine()!);
            if (opcao == 1)
            {
                CadastrarProdutos();
            }
            else if (opcao == 2)
            {
                Menu();
            }
        }
    }

    public void ExibirProdutosCadastrados()
    {
        ValidaListaVaza(listaProdutos);
        foreach (var produto in listaProdutos.Keys)
        {
            Console.WriteLine($"Produto: {produto} ");
        }
    }

    public void CadastrarEstoqueProdutos()
    {
        ValidaListaVaza(listaProdutos);
        Console.Write("Digite o produto: ");
        string produto = Console.ReadLine()!;

        if (listaProdutos.ContainsKey(produto))
        {
            Console.Write("Digite o estoque: ");
            int estoque = int.Parse(Console.ReadLine()!);
            listaProdutos[produto].Add(estoque);
            Console.Write($"Estoque atualizado para o produto: {produto}");
        }
    }

    public void BuscaProdutosCadastrados()
    {
        ValidaListaVaza(listaProdutos);
        Console.Write("Digite o produto: ");
        string produto = Console.ReadLine()!;

        if (listaProdutos.ContainsKey(produto))
        {
            List<int> quantidadeProduto = listaProdutos[produto];
            Console.WriteLine($"Produto: {produto}\nEstoque: {quantidadeProduto.Sum()}\n ");
        }
        else
        {
            Console.WriteLine("Não há este produto cadastrado...\n");
            Console.WriteLine("Cadastrar?\n" +
                "1 - Sim\n" +
                "2 - Não\n");
            int opcao = int.Parse(Console.ReadLine()!);
            if (opcao == 1)
            {
                CadastrarProdutos();
            }
            else if (opcao == 2)
            {
                Console.WriteLine("Voltando para a tela inicial...\n");
                Thread.Sleep(2000);
                Menu();
                Console.Clear();
            }
        }
    }

    public void ExibirTodasAsInformacoesProdutos()
    {
        ValidaListaVaza(listaProdutos);
        foreach (var produtos in listaProdutos)
        {
            string descricaoProduto = produtos.Key;
            List<int> quantidadeProduto = produtos.Value;
            int estoqueTotal = quantidadeProduto.Sum();
            Console.WriteLine($"Produto: {descricaoProduto}\nEstoques detalhados: {string.Join(", ", quantidadeProduto)}\n" +
                $"Estoque total: {quantidadeProduto.Sum()} ");
        }
    }

    public void Menu()
    {
        int opcao;
        do
        {
            Console.WriteLine("\n1 - Cadastrar Produtos\n" +
            "2 - Exibir produtos cadastrados\n" +
            "3 - Cadastrar Estoque Produto\n" +
            "4 - Exibir estoque dos produtos\n" +
            "5 - Exibir todos os produtos e estoques\n" +
            "0 - Sair\n");
            opcao = int.Parse(Console.ReadLine()!);
            switch (opcao)
            {
                case 1:
                    CadastrarProdutos();
                    break;
                case 2:
                    ExibirProdutosCadastrados();
                    break;
                case 3:
                    CadastrarEstoqueProdutos();
                    break;
                case 4:
                    BuscaProdutosCadastrados();
                    break;
                case 5:
                    ExibirTodasAsInformacoesProdutos();
                    break;
                default:
                    Console.WriteLine("-");
                    break;
            }
        }
        while (opcao != 0);

    }
}
