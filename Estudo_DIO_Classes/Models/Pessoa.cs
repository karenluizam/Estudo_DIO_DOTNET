namespace Estudo_DIO_Classes;



public class Pessoa
{
    // Atributos
    public string Nome="padrao";
    public int Idade=0;

    // Método
    public void Apresentar()
    {
        Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} anos.");
    }
}
