// See https://aka.ms/new-console-template for more information

Console.WriteLine("=== Desafio 1: Conta do Restaurante ===");
double valorConta = 120.00;
double taxaServico = 0.10;
double valorTaxa = valorConta * taxaServico;
double valorFinal = valorConta + valorTaxa;
Console.WriteLine($"Valor da taxa de serviço: R$ {valorTaxa:F2}");
Console.WriteLine($"Valor final a pagar: R$ {valorFinal:F2}");

Console.WriteLine("=== Desafio 2: Consumo de Combustível ===");
double distancia = 350;
double litros = 25;
double consumoMedio = distancia / litros;
Console.WriteLine($"Consumo médio: {consumoMedio:F2} km/l");

Console.WriteLine("=== Desafio 3: Divisão de Conta entre Amigos ===");
double valorTotal = 170.00;
int qtdAmigos = 3;
double valorPorPessoa = valorTotal / qtdAmigos;
Console.WriteLine($"Valor por pessoa: R$ {valorPorPessoa:F2}");
Console.WriteLine($"Cada pessoa deve pagar: R$ {valorPorPessoa:F2}");
