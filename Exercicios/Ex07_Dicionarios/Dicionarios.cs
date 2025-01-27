namespace Exercicios.Ex07_Dicionarios;

/*
01 - Criar um dicionário que represente um aluno, com uma lista de notas, e mostre a média de suas notas na tela.
02 - Criar um programa que gerencie o estoque de uma loja. Utilize um dicionário para armazenar produtos e suas quantidades em estoque e 
mostre, a partir do nome de um produto, sua quantidade em estoque.
03 - Crie um programa que implemente um quiz simples de perguntas e respostas. Utilize um dicionário para armazenar as perguntas e as respostas 
corretas.
04 - Criar um programa que simule um sistema de login utilizando um dicionário para armazenar nomes de usuário e senhas.

-- #### Passos ####
- Criar um dicionário representando um aluno com uma lista de notas
- Mostrar média dos alunos no console
*/

public class Dicionarios
{
    Dictionary<string, List<int>> listaMediaAlunos = new Dictionary<string, List<int>>();

    public void CadastrarAlunos()
    {
        Console.Write("Digite o nome do aluno: ");
        string nomeAluno = Console.ReadLine()!;
        listaMediaAlunos.Add(nomeAluno, new List<int>());
    }

    public void ExibirAlunosCadastrados()
    {
        foreach (string alunos in listaMediaAlunos.Keys)
        {
            Console.WriteLine($"Aluno: {alunos}");
        }
    }

    public void CadastrarNotasAlunos()
    {
        Console.Write("Digite o nome do aluno para cadastrar a nota: ");
        string aluno = Console.ReadLine()!;

        if (listaMediaAlunos.ContainsKey(aluno))
        {
            Console.Write("Digite a nota do aluno: ");
            int nota = int.Parse(Console.ReadLine()!);
            listaMediaAlunos[aluno].Add(nota);

            Console.Write($"Nota do aluno: {aluno} é {nota} \n");
        }

        else
        {
            Console.WriteLine($"O aluno: {aluno} não foi encontrado, digite qualquer tecla para voltar ao menu");
            Console.ReadKey();
        }

    }

    public void ExibirNotasAlunos()
    {
        foreach (var aluno in listaMediaAlunos)
        {
            string nome = aluno.Key;
            List<int> notas = aluno.Value;
            Console.WriteLine($"Aluno: {nome},\nNota: {string.Join(", ", notas)} ");
        }
    }

    public void Menu()
    {
        int opcao;
        do
        {
            Console.WriteLine("\n1 - Cadastrar Alunos\n" +
            "2 - Cadastrar notas para alunos\n" +
            "3 - Exibir alunos cadastrados\n" +
            "4 - Exibir Notas dos Alunos\n" +
            "0 - Sair\n");
            opcao = int.Parse(Console.ReadLine()!);
            switch (opcao)
            {
                case 1:
                    CadastrarAlunos();
                    break;
                case 2:
                    CadastrarNotasAlunos();
                    break;
                case 3:
                    ExibirAlunosCadastrados();
                    break;
                case 4:
                    ExibirNotasAlunos();
                    break;

                default:
                    Console.WriteLine("Saindo...");
                    break;
            }
        }
        while (opcao != 0);

    }
    
    public void teste()
    {

    }
}
