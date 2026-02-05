// See https://aka.ms/new-console-template for more information
using System.Collections.Generic;

//instancia: um dado que representa um objeto na memoria. Serve para salvar dados do objeto na memoria.
//classe: um modelo que define as características e comportamentos de um objeto; 
//Serve como um molde para criar objetos (instâncias) com propriedades e métodos especícificos.
//Get ➜ "Lê" o valor (como um assistente que mostra algo).
//Set ➜ "Altera" o valor (como um guardião que protege).
//Para tornar uma informação acessível fora da classe, usamos método públicos.
//(OO)Abstração (foco no essencial), Encapsulamento (proteção de dados), Herança (reutilização de código) e Polimorfismo (múltiplas formas)

namespace classes
{
    //Definição da classe Carro
    internal class Carro
    {
        //Propriedade Pública: Pode ser acessada e modificada fora da classe
        public string Marca { get; set; } //Publica a propriedade Marca

        //Propriedade Privada: Não pode ser acessada ou modificada fora da classe
        private string Modelo { get; set; } //Privada, acessível apenas dentro da classe

        //Propriedade privada com um campo privado e um método getter e setter personalizados
        private int ano; //Campo privado

        public int Ano
        {
            get { return ano; } //Getter, para acessar o valor do campo privado
            set
            {
                if (value > 1900 && value <= DateTime.Now.Year) //Verificação para garantir um valor válido
                {
                    ano = value;
                }
                else
                {
                    Console.WriteLine("Ano inválido.");
                }
            }
        }

        //Método público para exibir informações do carro
        public void ExibirInfo()
        {
            Console.WriteLine($"Marca: {Marca}");
            Console.WriteLine($"Modelo: {Modelo}"); //Acesso ao modelo é restrito por ser privado
            Console.WriteLine($"Ano: {Ano}");
        }

        //Método para calcular a idade do carro
        public int CalcularIdade()
        {
            int anoAtual = DateTime.Now.Year;
            return anoAtual - Ano;
        }

        //Método para definir o modelo do carro (com exemplo de uso propriedade privada)
        public void DefinirModelo(string modelo)
        {
            Modelo = modelo; //Acessando a propriedade privada dentro da classe
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //Criando um objeto da classe Carro
            Carro meuCarro = new Carro();

            //Atrinuindo valores às propriedades públicas e privadas
            meuCarro.Marca = "Toyota";
            meuCarro.DefinirModelo("Corolla"); //Usando método para definir o modelo pois é privado
            meuCarro.Ano = 2020; //A propriedade Ano é pública, mas com uma validação interna

            //Exibindo as informações do carro
            meuCarro.ExibirInfo();

            //Calculando e exibindo a idade dp carro
            int idadeCarro = meuCarro.CalcularIdade();
            Console.WriteLine($"Idade do carro: {idadeCarro} anos.");

            //Mantendo o console aberto
            Console.ReadLine();
        }
    }
}
