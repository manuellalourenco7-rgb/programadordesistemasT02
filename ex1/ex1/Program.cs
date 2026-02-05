// See https://aka.ms/new-console-template for more information
using System.Xml;

Console.WriteLine("Hello, World!");

Console.WriteLine("Qual a forma de pagamento?");
Console.WriteLine("1 - PIX");
Console.WriteLine("2 - Débito/Voucher");
Console.WriteLine("3 - Crédito");
string opcao = Console.WriteLine();
switch (opcao)
{
    case "1":
    case "PIX":
        Console.WriteLine("Forma de pagamento selecionada: PIX");
        break;
    case "2":
    case "Débito/Voucher":
        Console.WriteLine("Forma de pagamento selecionada: Débito/Voucher");
        break;
    case "3":
    case "Crédito":
        Console.WriteLine("Forma de pagamento selecionada: Crédito");
        break;
    default:
        Console.WriteLine("Opção inválida! Escolha 1, 2 ou 3.");
        break;
}

Console.WriteLine("Iniciando contagem regressiva...");
for (int i = 10; i >= 1; i--)
{
    Console.WriteLine(i + "...");
}