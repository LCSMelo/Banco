using System;
using Util;

namespace Dados
{
    public class ContaPessoaJuridica : Conta
    {
        public string NomeCliente { get; set; }
        public string DataNascimento { get; set; }
        
        /// <summary>
        /// Efetua um saque na conta da pessoa jurídica mais 10 centavos
        /// </summary>
        /// <param name="Valor">Recebe um parâmetro do tipo double com o valor do saque</param>
        /// <returns>Retorna o valor do Saldo</returns>
        public override double Sacar(double Valor){
            base.Sacar(Valor + 0.10);

            return this.Saldo;
        }
        
        /// <summary>
        /// Efetua um depósito na conta da pessoa jurídica mais 10 centavos
        /// </summary>
        /// <param name="Valor">Recebe um parâmetro do tipo double com o valor do depósito</param>
        /// <returns>Retorna o valor do Saldo</returns>
        public override double Depositar(double Valor){
            Console.WriteLine("Efetuou um depósito no valor de:" + Valor);
            base.Depositar(Valor + 0.10);

            return this.Saldo;
        }

        public void CadastrarConta(string Numero, string Agencia, double Saldo, string RazaoSocial, DateTime DataAbertura, string CNPJ){


        Console.Write("Digite a Razão Social:");
            string razaosocial = Console.ReadLine();

            Console.Write("Digite a data de abertura:");
            string dataabertura = Console.ReadLine();

            Validacao validacao = new Validacao();
            bool cnpjvalido = false;

            do {
            Console.Write("Digite o CNPJ: ");
            string cnpj = Console.ReadLine();
            cnpjvalido = validacao.ValidarCNPJ(cnpj);

            if(cnpjvalido == false){
                    Console.WriteLine("CNPJ inválido.");
                }
            } 

            while (cnpjvalido != true);//Faça enquanto o cpf inválido

            Console.Write("Digite o número de sua conta: ");
            string numeroconta = Console.ReadLine();

            Console.Write("Digite a agência: ");
            string agencia = Console.ReadLine();

            Console.Write("Digite o saldo: ");
            double saldo = Convert.ToDouble(Console.ReadLine());

            
        }
            
    }
}
    
