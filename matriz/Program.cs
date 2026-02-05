// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//A virgula entre os colchetes declara uma matriz onde o número antes da virgula é linha e
//o número depois da virgula é  coluna.
//Declaração e inicialização de uma matriz 3x2
int[,] matriz = new int[3, 2]
{
    {1,2 },
    {3,4 },
    {5,6 }
};
for (int i = 0; i < matriz.GetLength(0); i++)
{
    for (int j = 0; j < matriz.GetLength(1); j++)
    {
        Console.WriteLine(matriz[i, j] + " ");
    }
    Console.WriteLine();
}