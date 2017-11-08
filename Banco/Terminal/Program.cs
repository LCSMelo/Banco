﻿using System;
using Dados;
using Util;


namespace Terminal
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
            //Cria um objeto do tipo Validação da Biblioteca Util
            Validacao validacao = new Validacao();

            //Declaração de variáveis
            bool cpfvalido = false;
            string cpf = "";

            //Cumprimenta a pessoa
            Console.WriteLine("Bem-vindo ao Internet Banking.");

            do{
                //Pede o cpf para o usuário
                Console.Write("Informe seu CPF: ");
                // Recebe o cpf do usuário
                cpf = Console.ReadLine();

                // Recebe o retorno do método Validar CPF
                cpfvalido = validacao.ValidarCPF(cpf);
                
                //Caso seja um cpf inválido o usuário será informado
                if(cpfvalido == false){
                    Console.WriteLine("CPF inválido");
                }
            } 

            while (cpfvalido == false);//Faça enquanto o cpf inválido
                
                Console.WriteLine("Cpf válido.");
            

          
            //Cria o objeto do tipo Conta e instancia
            Conta conta = new Conta();
            
            //Deposita o valor na conta
            conta.Depositar(250.00);

            //Mostra o saldo da conta
            Console.WriteLine("Seu Saldo atual é de: "+ conta.Saldo);

            //Saca o valor da conta
            conta.Sacar(150.00);
            
            //Mostra o saldo da conta
            Console.WriteLine("Seu Saldo atual é de: "+ conta.Saldo);
            */
            
            ContaPessoaFisica contapf = new ContaPessoaFisica();
            //Saca o valor da conta
            contapf.Sacar(50.00);

            //Mostra o saldo da conta
            Console.WriteLine("Seu Saldo atual é de: "+ contapf.Saldo);

            //Deposita o valor na conta
            contapf.Depositar(100.00);

            //Mostra o saldo da conta
            Console.WriteLine("Seu Saldo atual é de: "+ contapf.Saldo);

            ContaPessoaJuridica contapj = new ContaPessoaJuridica();
            //Saca o valor da conta
            contapj.Sacar(50.00);

            //Mostra o saldo da conta
            Console.WriteLine("Seu Saldo atual é de: "+ contapj.Saldo);

            //Deposita o valor na conta
            contapj.Depositar(100.00);

            //Mostra o saldo da conta
            Console.WriteLine("Seu Saldo atual é de: "+ contapj.Saldo);



        }
    }
}
