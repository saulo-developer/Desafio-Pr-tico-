namespace desafiopratico1;
using System;
using System.Globalization; // Adicionei o using necessário

class Program
{
    static void Main()
    {
        Ler();      // Chama a função que exibe a mensagem de boas-vindas 
        Somar1();   // Chama a função que realiza a soma
        Subtrair();
        Multiplicar();
        Dividir();
        ContarPalavras1();
        DigitarPlaca1();

        DateTime dataAtual = DateTime.Now;

        // Exibe a data e hora em diferentes formatos
        Console.WriteLine("Escolha um formato de exibição:");
        Console.WriteLine("1 - Formato completo (dia da semana, dia do mês, mês, ano, hora, minutos, segundos)");
        Console.WriteLine("2 - Apenas a data (DD/MM/AAAA)");
        Console.WriteLine("3 - Apenas a hora (formato de 24 horas)");
        Console.WriteLine("4 - Data com o mês por extenso (ex: 20 de Outubro de 2024)");

        // Lê a escolha do usuário
        string escolha = Console.ReadLine();

        // Exibe a data de acordo com a escolha do usuário
        switch (escolha)
        {
            case "1":
                // Formato completo
                Console.WriteLine(dataAtual.ToString("dddd, dd 'de' MMMM 'de' yyyy, HH:mm:ss", new CultureInfo("pt-BR")));
                break;
            case "2":
                // Apenas a data no formato DD/MM/AAAA
                Console.WriteLine(dataAtual.ToString("dd/MM/yyyy"));
                break;
            case "3":
                // Apenas a hora no formato de 24 horas
                Console.WriteLine(dataAtual.ToString("HH:mm"));
                break;
            case "4":
                // Data com o mês por extenso
                Console.WriteLine(dataAtual.ToString("dd 'de' MMMM 'de' yyyy", new CultureInfo("pt-BR")));
                break;
            default:
                Console.WriteLine("Opção inválida.");
                break;
        }

        // Chama o método para calcular a média (se necessário)
        // FazeraMedia(); // Descomente se quiser usar
    }

    static void Ler()
    {
        // Exibe a mensagem de boas-vindas personalizada
        Console.WriteLine("Olá, Saulo! Seja muito bem-vindo!");
        Console.ReadLine();
    }

    static void Somar1()
    {
        // Cria uma instância da classe OperacoesMatematicas
        var matematica = new OperacoesMatematicas();

        // Chama o método Somar e guarda o resultado
        var resultado = matematica.Somar(1, 1);

        // Exibe o resultado da soma
        Console.WriteLine($"O resultado da soma é: {resultado}");
    }

    static void Subtrair()
    {
        // Cria uma instância da classe OperacoesMatematicas
        var matematica = new OperacoesMatematicas();

        // Chama o método Subtrair e guarda o resultado
        var resultado = matematica.Subtrair(1, 1);

        // Exibe o resultado da subtração
        Console.WriteLine($"O resultado da subtração é: {resultado}"); // Corrigido de soma para subtração
    }

    static void Multiplicar()
    {
        var matematica = new OperacoesMatematicas();
        var resultado = matematica.Multiplicar(5, 5);
        Console.WriteLine($"O resultado da multiplicação é: {resultado}");
    }

    static void Dividir()
    {
        var matematica = new OperacoesMatematicas();
        var resultado = matematica.Divisao2(10, 2);
        Console.WriteLine($"O resultado da divisão é: {resultado}");
    }

    static void FazeraMedia()
    {
        var matematica = new OperacoesMatematicas();
        var resultado = matematica.FazeraMedia1(20, 20, 2);
        Console.WriteLine($"O resultado da média é: {resultado}");
    }

    static void ContarPalavras1()
    {
        // Solicitar entrada do usuário
        Console.WriteLine("Digite uma ou mais palavras:");
        string palavras = Console.ReadLine();

        // Verifica se o usuário não digitou uma string vazia ou nula
        if (string.IsNullOrEmpty(palavras))
        {
            Console.WriteLine("Você não digitou nenhuma palavra!");
            return; // Sai da função se não houver entrada
        }

        // Contar palavras e exibir o resultado
        int contagem = palavras.Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries).Length;
        Console.WriteLine($"Você digitou {contagem} palavras.");
    }

    static void DigitarPlaca1()
    {
        // Solicita a placa do usuário
        Console.Write("Digite a placa do veículo: ");
        string placa = Console.ReadLine();

        // Verifica se a placa está no formato válido (AAA9999)
        bool placaValida = VerificarPlaca(placa);

        // Exibe o resultado
        if (placaValida)
        {
            Console.WriteLine("Verdadeiro");
        }
        else
        {
            Console.WriteLine("Falso");
        }
    }

    private static bool VerificarPlaca(string? placa)
    {
        // Verifica se a placa está no formato AAA9999
        return System.Text.RegularExpressions.Regex.IsMatch(placa ?? "", @"^[A-Z]{3}\d{4}$");
    }
}

