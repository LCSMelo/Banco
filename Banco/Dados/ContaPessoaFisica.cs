namespace Dados
{
    public class ContaPessoaFisica : Conta
    {
        public Pessoa Pessoa { get; set; }

        /// <summary>
        /// Efetua um saque na conta da pessoa física mais 10 centavos
        /// </summary>
        /// <param name="Valor">Recebe um parametro do tipo double com o valor do saque</param>
        /// <returns>retorna o valor do saldo</returns>
        public override double Sacar(double Valor){
            base.Sacar(Valor + 0.10);

            return this.Saldo;
        }

        /// <summary>
        /// Efetua um depósito na conta da pessoa física mais 10 centavos
        /// </summary>
        /// <param name="Valor">Recebe um parâmetro do tipo double com o valor do depósito</param>
        /// <returns>Retorna o valor do Saldo</returns>
        public override double Depositar(double Valor){
            System.Console.WriteLine("Efetuou um depósito no valor de:" + Valor);
            base.Depositar(Valor + 0.10);

            return this.Saldo;
        }
        
    }
}