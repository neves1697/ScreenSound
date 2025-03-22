namespace Exercicios._10_Dicionario_Login;
/*
04 - Criar um programa que simule um sistema de login utilizando um dicionário para armazenar nomes de usuário e senhas.
- #### Passos
- Criar um dicionário do tipo string e string. Porque a senha pode ter caracteres especiais.
- Criar um método para cadastrar o usuário e senha.
- Criar um método para exibir todos os usuários.
*/
public class Login
{
    Dictionary<string, string> nomeSenhaUsuarios = new Dictionary<string, string>();

    public void CadastrarUsuarios()
    {
        Console.Write("Digite seu nome: ");
        string nome = Console.ReadLine()!;
        Console.Write("Digite a senha: ");
        string senha = Console.ReadLine()!;
        Console.WriteLine("\n");

        nomeSenhaUsuarios.Add(nome, senha);
    }

    public void ExibirUsuarios()
    {
        foreach (var usuarios in nomeSenhaUsuarios)
        {
            var a = nomeSenhaUsuarios.Keys;
            var b = nomeSenhaUsuarios.Values;
            Console.WriteLine(usuarios);
        }
    }

    public void FazerLogin()
    {
        Console.Write("Usuário: ");
        string login = Console.ReadLine()!;
        Console.Write("Senha: ");
        string senha = Console.ReadLine()!;

        VerificaUsuarioCadastrado(login, senha);

    }

    public bool VerificaUsuarioCadastrado(string login, string senha)
    {
        foreach (var dados in nomeSenhaUsuarios)
        {
            if (nomeSenhaUsuarios.ContainsKey(login) && nomeSenhaUsuarios.ContainsValue(senha))
            {
                Console.WriteLine($"\nUsuário: {login}\n Senha: {senha} corretos. \nLogin efetuado com sucesso!. ");
            }
            else
            {
                Console.WriteLine($"Login: {login} ou senha: {senha} incorretos, tente novamente. ");
            }
        }
        return true;
    }
    public void Menu()
    {
        int opcao;
        do
        {
            Console.WriteLine("1 - Cadastrar usuários\n" +
                "2 - Exibir usuários cadastrados\n" +
                "3 - Fazer login\n" +
                "0 - Sair\n");
            opcao = int.Parse(Console.ReadLine()!);
            switch (opcao)
            {
                case 1:
                    CadastrarUsuarios();
                    break;
                case 2:
                    ExibirUsuarios();
                    break;
                case 3:
                    FazerLogin();
                    break;
                default:
                    Console.WriteLine("Dados inválidos...\n");
                    break;
            }
        }
        while (opcao != 0);

    }

}