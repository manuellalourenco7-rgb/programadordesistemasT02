using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculadoramatrizes
{
    public class Matriz
    {
        public int Linhas { get; }
        public int Colunas { get; }
        private double[,] _dados;

        public Matriz(int linhas, int colunas)
        {
            Linhas = linhas;
            Colunas = colunas;
            _dados = new double[linhas, colunas];
        }

        public double this[int i, int j]
        {
            get => _dados[i, j];
            set => _dados[i, j] = value;
        }

        public static Matriz Somar(Matriz a, Matriz b)
        {
            if (a.Linhas != b.Linhas || a.Colunas != b.Colunas)
                throw new InvalidOperationException("Matrizes incompatíveis para soma.");

            var resultado = new Matriz(a.Linhas, a.Colunas);
            for (int i = 0; i < a.Linhas; i++)
                for (int j = 0; j < a.Colunas; j++)
                    resultado[i, j] = a[i, j] + b[i, j];
            return resultado;
        }

        public static Matriz Subtrair(Matriz a, Matriz b)
        {
            if (a.Linhas != b.Linhas || a.Colunas != b.Colunas)
                throw new InvalidOperationException("Matrizes incompatíveis para subtração.");

            var resultado = new Matriz(a.Linhas, a.Colunas);
            for (int i = 0; i < a.Linhas; i++)
                for (int j = 0; j < a.Colunas; j++)
                    resultado[i, j] = a[i, j] - b[i, j];
            return resultado;
        }

        public static Matriz Multiplicar(Matriz a, Matriz b)
        {
            if (a.Colunas != b.Linhas)
                throw new InvalidOperationException("Matrizes incompatíveis para multiplicação.");

            var resultado = new Matriz(a.Linhas, b.Colunas);
            for (int i = 0; i < a.Linhas; i++)
            {
                for (int j = 0; j < b.Colunas; j++)
                {
                    double soma = 0;
                    for (int k = 0; k < a.Colunas; k++)
                        soma += a[i, k] * b[k, j];
                    resultado[i, j] = soma;
                }
            }
            return resultado;
        }
    }
}
