using System;
using Generics.Models;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            var carro = new Carro
            {
                Modelo = "Uno",
                Marca = "Fiat"
            };

            var pessoa = new Pessoa
            {
                Nome = "Bom Bom",
                Cpf = "12345678910"
            };

            Serializador.Serializar(carro);
            Serializador.Serializar(pessoa);

            var novoCarro = Serializador.Deserializar<Carro>();
            var novaPessoa = Serializador.Deserializar<Pessoa>();

            Console.WriteLine($"{carro.Modelo} - {novoCarro.Modelo}");
            Console.WriteLine($"{pessoa.Nome} - {novaPessoa.Nome}");
            Console.ReadKey();
        }
    }
}
