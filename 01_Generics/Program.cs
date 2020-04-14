using System;
using _01_Generics.Modelos;

namespace _01_Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro carro = new Carro() { Marca = "FIAT", Modelo = "UNO" };
            Casa casa = new Casa() { Cidade = "Brasília", Endereco = "QSQ 454" };
            Usuario usuario = new Usuario() { Nome = "Maria", Email = "maria@gmail.com", Senha = "123456" };

            Serializador.Serializar(carro);
            Serializador.Serializar(casa);
            Serializador.Serializar(usuario);

            Carro carro2 = Serializador.Deserializar<Carro>();
            Casa casa2 = Serializador.Deserializar<Casa>();
            Usuario usuario2 = Serializador.Deserializar<Usuario>();

            Console.WriteLine("Carro2: " + carro2.Marca + " - " + carro2.Modelo);
            Console.WriteLine("Casa2: " + casa2.Cidade + " - " + casa2.Endereco);
            Console.WriteLine("Usuário2 " + usuario2.Nome + " - " + usuario2.Email);

            Console.WriteLine();
            Console.WriteLine("Transação Efetuada!");

            Console.ReadLine();
        }
    }
}
