using System;
using System.IO;
using Dados;
using Util;


namespace Terminal
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //Cria um objeto do tipo Validação da Biblioteca Util
            Validacao validacao = new Validacao();

            //Cumprimenta a pessoa
            Console.WriteLine("Bem-vindo ao Internet Banking.");
            Console.WriteLine("Selecione uma opção:");

            string opcao = "";

            //Menu principal
            do{
                Console.WriteLine("1 - Cadastrar cliente.");
                Console.WriteLine("2 - Sacar.");
                Console.WriteLine("3 - Depositar.");
                Console.WriteLine("4 - Saldo.");
                Console.WriteLine("9 - Sair.");

                opcao = Console.ReadLine();
                            
                switch(opcao)
                {
                    case "1":
                    {
                        CadastrarConta();
                        break;
                    }
                
                }
            }while (true);
            {
                
            }
        
        }
                          
        static void CadastrarConta(){
            
           
        } 
        
    }
}

