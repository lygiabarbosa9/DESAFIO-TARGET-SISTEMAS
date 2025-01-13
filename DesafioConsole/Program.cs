using DESAFIO_TARGET;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Escolha o programa para executar:");
        Console.WriteLine("1 - Questão 1");
        Console.WriteLine("2 - Questão 2");
        Console.WriteLine("3 - Questão 3");
        Console.WriteLine("4 - Questão 4");
        Console.WriteLine("5 - Questão 5");

        string escolha = Console.ReadLine();

        switch (escolha)
        {
            case "1":
                var soma = new Soma();
                Console.WriteLine($"Resultado da questão 1: {soma.CalculateSum()}");
                break;

            case "2":
                var problem2 = new Fibonnaci();
                Console.WriteLine("Informe um número para verificar na sequência de Fibonacci:");
                int num = int.Parse(Console.ReadLine());
                Console.WriteLine(problem2.IsInFibonacci(num) ? "Número pertence à sequência." : "Número não pertence à sequência.");
                break;

            case "3":
                var problem3 = new Faturamento();
                Console.WriteLine("Informe os valores do faturamento diário, separados por vírgula:");
                var input = Console.ReadLine().Split(',').Select(double.Parse).ToList();
                problem3.AnalyzeFaturamento(input);
                break;

            case "4":
                var problem4 = new Distribuidora();
                problem4.CalculatePercentage();
                break;

            case "5":
                var problem5 = new CaracteresString();
                Console.WriteLine("Digite uma string para inverter:");
                string inputString = Console.ReadLine();
                Console.WriteLine($"String invertida: {problem5.ReverseString(inputString)}");
                break;

            default:
                Console.WriteLine("Opção inválida.");
                break;
        }
    }
}