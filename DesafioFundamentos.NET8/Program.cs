﻿using DesafioFundamentos.NET8;
using DesafioFundamentos.NET8.Models;

  
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        decimal precoInicial = 0;
        decimal precoPorHora = 0;

        Console.WriteLine("Sistema de estacionamento!\n" +
                          "Digite o preço inicial:");
        precoInicial = Convert.ToDecimal(Console.ReadLine());

        Console.WriteLine("Agora digite o preço por hora:");
        precoPorHora = Convert.ToDecimal(Console.ReadLine());

        // Instancia a classe Estacionamento
        Estacionamento es = new Estacionamento(precoInicial, precoPorHora);

        bool tela = true;

        // Loop do menu
        while (tela)
        {
            Console.Clear();
            Console.WriteLine("Digite a sua opção:");
            Console.WriteLine("1 - Cadastrar veículo");
            Console.WriteLine("2 - Remover veículo");
            Console.WriteLine("3 - Listar veículos");
            Console.WriteLine("4 - Encerrar");

            switch (Console.ReadLine())
            {
                case "1":
                    es.AdicionarVeiculo();
                    break;

                case "2":
                    es.RemoverVeiculo();
                    break;

                case "3":
                    es.ListarVeiculos();
                    break;

                case "4":
                    tela = false;
                    break;

                default:
                    Console.WriteLine("Opção inválida");
                    break;
            }

            Console.WriteLine("Pressione uma tecla para continuar");
            Console.ReadLine();
        }

        Console.WriteLine("Programa encerrou");