static Tuple<float, float> header() {
    Console.Clear();

    Console.WriteLine("Primeiro valor:");
    float v1 = float.Parse(Console.ReadLine());

    Console.WriteLine("Segundo valor:");
    float v2 = float.Parse(Console.ReadLine());

    return Tuple.Create(v1, v2); 
}

static void Soma() {
    var (v1, v2) = header();
    Console.WriteLine($"O resultado da soma: {v1+v2}");
    Console.ReadKey();
    Menu();
}

static void Subtracao() {
    var (v1, v2) = header();
    Console.WriteLine($"Resultado da subtracao: {v1 - v2}");
    Console.ReadKey();
    Menu();
}

static void Divisao() {
    var (v1, v2) = header();
    Console.WriteLine($"Resultado da divisao: {v1 / v2}");
    Console.ReadKey();
    Menu();
}

static void Multiplicacao() {
    var (v1, v2) = header();
    Console.WriteLine($"Resultado da multiplicacao: {v1 * v2}");
    Console.ReadKey();
    Menu();
}

static void Menu() {
    Console.Clear();

    Console.WriteLine("O que deseja fazer?");
    Console.WriteLine("1 - Soma");
    Console.WriteLine("2 - Subtracao");
    Console.WriteLine("3 - Divisao");
    Console.WriteLine("4 - Multiplicacao");
    Console.WriteLine("5 - Sair");

    Console.WriteLine("-----------------");
    Console.WriteLine("Selecione uma opcao");

    string option = Console.ReadLine();

    switch (option) {
        case "1":
            Soma();
            break;
        case "2":
            Subtracao();
            break;
        case "3":
            Divisao();
            break;
        case "4":
            Multiplicacao();
            break;
        case "5":
            Console.WriteLine("Adeus!");
            System.Environment.Exit(0);
            break;
        default:
            Console.WriteLine("Opcao Invalida! Pressione enter para voltar ao menu");
            Console.ReadKey();
            Menu();
            break;
    }
}

Menu();
