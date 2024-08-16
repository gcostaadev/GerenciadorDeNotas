
using ProjetoNotas;

void ExibirLogo()
{
    Console.WriteLine(@"
▒█▀▀█ █▀▀ █▀▀█ █▀▀ █▀▀▄ █▀▀ ░▀░ █▀▀█ █▀▀▄ █▀▀█ █▀▀█ 　 █▀▀▄ █▀▀ 　 █▀▀▄ █▀▀█ ▀▀█▀▀ █▀▀█ █▀▀ 
▒█░▄▄ █▀▀ █▄▄▀ █▀▀ █░░█ █░░ ▀█▀ █▄▄█ █░░█ █░░█ █▄▄▀ 　 █░░█ █▀▀ 　 █░░█ █░░█ ░░█░░ █▄▄█ ▀▀█ 
▒█▄▄█ ▀▀▀ ▀░▀▀ ▀▀▀ ▀░░▀ ▀▀▀ ▀▀▀ ▀░░▀ ▀▀▀░ ▀▀▀▀ ▀░▀▀ 　 ▀▀▀░ ▀▀▀ 　 ▀░░▀ ▀▀▀▀ ░░▀░░ ▀░░▀ ▀▀▀");
    Console.WriteLine("Bem vindo ao Gerenciador de Notas!");
}

var gerenciaor = new Gerenciador();

void ExibirOpcoesDoMenu()
{
    ExibirLogo();
    Console.WriteLine("\n1. Add Nota");
    Console.WriteLine("2. Exibir Notas");
    Console.WriteLine("3. Sair");

    Console.Write("\nDigite a sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    switch (opcaoEscolhidaNumerica)
    {

        case 1:
            Registro();
            break;
        case 2:
            ExibirLista();
            break;
        case 3:
            Console.WriteLine("\nTchau, até mais!");
            break;
        default:
            Console.WriteLine("Opção Invalida!");
            break;

    }
}

void Registro()
{
    Console.Clear();
    ExibirTituloDaOpcao("Adicionar NOTA");
    Console.WriteLine("Digite uma Descrição:");
    var titulo = Console.ReadLine();
    gerenciaor.Adicionar(titulo);
    Thread.Sleep(4000);
    Console.Clear();
    ExibirOpcoesDoMenu();

}

void ExibirLista()
{
    Console.Clear();
    ExibirTituloDaOpcao("Todas Notas Disponiveis");
    gerenciaor.ExibirTodas();
    Thread.Sleep(4000);
    Console.Clear();
    ExibirOpcoesDoMenu();
}

void ExibirTituloDaOpcao(string titulo)
{
    int quantidadeDeLetras = titulo.Length;
    string asteriscos = string.Empty.PadLeft(quantidadeDeLetras, '*');
    Console.WriteLine(asteriscos);
    Console.WriteLine(titulo);
    Console.WriteLine(asteriscos + "\n");
}

ExibirOpcoesDoMenu();


