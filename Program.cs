using ExercicioFixacaoVetoresAula71;
using System;
using System.Net.Http.Headers;
using System.Threading.Channels;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program {
        static void Main(string[] args) {

            Console.Write("Quantos quartos serao alugados? ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();

            DadosHospedes[] vect = new DadosHospedes[10];

            for (int i = 0; i < n; i++) {
                Console.WriteLine("Aluguel #" + (i + 1) + ":");
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());
                Console.WriteLine();

                vect[quarto] = new DadosHospedes { Nome = nome, Email = email, Quarto = quarto };
            }

            Console.WriteLine("Quartos ocupados:");

            for (int i = 0; i < 10; i++) {
                if (vect[i] != null) {
                    Console.WriteLine(vect[i]);
                }
            }

        }
    }
}


