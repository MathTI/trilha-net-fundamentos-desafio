using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioFundamentos.NET8.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        // Adicionando veículo na lista e validando placa
        public void AdicionarVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string placa = Console.ReadLine();

            if (veiculos.Any(v => v.Equals(placa.ToUpper())))
            {
                Console.WriteLine("Há registro neste veiculo.");
            }
            else 
            {
                veiculos.Add(placa);
                Console.WriteLine("Veiculo registrado!");
            }
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa para remover o veículo: ");
            string placa = Console.ReadLine();
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Informe quantidade de horas");
                decimal horas = Convert.ToDecimal(Console.ReadLine());
                decimal total = precoInicial + precoPorHora * horas;
                Console.WriteLine($"Valor total: {total} ");
                veiculos.Remove(placa.ToUpper());
            }
            else
            {
                Console.WriteLine("Placa não encontrada");
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                // Realiza um laço de repetição, exibindo os veículos estacionados
                int contadorForeach = 0;
                foreach (string veiculo in veiculos)
                {
                    contadorForeach++;
                    Console.WriteLine($"{contadorForeach} - {veiculo}");
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}