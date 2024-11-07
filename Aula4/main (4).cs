using System;


class Carro
{
    // Propriedades da classe Carro
    public string Marca { get; set; }
    public string Modelo { get; set; }
    public int Ano { get; set; }
    public bool Ligado { get; private set; } = false;

    // Método para ligar o carro
    public void Ligar()
    {
        if (!Ligado)
        {
            Ligado = true;
            Console.WriteLine("O carro foi ligado.");
        }
        else
        {
            Console.WriteLine("O carro já está ligado.");
        }
    }

    // Método para desligar o carro
    public void Desligar()
    {
        if (Ligado)
        {
            Ligado = false;
            Console.WriteLine("O carro foi desligado.");
        }
        else
        {
            Console.WriteLine("O carro já está desligado.");
        }
    }

    // Método para exibir informações do carro
    public void ExibirInfo()
    {
        Console.WriteLine($"Carro: {Marca} {Modelo}, Ano: {Ano}");
    }
}

class Program {
  public static void Main (string[] args) {
    // Criando um objeto da classe Carro
    Carro meuCarro = new Carro();
    meuCarro.Marca = "Toyota";
    meuCarro.Modelo = "Corolla";
    meuCarro.Ano = 2022;

    // Chamando os métodos do objeto
    meuCarro.ExibirInfo();   // Exibe as informações do carro
    meuCarro.Ligar();        // Liga o carro
    meuCarro.Desligar();     // Desliga o carro
  }
}